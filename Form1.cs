using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArmaServerSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ModDirPath.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PrintBox(string s)
        {
            MessageBox.Show(s);
        }

        private string AskDir(string input)
        {
            OpenFileDialog fb = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = input
            };
            if (fb.ShowDialog() == DialogResult.OK)
                return fb.FileName;
            return null;
        }

        private void CopyKeys(ArmaMod mod)
        {
            foreach (string s in Directory.GetFiles(mod.Path, "*.bisign", SearchOption.AllDirectories))
            {
                try
                {
                    File.Copy(s, BinPath.Text + "\\keys");
                }
                catch { }

            }
        }

        private string AskFile(string input)
        {
            OpenFileDialog fb = new OpenFileDialog
            {
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true,
                FileName = input
            };
            if (fb.ShowDialog() == DialogResult.OK)
                return fb.FileName;
            return null;
        }

        private string AskFile(string input, string filter)
        {
            OpenFileDialog fb = new OpenFileDialog
            {
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = filter,
                FilterIndex = 1,
                FileName = input
            };
            if (fb.ShowDialog() == DialogResult.OK)
                return fb.FileName;
            return null;
        }

        public void LoadMods(string path, bool openSelf = false)
        {
            ArmaMod mod;
            string folder;
            ModList.Items.Clear();
            if (openSelf == false)
                folder = Path.GetDirectoryName(path);
            else
                folder = path;
            ModDirPath.Text = folder;
            string[] files = Directory.GetDirectories(folder);
            Array.Sort(files, StringComparer.InvariantCulture);
            for (int i = 0; i < files.Length; i += 1)
            {
                try
                {
                    mod = new ArmaMod(files[i]);
                    ModList.Items.Insert(0, mod);
                }
                catch (ModResidual)
                {
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = AskDir("Select Mod Directory");
            if (path != null)
                LoadMods(path);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string path = AskDir("Select Profile Directory");
            if (path != null)
                ProfilePath.Text = Path.GetDirectoryName(path);
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            string path = AskFile("Select Config file");
            if (path != null)
                ConfPath.Text = path;
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SelectBin_Click(object sender, EventArgs e)
        {
            string path = AskFile("Select Config file");
            if (path != null)
                BinPath.Text = path;
        }

        private void Credit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Credit.LinkVisited = true;
                Process.Start("https://twitter.com/COLAMAroro");
            }
            catch (Exception)
            {
                MessageBox.Show(@"Could not redirect you to my twitter account");
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            var armaMods = new List<ArmaMod>();
            if (string.IsNullOrEmpty(BinPath.Text))
            {
                MessageBox.Show("Error: No executable was provided provided\nSelect an executable first", "Error: No executable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(ProfilePath.Text))
                sb.Append("\"-profiles=" + ProfilePath.Text + "\" ");
            if (!string.IsNullOrEmpty(ConfPath.Text))
                sb.Append("\"-config=" + ConfPath.Text + "\" ");
            if (!string.IsNullOrEmpty(OptionalArgs.Text))
                sb.Append(OptionalArgs.Text + " ");
            foreach (ArmaMod item in ModList.CheckedItems)
                armaMods.Add(item);
            if (armaMods.Count != 0)
            {
                sb.Append("\"-mod=");
                sb.Append(armaMods[0].Path);
                CopyKeys(armaMods[0]);
                for (var i = 1; i < armaMods.Count; i += 1) {
                    sb.Append(";" + armaMods[i].Path);
                    CopyKeys(armaMods[i]);
                }
                sb.Append("\" ");
            }
            sb.Append("\"-world=empty\"");
            MessageBox.Show(sb.ToString());
            ProcessStartInfo si = new ProcessStartInfo(BinPath.Text)
            {
                Arguments = sb.ToString()
            };
            Process.Start(si);
        }

        private void ModList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveConf_Click(object sender, EventArgs e)
        {
            var path = AskFile("Select saving file", "JSON Config File (*.json)|*.json|All files (*.*)|*.*");
            if (path == null)
                return;
            List<int> intlist = new List<int>();
            foreach (ArmaMod item in ModList.CheckedItems)
                intlist.Add(item.ID);
            SaveData save = new SaveData(ModDirPath.Text, BinPath.Text, ProfilePath.Text, ConfPath.Text, OptionalArgs.Text, intlist.ToArray());
            Saving.SaveToFile(save, path);
        }

        private void LoadConf_Click(object sender, EventArgs e)
        {
            string path = AskFile("Select loading file", "JSON Config File (*.json)|*.json|All files (*.*)|*.*");
            if (path == null)
                return;
            SaveData save = Saving.ReadFromFile(path);
            ModDirPath.Text = save.ModDir;
            LoadMods(save.ModDir, true);
            BinPath.Text = save.BinPath;
            ProfilePath.Text = save.ProfileDir;
            ConfPath.Text = save.ConfPath;
            OptionalArgs.Text = save.Args;

            ArmaMod mod;
            for (int i = 0; i < ModList.Items.Count; i += 1)
            {
                mod = (ArmaMod)ModList.Items[i];
                if (save.Enabled.Contains(mod.ID))
                    ModList.SetItemChecked(i, true);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OptionalArgs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
