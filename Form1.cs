using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace SourceModManager
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseFileForMod_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse Mod Files";
            openFileDialog1.DefaultExt = "smodinstall";
            openFileDialog1.Filter = "Mod Installer (*.smodinstall)|*.smodinstall|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            modPath.Text = openFileDialog1.FileName;
        }

        private void ButtonModInit_Click(object sender, EventArgs e)
        {

            string extracting = "C:/Safariminer/tempdata/Source-Mod-Manager" + "/"+ RandomString(8);
            ZipFile.ExtractToDirectory(modPath.Text, extracting);
            string profilepic = extracting + "/" + "picture.png";
            pictureBox1.Image = Image.FromFile(profilepic);
        }
    }
}
