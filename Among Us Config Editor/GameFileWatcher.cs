using Among_Us_Config_Editor.Data;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Among_Us_Config_Editor
{
    public class GameFileWatcher
        : IDisposable
    {
        private readonly string _pathPlayer;
        private readonly string _pathSettings;

        private FileSystemWatcher _playerWatcher;
        private FileSystemWatcher _settingsWatcher;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler FileChanged;

        private bool disposed;
        private Player player;
        private Settings settings;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        private int? _pet;
        public int? Pet
        {
            get { return _pet; }
            set
            {
                if (_pet != value)
                {
                    _pet = value;
                    OnPropertyChanged();
                }
            }
        }

        private int? _hat;
        public int? Hat
        {
            get { return _hat; }
            set
            {
                if (_hat != value)
                {
                    _hat = value;
                    OnPropertyChanged();
                }
            }
        }

        private int? _skin;
        public int? Skin
        {
            get { return _skin; }
            set
            {
                if (_skin != value)
                {
                    _skin = value;
                    OnPropertyChanged();
                }
            }
        }

        private int? _visor;
        public int? Visor
        {
            get { return _visor; }
            set
            {
                if (_visor != value)
                {
                    _visor = value;
                    OnPropertyChanged();
                }
            }
        }

        private int? _color;
        public int? Color
        {
            get { return _color; }
            set
            {
                if (_color != value)
                {
                    _color = value;
                    OnPropertyChanged();
                }
            }
        }

        private Languages _language;
        public Languages Language
        {
            get { return _language; }
            set
            {
                if (_language != value)
                {
                    _language = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _musicVolume;
        public double MusicVolume
        {
            get { return _musicVolume; }
            set
            {
                if (_musicVolume != value)
                {
                    _musicVolume = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _sfxVolume;
        public double SfxVolume
        {
            get { return _sfxVolume; }
            set
            {
                if (_sfxVolume != value)
                {
                    _sfxVolume = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _controls;
        public int Controls
        {
            get { return _controls; }
            set
            {
                if (_controls != value)
                {
                    _controls = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _vSync;
        public bool Vsync
        {
            get { return _vSync; }
            set
            {
                if (_vSync != value)
                {
                    _vSync = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _censorChat;

        public bool CensorChat
        {
            get { return _censorChat; }
            set
            {
                if (_censorChat != value)
                {
                    _censorChat = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool InSync
        {
            get
            {
                return SettingsInSync() && PlayerInSync();
            }
        }

        private bool SettingsInSync()
        {
            return false;
        }

        private bool PlayerInSync()
        {
            return false;
        }

        public GameFileWatcher(
            string pathPlayer,
            string pathSettings)
        {
            _pathPlayer = pathPlayer;
            _playerWatcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(_pathPlayer),
                Filter = Path.GetFileName(_pathPlayer),
                NotifyFilter = NotifyFilters.LastWrite
            };

            _playerWatcher.Changed += new FileSystemEventHandler(OnChangedPlayer);
            _playerWatcher.EnableRaisingEvents = true;

            _pathSettings = pathSettings;
            _settingsWatcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(_pathSettings),
                Filter = Path.GetFileName(_pathSettings),
                NotifyFilter = NotifyFilters.LastWrite
            };

            _settingsWatcher.Changed += new FileSystemEventHandler(OnChangedSettings);
            _settingsWatcher.EnableRaisingEvents = true;

            LoadSettings();
            LoadPlayer();
        }

        private void LoadSettings()
        {
            _settingsWatcher.EnableRaisingEvents = false;

            using (StreamReader r = new StreamReader(_pathSettings))
            {
                string json = r.ReadToEnd();
                settings = JsonConvert.DeserializeObject<Settings>(json);

                _controls = settings.Input.InputMode;
                _sfxVolume = settings.Audio.SfxVolume;
                _musicVolume = settings.Audio.MusicVolume;
                _censorChat = settings.Multiplayer.CensorChat;
                _language = settings.Language.CurrentLanguage;
                _vSync = settings.Video.Vsync;
            }

            _settingsWatcher.EnableRaisingEvents = true;
        }

        private void LoadPlayer()
        {
            _playerWatcher.EnableRaisingEvents = false;

            var hats = Hats.Values
                .ToDictionary(a => a.AmongUsValue, a => (int?)a.Id);

            var skins = Skins.Values
                .ToDictionary(a => a.AmongUsValue, a => (int?)a.Id);

            var pets = Pets.Values
                .ToDictionary(a => a.AmongUsValue, a => (int?)a.Id);

            var colors = Colors.Values
                .ToDictionary(a => a.AmongUsValue, a => (int?)a.Id);

            var visors = Visors.Values
                .ToDictionary(a => a.AmongUsValue, a => (int?)a.Id);

            using (StreamReader r = new StreamReader(_pathPlayer))
            {
                string json = r.ReadToEnd();
                player = JsonConvert.DeserializeObject<Player>(json);

                _name = player.Customization.Name;

                colors.TryGetValue(player.Customization.ColorID, out _color);
                hats.TryGetValue(player.Customization.Hat, out _hat);
                pets.TryGetValue(player.Customization.Pet, out _pet);
                skins.TryGetValue(player.Customization.Skin, out _skin);
                visors.TryGetValue(player.Customization.Visor, out _visor);
            }

            _playerWatcher.EnableRaisingEvents = true;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void OnChangedPlayer(object sender, FileSystemEventArgs e)
        {
            LoadPlayer();
            OnFileChanged();
        }

        private void OnChangedSettings(object sender, FileSystemEventArgs e)
        {
            LoadSettings();
            OnFileChanged();
        }

        protected void OnFileChanged()
        {
            FileChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Save()
        {
            SaveSettings();
            SavePlayer();
        }

        private void SaveSettings()
        {
            _settingsWatcher.EnableRaisingEvents = false;

            settings.Input.InputMode = _controls;
            settings.Audio.MusicVolume = _sfxVolume;
            settings.Audio.SfxVolume = _musicVolume;
            settings.Multiplayer.CensorChat = _censorChat;
            settings.Language.CurrentLanguage = _language;
            settings.Video.Vsync = _vSync;

            var serializer = new JsonSerializer()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            using (StreamWriter sw = new StreamWriter(_pathSettings))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, settings);
            }

            _settingsWatcher.EnableRaisingEvents = true;
        }

        private void SavePlayer()
        {
            _playerWatcher.EnableRaisingEvents = false;

            player.Customization.Name = _name;

            var hats = Hats.Values
                .ToDictionary(a => (int?)a.Id, a => a.AmongUsValue);

            var skins = Skins.Values
                .ToDictionary(a => (int?)a.Id, a => a.AmongUsValue);

            var pets = Pets.Values
                .ToDictionary(a => (int?)a.Id, a => a.AmongUsValue);

            var colors = Colors.Values
                .ToDictionary(a => (int?)a.Id, a => a.AmongUsValue);

            var visors = Visors.Values
                .ToDictionary(a => (int?)a.Id, a => a.AmongUsValue);

            player.Customization.ColorID = colors[_color];
            player.Customization.Hat = hats[_hat];
            player.Customization.Pet = pets[_pet];
            player.Customization.Skin = skins[_skin];
            player.Customization.Visor = visors[_visor];

            var serializer = new JsonSerializer()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            using (StreamWriter sw = new StreamWriter(_pathPlayer))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, player);
            }

            _playerWatcher.EnableRaisingEvents = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(
            bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _playerWatcher.EnableRaisingEvents = false;
                    _playerWatcher.Dispose();

                    _settingsWatcher.EnableRaisingEvents = false;
                    _settingsWatcher.Dispose();
                }
                disposed = true;
            }
        }
    }
}