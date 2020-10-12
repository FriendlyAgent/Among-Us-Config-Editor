using Among_Us_Config_Editor.Data;
using Among_Us_Config_Editor.Helpers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Among_Us_Config_Editor
{
    public partial class Main
        : Form
    {
        private Settings _settings;

        private readonly Dictionary<int, Hats.Hat> _hats;
        private readonly Dictionary<int, Costumes.Costume> _costumes;
        private readonly Dictionary<int, Pets.Pet> _pets;
        private readonly Dictionary<int, Colors.Color> _colors;

        public Main()
        {
            InitializeComponent();

            lblVersionCurrent.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var localLow = GetKnownFolderPath(new Guid(ConstValues.LocalLowId));
            var path = $"{localLow}{ConstValues.PathPlayerPrefs}";

            _settings = new Settings(path);
            _settings.PropertyChanged += SettingsPropertyChanged;
            _settings.FileChanged += SettingsFileChanged;

            _hats = Hats.Values.ToDictionary(a => a.Id);
            cbHat.DataSource = Hats.Values;
            cbHat.DisplayMember = "Name";
            cbHat.ValueMember = "Id";

            _costumes = Costumes.Values.ToDictionary(a => a.Id);
            cbCostume.DataSource = Costumes.Values;
            cbCostume.DisplayMember = "Name";
            cbCostume.ValueMember = "Id";

            _pets = Pets.Values.ToDictionary(a => a.Id);
            cbPet.DataSource = Pets.Values;
            cbPet.DisplayMember = "Name";
            cbPet.ValueMember = "Id";

            _colors = Colors.Values.ToDictionary(a => a.Id);
            cbColor.DataSource = Colors.Values;
            cbColor.DisplayMember = "Name";
            cbColor.ValueMember = "Id";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetSettings();
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

            cbInvisible.Enabled = true;

            var hatId = _settings.Hat;
            cbHat.SelectedValue = _settings.Hat;
            pbHat.Image = _hats[hatId].ImageResource;
            cbHat.Enabled = true;

            var costumeId = _settings.Costume;
            cbCostume.SelectedValue = costumeId;
            pbCostume.Image = _costumes[costumeId].ImageResource;
            cbCostume.Enabled = true;

            var petId = _settings.Pet;
            cbPet.SelectedValue = petId;
            pbPet.Image = _pets[petId].ImageResource;
            cbPet.Enabled = true;

            var colorId = _settings.Color;
            cbColor.SelectedValue = colorId;
            pbColor.Image = _colors[colorId].ImageResource;
            cbColor.Enabled = true;
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
            pbPet.Image = _pets[id].ImageResource;
        }

        private void cbColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbColor.SelectedValue;
            _settings.Color = id;
            pbColor.Image = _colors[id].ImageResource;
        }

        private void cbHat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbHat.SelectedValue;
            _settings.Hat = (int)cbHat.SelectedValue;
            pbHat.Image = _hats[id].ImageResource;
        }

        private void cbCostume_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = (int)cbCostume.SelectedValue;
            _settings.Costume = id;
            pbCostume.Image = _costumes[id].ImageResource;
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

        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}