using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamIdler.Properties;

namespace SteamIdler
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            // Open my github page
            System.Diagnostics.Process.Start("https://github.com/MughalAman/SteamIdler");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.BackColor = Settings.Default.BackgroundColor;
            textBox1.BackColor = Settings.Default.TextboxColor;
            textBox1.ForeColor = Settings.Default.ForegroundColor;
            comboBox1.BackColor = Settings.Default.TextboxColor;
            comboBox1.ForeColor = Settings.Default.ForegroundColor;
            label2.ForeColor = Settings.Default.ForegroundColor;
            label3.ForeColor = Settings.Default.ForegroundColor;
            button1.BackColor = Settings.Default.TextboxColor;
            button1.ForeColor = Settings.Default.ForegroundColor;


            //Change this to switch statement

            if (Properties.Settings.Default.Theme == 1)
            {
                pb1.Image = Resources.github_light;
            }
            else if(Properties.Settings.Default.Theme == 2)
            {
                pb1.Image = Resources.github_gruv;
            }
            else
            {
                pb1.Image = Resources.github_default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Settings.Default.BackgroundColor = Color.FromArgb(54, 57, 63);
                    Settings.Default.ForegroundColor = Color.White;
                    Settings.Default.TextboxColor = Color.FromArgb(32, 34, 37);

                    Settings.Default.Theme = 0;
                    Settings.Default.Save();
                    break;

                case 1:
                    Settings.Default.BackgroundColor = Color.White;
                    Settings.Default.ForegroundColor = Color.Black;
                    Settings.Default.TextboxColor = Color.FromArgb(225, 237, 234);

                    Settings.Default.Theme = 1;
                    Settings.Default.Save();
                    break;

                case 2:
                    Settings.Default.BackgroundColor = Color.FromArgb(51, 51, 51);
                    Settings.Default.ForegroundColor = Color.FromArgb(247, 177, 37);
                    Settings.Default.TextboxColor = Color.FromArgb(28, 28, 28);

                    Settings.Default.Theme = 2;
                    Settings.Default.Save();
                    break;
            }
            Settings.Default.Apikey = textBox1.Text;
            ReloadForm();
            //Form1.loadTheme(); not sure if this is working.. test on windows
        }

        private void ReloadForm()
        {
            this.BackColor = Settings.Default.BackgroundColor;
            textBox1.BackColor = Settings.Default.TextboxColor;
            textBox1.ForeColor = Settings.Default.ForegroundColor;
            comboBox1.BackColor = Settings.Default.TextboxColor;
            comboBox1.ForeColor = Settings.Default.ForegroundColor;
            label2.ForeColor = Settings.Default.ForegroundColor;
            label3.ForeColor = Settings.Default.ForegroundColor;
            button1.BackColor = Settings.Default.TextboxColor;
            button1.ForeColor = Settings.Default.ForegroundColor;


            //Change this to switch statement
            if (Properties.Settings.Default.Theme == 1)
            {
                pb1.Image = Resources.github_light;
            }
            else if (Properties.Settings.Default.Theme == 2)
            {
                pb1.Image = Resources.github_gruv;
            }
            else
            {
                pb1.Image = Resources.github_default;
            }
        }
    }
}
