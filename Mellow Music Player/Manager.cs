using System;
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
        }

        private void songButton_Click(object sender, EventArgs e)
        {
            foreach(Song song in controller.getList())
            {

                Debug.WriteLine(song.songName);

            }


            List<Song> songs = (List<Song>)songList.DataSource;

            foreach(Song song in songs)
            {

                Debug.WriteLine(song.songName);

            }
            
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
                controller.parseSongFiles(filepaths);

                songList.DataSource = null;
                songList.DataSource = controller.getList();



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
            Song selectedSong = getCurrentSelectedSong();

            titleLabel.Text = selectedSong.songName;


        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (getCurrentSelectedSong() != null)
            {
                if (playButton1.Text.Equals("Play"))
                {


                    playButton1.Text = "Pause";
                    playButton2.Text = "Pause";

                    if (getCurrentSelectedSong().songFilepath.Equals(mediaPlayer.URL))
                    {
                        mediaPlayer.Ctlcontrols.play();
                    }
                    else
                    {

                        mediaPlayer.URL = getCurrentSelectedSong().songFilepath;
                    }

                }
                else
                {

                    playButton1.Text = "Play";
                    playButton2.Text = "Play";

                    mediaPlayer.Ctlcontrols.pause();

                }
            }
        }

        private Song getCurrentSelectedSong()
        {

            return (Song)songList.SelectedItem;

        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int songDuration = (int)mediaPlayer.Ctlcontrols.currentItem.duration;
                musicTrackbar1.Maximum = songDuration;

                musicTimer.Start();

            } else if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {

                musicTimer.Stop();

            } else if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded )
            {

                playButton1.Text = "Play";
                playButton2.Text = "Play";

            }

        }

        private void musicTimer_Tick(object sender, EventArgs e)
        {

            if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                musicTrackbar1.Value = (int)mediaPlayer.Ctlcontrols.currentPosition;

            }

        }

        private void musicTrackbar1_Scroll(object sender, EventArgs e)
        {

            if(getCurrentSelectedSong() != null)
            {

                musicTimer.Stop();

                
                mediaPlayer.Ctlcontrols.currentPosition = musicTrackbar1.Value;
                musicTimer.Start();

            }

        }
    }
}
