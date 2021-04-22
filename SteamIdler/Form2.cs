﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steamworks;



namespace SteamIdler
{
    public partial class Form2 : Form
    {
        int seconds = 0;
        int seconds2 = 0;
        int minutes = 0;
        int minutes2 = 0;
        int hours = 0;
        int hours2 = 0;

        public Form2(long appid)
        {
            InitializeComponent();
            Environment.SetEnvironmentVariable("SteamAppId", appid.ToString());
            if (!SteamAPI.Init())
            {
                return;
            }
            picApp.Load("http://cdn.akamai.steamstatic.com/steam/apps/" + appid.ToString() + "/header_292x136.jpg");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           //Start timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //Count seconds
            
            seconds += 1;

            if(seconds == 10)
            {
                seconds2 += 1;
                seconds = 0;
            }
            else if(seconds2 == 6)
            {
                minutes += 1;
                seconds2 = 0;
            }
            else if (minutes == 10)
            {
                minutes2 += 1;
                minutes = 0;
            }
            else if (minutes2 == 6)
            {
                hours += 1;
                minutes2 = 0;
            }
            else if (hours == 10)
            {
                hours2 += 1;
                hours = 0;
            }

            this.Text = "You're Now In-Game - idling: " + hours2 + hours + ":" + minutes2 + minutes + ":" + seconds2 + seconds;
        }
    }
}
