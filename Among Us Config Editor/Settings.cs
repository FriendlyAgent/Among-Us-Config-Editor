using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace Among_Us_Config_Editor
{
    public class Settings
        : IDisposable
    {
        private readonly string _path;
        private string[] _settings;
        private FileSystemWatcher _watcher;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler FileChanged;

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

        private int _pet;
        public int Pet
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

        private int _hat;
        public int Hat
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

        private int _costume;
        public int Costume
        {
            get { return _costume; }
            set
            {
                if (_costume != value)
                {
                    _costume = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _color;
        public int Color
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

        public bool InSync
        {
            get
            {
                return (_name == _settings[0]) &&
                    (_color == int.Parse(_settings[2])) &&
                    (_hat == int.Parse(_settings[10])) &&
                    (_costume == int.Parse(_settings[15])) &&
                    (_pet == int.Parse(_settings[16]));
            }
        }


        public Settings(
            string path)
        {
            _path = path;
            _watcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(_path),
                Filter = Path.GetFileName(_path),
                NotifyFilter = NotifyFilters.LastWrite
            };

            _watcher.Changed += new FileSystemEventHandler(OnChanged);
            _watcher.EnableRaisingEvents = true;

            LoadSettings();
        }

        private void LoadSettings()
        {
            _watcher.EnableRaisingEvents = false;

            using (var csv = new FileStream(_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(csv))
            {
                _settings = sr.ReadLine().Split(',');
            }

            _name = _settings[0];
            _color = int.Parse(_settings[2]);
            _hat = int.Parse(_settings[10]);
            _costume = int.Parse(_settings[15]);
            _pet = int.Parse(_settings[16]);

            _watcher.EnableRaisingEvents = true;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
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
            _watcher.EnableRaisingEvents = false;

            _settings[0] = _name;
            _settings[2] = _color.ToString();
            _settings[10] = _hat.ToString();
            _settings[15] = _costume.ToString();
            _settings[16] = _pet.ToString();
            File.WriteAllText(_path, string.Join(",", _settings));

            _watcher.EnableRaisingEvents = true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}