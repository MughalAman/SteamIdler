using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SteamIdler.Properties;


namespace SteamIdler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Check if steam_api.dll & Steamworks.NET.dll file exist if not then create the file from memory.
            if (!File.Exists(Application.StartupPath + "/steam_api.dll"))
            {
                File.WriteAllBytes(Application.StartupPath + "/steam_api.dll", Resources.steam_api);
                MessageBox.Show("Created missing DLL files! missing file: steam_api.dll");
            }
            if (!File.Exists(Application.StartupPath + "/Steamworks.NET.dll"))
            {
                File.WriteAllBytes(Application.StartupPath + "/Steamworks.NET.dll", Resources.Steamworks_NET);
                MessageBox.Show("Created missing DLL files! missing file: Steamworks.NET.dll");
            }

            if(SteamIdler.Properties.Settings.Default.FirstLaunch == false)
            {
                //Load saved settings | Add saved ids to textbox and change checkboxes value  
                AppIdTb.Text = SteamIdler.Properties.Settings.Default.AppIds;
                saveIdsCb.Checked = SteamIdler.Properties.Settings.Default.SaveIdsCbChecked;
            }

            SteamIdler.Properties.Settings.Default.FirstLaunch = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Code for idling | check if textbox has commas or dots(replace them) then if it has, use split and add ids to an array and make new form for every id on the array.
            if (AppIdTb.Text.Contains(",") || AppIdTb.Text.Contains("."))
            {
                if(AppIdTb.Text.Contains("."))
                {
                    AppIdTb.Text = AppIdTb.Text.Replace(".", ",");
                    Debug.WriteLine("Replaced every dot! Result: " + AppIdTb.Text);
                    MessageBox.Show("Fixed errors! Try again.");
                }
                else
                {
                    string[] appids = AppIdTb.Text.Split(',');

                    foreach (string appId in appids)
                    {
                        appId.Trim();
                        long Id = long.Parse(appId);
                        Form2 formtwo = new Form2(Id);
                        formtwo.Show();
                    }
                }
            }
            else
            {
                long Id = long.Parse(AppIdTb.Text);
                Form2 formtwo = new Form2(Id);
                formtwo.Show();
            }
        }

        private void AppIdTb_MouseHover(object sender, EventArgs e)
        {
            //Show tooltip 
            ToolTip1.Show("You can start idling multiple apps at the same time by separating appids using a comma e.g. 730, 252490", AppIdTb);
        }

        private void saveIdsCb_MouseHover(object sender, EventArgs e)
        {
            //Show tooltip
            ToolTip1.Show("Do I really need to explain this????", saveIdsCb);
        }

        private void saveIdsCb_CheckedChanged(object sender, EventArgs e)
        {
            //Code for saving settings
            if(saveIdsCb.Checked == true)
            {
                SteamIdler.Properties.Settings.Default.AppIds = AppIdTb.Text.Replace(".", ",");
                SteamIdler.Properties.Settings.Default.SaveIdsCbChecked = true;
                SteamIdler.Properties.Settings.Default.Save();
                Debug.WriteLine("Save state: true");
                Debug.WriteLine(SteamIdler.Properties.Settings.Default.AppIds);
                Debug.WriteLine(SteamIdler.Properties.Settings.Default.SaveIdsCbChecked);
            }
            else
            {
                SteamIdler.Properties.Settings.Default.AppIds = "";
                SteamIdler.Properties.Settings.Default.SaveIdsCbChecked = false;
                SteamIdler.Properties.Settings.Default.Save();
                Debug.WriteLine("Save state: false");
                Debug.WriteLine(SteamIdler.Properties.Settings.Default.AppIds);
                Debug.WriteLine(SteamIdler.Properties.Settings.Default.SaveIdsCbChecked);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["SettingsForm"] as SettingsForm) != null)
            {
                
            }
            else
            {
                SettingsForm Sform = new SettingsForm();
                Sform.Show();
            }
        }
    }
}
