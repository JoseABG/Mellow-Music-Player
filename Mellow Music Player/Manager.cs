﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mellow_Music_Player
{
    public partial class Manager : Form
    {
        private Point mouseLocation;
        private Controller controller;

        public Manager()
        {
            InitializeComponent();
            controller = new Controller();
            songList.DataSource = controller.getList();
        }

        private void songButton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gradientPanel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;
            }

        }

        private void gradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {

           mouseLocation = new Point(e.X, e.Y);

        }

        private void lyricsButton_Click(object sender, EventArgs e)
        {

            LyricWindow lyrics = new LyricWindow();
            lyrics.StartPosition = FormStartPosition.Manual;
            lyrics.Left = this.Right;
            lyrics.Top = this.Top;
            lyrics.Show();

        }

        private void downloadSongInfoButton_Click(object sender, EventArgs e)
        {

            SongInfoSearch songInfo = new SongInfoSearch();
            songInfo.ShowDialog();

        }

        private void songList_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                string[] filepaths = (string[]) e.Data.GetData(DataFormats.FileDrop);
                //controller.parseSongFiles();
                songList.Refresh();


                /*
                ArrayList songNames = controller.parseSongFiles(filepaths);
                foreach(String songName in songNames)
                {

                    songList.Items.Add(songName);

                }
                */


            }

        }

        private void songList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                e.Effect = DragDropEffects.All;

            }

        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            titleLabel.Text = songList.SelectedItem.ToString();

        }
    }
}
