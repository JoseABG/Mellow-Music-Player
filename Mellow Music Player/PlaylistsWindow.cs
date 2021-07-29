﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mellow_Music_Player
{
    public partial class PlaylistsWindow : Form
    {

        private Controller controller;

        public PlaylistsWindow()
        {
            InitializeComponent();
            playlistNameTextBox.Enter += new EventHandler(playlistNameTextBox_Enter);
            playlistNameTextBox.Leave += new EventHandler(playlistNameTextBox_Leave);
            defaultPlaylistNameTextBoxText();
        }

        public void initialize(Controller controller)
        {

            this.controller = controller;
            playlistsLists.DataSource = controller.getPlaylistDatabase().getPlaylists();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void defaultPlaylistNameTextBoxText()
        {

            playlistNameTextBox.Text = "Enter new playlist name here";
            playlistNameTextBox.ForeColor = Color.Gray;

        }

        private void playlistNameTextBox_Enter(object sender, EventArgs e)
        {

            if(playlistNameTextBox.Text.Equals("Enter new playlist name here"))
            {
                playlistNameTextBox.Text = "";
                playlistNameTextBox.ForeColor = Color.Black;
            }
            

        }


        private void playlistNameTextBox_Leave(object sender, EventArgs e)
        {

            if (playlistNameTextBox.Text.Equals(""))
            {

                defaultPlaylistNameTextBoxText();

            } 
            

        }

        private void addPlaylistButton_Click(object sender, EventArgs e)
        {

            String playlistName = playlistNameTextBox.Text;

            if (!playlistName.Equals("Enter new playlist name here"))
            {
                PlaylistDatabase database = controller.getPlaylistDatabase();

                Playlist playlist = new Playlist();
                playlist.name = playlistNameTextBox.Text;

                database.addPlaylist(playlist);

                playlistsLists.DataSource = null;
                playlistsLists.DataSource = database.getPlaylists();
            }

        }

        private void deletePlaylistButton_Click(object sender, EventArgs e)
        {

            if(playlistsLists.SelectedItem != null)
            {

                controller.getPlaylistDatabase().removePlaylist((Playlist)playlistsLists.SelectedItem);

                playlistsLists.DataSource = null;
                playlistsLists.DataSource = controller.getPlaylistDatabase().getPlaylists();

                
            }
            

        }

    }
}
