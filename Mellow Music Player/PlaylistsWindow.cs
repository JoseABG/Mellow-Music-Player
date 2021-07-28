using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            playlistsLists.DataSource = controller.getPlaylistDatabase().getPlaylists();
            defaultPlaylistNameTextBoxText();
        }

        public void setController(Controller controller)
        {

            this.controller = controller;

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

            PlaylistDatabase database = controller.getPlaylistDatabase();

            Playlist playlist = new Playlist();
            playlist.name = playlistNameTextBox.Text;

            database.addPlaylist(playlist);

        }
    }
}
