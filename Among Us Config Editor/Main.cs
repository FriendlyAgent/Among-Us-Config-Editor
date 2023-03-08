using Among_Us_Config_Editor.Data;
using Among_Us_Config_Editor.Helpers;
using Among_Us_Config_Editor.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Among_Us_Config_Editor
{
    public partial class Main
        : Form
    {
        private GameFileWatcher _settings;

        private readonly Dictionary<int?, Image> _visors;
        private readonly Dictionary<int?, Image> _hats;
        private readonly Dictionary<int?, Image> _skins;
        private readonly Dictionary<int?, Image> _pets;
        private readonly Dictionary<int?, Image> _colors;

        public Main()
        {
            InitializeComponent();

            lblVersionCurrent.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var localLow = GetKnownFolderPath(new Guid(ConstValues.LocalLowId));
            var path = $"{localLow}{ConstValues.PathPlayer}";

            _settings = new GameFileWatcher(
                $"{localLow}{ConstValues.PathPlayer}",
                $"{localLow}{ConstValues.PathSettings}");

            _settings.PropertyChanged += SettingsPropertyChanged;
            _settings.FileChanged += SettingsFileChanged;

            _visors = Visors.Values
                .ToDictionary(a => (int?)a.Id, a => (Image)Resources.ResourceManager.GetObject($"visor_{a.AmongUsValue}"));

            _hats = Hats.Values
                .ToDictionary(a => (int?)a.Id, a => (Image)Resources.ResourceManager.GetObject($"hat_{a.AmongUsValue}"));

            _skins = Skins.Values
                .ToDictionary(a => (int?)a.Id, a => (Image)Resources.ResourceManager.GetObject($"skin_{a.AmongUsValue}"));

            _pets = Pets.Values
                .ToDictionary(a => (int?)a.Id, a => (Image)Resources.ResourceManager.GetObject($"pet_{a.AmongUsValue}"));

            _colors = Colors.Values
                .ToDictionary(a => (int?)a.Id, a => (Image)Resources.ResourceManager.GetObject($"color_{a.AmongUsValue}"));

            cbVisor.DataSource = Visors.Values;
            cbVisor.DisplayMember = "DisplayValue";
            cbVisor.ValueMember = "Id";
            cbVisor.DrawMode = DrawMode.OwnerDrawVariable;
            cbVisor.DrawItem += cbVisor_DrawItem;

            cbHat.DataSource = Hats.Values;
            cbHat.DisplayMember = "DisplayValue";
            cbHat.ValueMember = "Id";
            cbHat.DrawMode = DrawMode.OwnerDrawVariable;
            cbHat.DrawItem += cbHat_DrawItem;

            cbSkin.DataSource = Skins.Values;
            cbSkin.DisplayMember = "DisplayValue";
            cbSkin.ValueMember = "Id";
            cbSkin.DrawMode = DrawMode.OwnerDrawVariable;
            cbSkin.DrawItem += cbSkin_DrawItem;

            cbPet.DataSource = Pets.Values;
            cbPet.DisplayMember = "DisplayValue";
            cbPet.ValueMember = "Id";
            cbPet.DrawMode = DrawMode.OwnerDrawVariable;
            cbPet.DrawItem += cbPet_DrawItem;

            cbColor.DataSource = Colors.Values;
            cbColor.DisplayMember = "DisplayValue";
            cbColor.ValueMember = "Id";
            cbColor.DrawMode = DrawMode.OwnerDrawVariable;
            cbColor.DrawItem += cbColor_DrawItem;

            cbLanguage.DataSource = Enum.GetValues(typeof(Languages));

            SetSettings();
        }

        private void cbHat_DrawItem(
            object sender,
            DrawItemEventArgs e)
        {
            Draw(sender, e, _hats);
        }

        private void cbSkin_DrawItem(
            object sender,
            DrawItemEventArgs e)
        {
            Draw(sender, e, _skins);
        }

        private void cbPet_DrawItem(
            object sender,
            DrawItemEventArgs e)
        {
            Draw(sender, e, _pets);
        }

        private void cbColor_DrawItem(
            object sender,
            DrawItemEventArgs e)
        {
            Draw(sender, e, _colors);
        }

        private void cbVisor_DrawItem(
            object sender,
            DrawItemEventArgs e)
        {
            Draw(sender, e, _visors);
        }

        private void Draw(
            object sender,
            DrawItemEventArgs e,
            Dictionary<int?, Image> images)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();

            var cbo = sender as ComboBox;
            var item = (IData)cbo.Items[e.Index];

            e.Graphics.DrawString(
                item.DisplayValue,
                e.Font,
                new SolidBrush(e.ForeColor),
                e.Bounds.Left,
                e.Bounds.Top);

            if (images.ContainsKey(item.Id))
            {
                var image = images[item.Id];
                if (image != null)
                {
                    float height = e.Bounds.Height - 2;
                    float scale = height / image.Height;
                    float width = image.Width * scale;

                    RectangleF rect = new RectangleF(
                        e.Bounds.X + (e.Bounds.Width - width) - 2,
                        e.Bounds.Y,
                        width, height);

                    e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;

                    e.Graphics.DrawImage(image, rect);
                }
            }


            e.DrawFocusRectangle();
        }

        public void SetSettings()
        {
            if (_settings.Name == ConstValues.InvisibleName)
            {
                cbInvisible.CheckStateChanged -= cbInvisible_CheckStateChanged;
                cbInvisible.Checked = true;
                cbInvisible.CheckStateChanged += cbInvisible_CheckStateChanged;

                txtName.Enabled = false;

                txtName.Text = string.Empty;
            }
            else
            {
                txtName.Text = _settings.Name;

                cbInvisible.CheckStateChanged -= cbInvisible_CheckStateChanged;
                cbInvisible.Checked = false;
                cbInvisible.CheckStateChanged += cbInvisible_CheckStateChanged;

                txtName.Enabled = true;
            }

            tbSfxVolume.ValueChanged -= tbSfxVolume_ValueChanged;

            tbSfxVolume.Value = (int)(_settings.SfxVolume * 100);
            tbSfxVolume.ValueChanged += tbSfxVolume_ValueChanged;

            tbMusicVolume.ValueChanged -= tbMusicVolume_ValueChanged;
            tbMusicVolume.Value = (int)(_settings.MusicVolume * 100);
            tbMusicVolume.ValueChanged += tbMusicVolume_ValueChanged;

            cbCensorChat.CheckStateChanged -= cbCensorChat_CheckStateChanged;
            cbCensorChat.Checked = _settings.CensorChat;
            cbCensorChat.CheckStateChanged += cbCensorChat_CheckStateChanged;

            cbVSync.CheckStateChanged -= cbVSync_CheckStateChanged;
            cbVSync.Checked = _settings.Vsync;
            cbVSync.CheckStateChanged += cbVSync_CheckStateChanged;

            var hatId = _settings.Hat;
            if (hatId != null)
            {
                cbHat.SelectedValue = hatId;

                if (_hats.ContainsKey(hatId))
                {
                    pbHat.Image = _hats[hatId];
                }
            }
            else
            {
                cbHat.SelectedValue = "";
            }

            var skinId = _settings.Skin;
            if (skinId != null)
            {
                cbSkin.SelectedValue = skinId;

                if (_skins.ContainsKey(skinId))
                {
                    pbSkin.Image = _skins[skinId];
                }
            }
            else
            {
                cbSkin.SelectedValue = "";
            }

            var petId = _settings.Pet;
            if (petId != null)
            {
                cbPet.SelectedValue = petId;

                if (_pets.ContainsKey(petId))
                {
                    pbPet.Image = _pets[petId];
                }
            }
            else
            {
                cbPet.SelectedValue = "";
            }

            var colorId = _settings.Color;
            if (colorId != null)
            {
                cbColor.SelectedValue = colorId;

                if (_colors.ContainsKey(colorId))
                {
                    pbColor.Image = _colors[colorId];
                }
            }
            else
            {
                cbColor.SelectedValue = "";
            }

            var visorId = _settings.Visor;
            if (visorId != null)
            {
                cbVisor.SelectedValue = visorId;

                if (_visors.ContainsKey(visorId))
                {
                    pbVisor.Image = _visors[visorId];
                }
            }
            else
            {
                cbVisor.SelectedValue = "";
            }

            cbLanguage.SelectedItem = _settings.Language;

            if (_settings.Controls == 1)
            {
                rbMouse.CheckedChanged -= rbControls_CheckedChanged;
                rbMouse.Checked = true;
                rbMouse.CheckedChanged += rbControls_CheckedChanged;
            }
            else
            {
                rbMouseAndKeyboard.CheckedChanged -= rbControls_CheckedChanged;
                rbMouseAndKeyboard.Checked = true;
                rbMouseAndKeyboard.CheckedChanged += rbControls_CheckedChanged;
            }
        }

        void rbControls_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                if (radioButton == rbMouse)
                {
                    _settings.Controls = 1;
                }
                else
                {
                    _settings.Controls = 2;
                }
            }
        }

        private void SettingsFileChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    SetSettings();
                }));
            }
        }

        private void SettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // The last change made it so the file and visual settings are back in sync
            if (_settings.InSync)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void cbPet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbPet.SelectedValue;
            _settings.Pet = id;

            if (_pets.ContainsKey(id))
            {
                pbPet.Image = _pets[id];
            }
            else
            {
                pbPet.Image = null;
            }
        }

        private void cbColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbColor.SelectedValue;
            _settings.Color = id;
            pbColor.Image = _colors[id];

            if (_colors.ContainsKey(id))
            {
                pbColor.Image = _colors[id];
            }
            else
            {
                pbColor.Image = null;
            }
        }

        private void cbHat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbHat.SelectedValue;
            _settings.Hat = id;

            if (_hats.ContainsKey(id))
            {
                pbHat.Image = _hats[id];
            }
            else
            {
                pbHat.Image = null;
            }
        }

        private void cbSkin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbSkin.SelectedValue;
            _settings.Skin = id;

            if (_skins.ContainsKey(id))
            {
                pbSkin.Image = _skins[id];
            }
            else
            {
                pbSkin.Image = null;
            }
        }

        private void cbVisor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbVisor.SelectedValue;
            _settings.Visor = id;

            if (_visors.ContainsKey(id))
            {
                pbVisor.Image = _visors[id];
            }
            else
            {
                pbVisor.Image = null;
            }
        }

        private void cbInvisible_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbInvisible.Checked)
            {
                txtName.Enabled = false;

                txtName.Text = string.Empty;
                _settings.Name = ConstValues.InvisibleName;
            }
            else
            {
                txtName.Text = string.Empty;
                txtName.Enabled = true;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            string key = Environment.Is64BitOperatingSystem ? ConstValues.RegistryKey64 : ConstValues.RegistryKey32;
            using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(key);
            if (registryKey != null)
            {
                var installPath = (string)registryKey.GetValue("InstallPath");
                if (installPath != null)
                {
                    Process.Start($"{installPath}{@"\steam.exe"}", $"steam://rungameid/{ConstValues.SteamId}");
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _settings.Name = txtName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _settings.Save();
            btnSave.Enabled = false;
        }

        private void llbProjectSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrlHelper.OpenBrowser(ConstValues.Url);
        }

        private void llbSourceRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrlHelper.OpenBrowser(ConstValues.Url);
        }

        private void cbVSync_CheckStateChanged(object sender, EventArgs e)
        {
            _settings.Vsync = cbVSync.Checked;
        }

        private void cbCensorChat_CheckStateChanged(object sender, EventArgs e)
        {
            _settings.CensorChat = cbCensorChat.Checked;
        }
        private void tbSfxVolume_ValueChanged(object sender, EventArgs e)
        {
            _settings.SfxVolume = (double)tbSfxVolume.Value / 100;
        }

        private void tbMusicVolume_ValueChanged(object sender, EventArgs e)
        {
            _settings.MusicVolume = (double)tbMusicVolume.Value / 100;
        }

        private void cbLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _settings.Language = (Languages)cbLanguage.SelectedItem;
        }

        string GetKnownFolderPath(
            Guid knownFolderId)
        {
            IntPtr pszPath = IntPtr.Zero;
            try
            {
                int hr = SHGetKnownFolderPath(knownFolderId, 0, IntPtr.Zero, out pszPath);
                if (hr >= 0)
                {
                    return Marshal.PtrToStringAuto(pszPath);
                }

                throw Marshal.GetExceptionForHR(hr);
            }
            finally
            {
                if (pszPath != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(pszPath);
                }
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            var localLow = GetKnownFolderPath(new Guid(ConstValues.LocalLowId));
            var path = $"{localLow}{ConstValues.PathAppDataFolder}";

            Process.Start("explorer.exe", path);
        }

        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);


    }
}