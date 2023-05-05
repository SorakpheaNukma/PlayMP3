﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMP3
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void PLAY_Click(object sender, EventArgs e)
        {
            Player.URL = @"D:\\មនុស្សអតីត - Zono Live Session( Acoustic Guitar Cover ) [ Chheoun Vuthealey ].mp3";
            Player.controls.play();

        }

        private void STOP_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            
        }

        private void PAUSE_Click(object sender, EventArgs e)
        {
            Player.controls.previous();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
