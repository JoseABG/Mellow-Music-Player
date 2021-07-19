using System.Windows.Forms;

namespace Mellow_Music_Player
{
    partial class Manager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.songButton = new System.Windows.Forms.Button();
            this.playlistsButton = new System.Windows.Forms.Button();
            this.recentlyPlayedButton = new System.Windows.Forms.Button();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.playButton1 = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.songList = new System.Windows.Forms.ListBox();
            this.musicTrackbar1 = new System.Windows.Forms.TrackBar();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.musicTimer = new System.Windows.Forms.Timer(this.components);
            this.songDurationLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarPanel = new Mellow_Music_Player.GradientPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.gradientPanel1 = new Mellow_Music_Player.GradientPanel();
            this.albumLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lyricsButton = new System.Windows.Forms.Button();
            this.downloadSongInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolbarPanel.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // songButton
            // 
            this.songButton.Location = new System.Drawing.Point(0, 31);
            this.songButton.Margin = new System.Windows.Forms.Padding(0);
            this.songButton.Name = "songButton";
            this.songButton.Size = new System.Drawing.Size(193, 52);
            this.songButton.TabIndex = 0;
            this.songButton.Text = "Songs";
            this.songButton.UseVisualStyleBackColor = true;
            this.songButton.Click += new System.EventHandler(this.songButton_Click);
            // 
            // playlistsButton
            // 
            this.playlistsButton.Location = new System.Drawing.Point(193, 31);
            this.playlistsButton.Margin = new System.Windows.Forms.Padding(0);
            this.playlistsButton.Name = "playlistsButton";
            this.playlistsButton.Size = new System.Drawing.Size(193, 52);
            this.playlistsButton.TabIndex = 1;
            this.playlistsButton.Text = "Playlists";
            this.playlistsButton.UseVisualStyleBackColor = true;
            // 
            // recentlyPlayedButton
            // 
            this.recentlyPlayedButton.Location = new System.Drawing.Point(386, 31);
            this.recentlyPlayedButton.Margin = new System.Windows.Forms.Padding(0);
            this.recentlyPlayedButton.Name = "recentlyPlayedButton";
            this.recentlyPlayedButton.Size = new System.Drawing.Size(193, 52);
            this.recentlyPlayedButton.TabIndex = 2;
            this.recentlyPlayedButton.Text = "Recently Played";
            this.recentlyPlayedButton.UseVisualStyleBackColor = true;
            // 
            // favoritesButton
            // 
            this.favoritesButton.Location = new System.Drawing.Point(579, 31);
            this.favoritesButton.Margin = new System.Windows.Forms.Padding(0);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(193, 52);
            this.favoritesButton.TabIndex = 3;
            this.favoritesButton.Text = "Favorites";
            this.favoritesButton.UseVisualStyleBackColor = true;
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(12, 115);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(64, 20);
            this.reverseButton.TabIndex = 14;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // playButton1
            // 
            this.playButton1.Location = new System.Drawing.Point(94, 115);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(64, 20);
            this.playButton1.TabIndex = 15;
            this.playButton1.Text = "Play";
            this.playButton1.UseVisualStyleBackColor = true;
            this.playButton1.Click += new System.EventHandler(this.playButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(176, 115);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(64, 20);
            this.forwardButton.TabIndex = 16;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(698, 115);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(64, 20);
            this.shuffleButton.TabIndex = 17;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // songList
            // 
            this.songList.AllowDrop = true;
            this.songList.ForeColor = System.Drawing.SystemColors.InfoText;
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.Location = new System.Drawing.Point(0, 167);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(444, 407);
            this.songList.Sorted = true;
            this.songList.TabIndex = 21;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            this.songList.DragDrop += new System.Windows.Forms.DragEventHandler(this.songList_DragDrop);
            this.songList.DragEnter += new System.Windows.Forms.DragEventHandler(this.songList_DragEnter);
            this.songList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songList_MouseDown);
            // 
            // musicTrackbar1
            // 
            this.musicTrackbar1.Location = new System.Drawing.Point(265, 115);
            this.musicTrackbar1.Name = "musicTrackbar1";
            this.musicTrackbar1.Size = new System.Drawing.Size(347, 45);
            this.musicTrackbar1.TabIndex = 22;
            this.musicTrackbar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicTrackbar1.Scroll += new System.EventHandler(this.musicTrackbar1_Scroll);
            this.musicTrackbar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicTrackbar1_MouseUp);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(13, 87);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.mediaPlayer.TabIndex = 23;
            this.mediaPlayer.Visible = false;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            // 
            // musicTimer
            // 
            this.musicTimer.Interval = 1000;
            this.musicTimer.Tick += new System.EventHandler(this.musicTimer_Tick);
            // 
            // songDurationLabel
            // 
            this.songDurationLabel.AutoSize = true;
            this.songDurationLabel.Location = new System.Drawing.Point(615, 119);
            this.songDurationLabel.Name = "songDurationLabel";
            this.songDurationLabel.Size = new System.Drawing.Size(0, 13);
            this.songDurationLabel.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoriteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarPanel.BottomColor = System.Drawing.Color.SkyBlue;
            this.toolbarPanel.Controls.Add(this.closeButton);
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(772, 29);
            this.toolbarPanel.TabIndex = 20;
            this.toolbarPanel.TopColor = System.Drawing.Color.Aqua;
            this.toolbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel2_MouseDown);
            this.toolbarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradientPanel2_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(734, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 29);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.BottomColor = System.Drawing.Color.SkyBlue;
            this.gradientPanel1.Controls.Add(this.albumLabel);
            this.gradientPanel1.Controls.Add(this.yearLabel);
            this.gradientPanel1.Controls.Add(this.genreLabel);
            this.gradientPanel1.Controls.Add(this.artistLabel);
            this.gradientPanel1.Controls.Add(this.titleLabel);
            this.gradientPanel1.Controls.Add(this.playButton2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.lyricsButton);
            this.gradientPanel1.Controls.Add(this.downloadSongInfoButton);
            this.gradientPanel1.Location = new System.Drawing.Point(442, 167);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(329, 407);
            this.gradientPanel1.TabIndex = 18;
            this.gradientPanel1.TopColor = System.Drawing.Color.Aqua;
            // 
            // albumLabel
            // 
            this.albumLabel.BackColor = System.Drawing.Color.Transparent;
            this.albumLabel.Location = new System.Drawing.Point(0, 240);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(329, 13);
            this.albumLabel.TabIndex = 26;
            this.albumLabel.Text = "Sample";
            this.albumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Location = new System.Drawing.Point(0, 262);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(329, 13);
            this.yearLabel.TabIndex = 25;
            this.yearLabel.Text = "Sample";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            this.genreLabel.Location = new System.Drawing.Point(0, 283);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(329, 13);
            this.genreLabel.TabIndex = 24;
            this.genreLabel.Text = "Sample";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistLabel
            // 
            this.artistLabel.BackColor = System.Drawing.Color.Transparent;
            this.artistLabel.Location = new System.Drawing.Point(0, 219);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(329, 13);
            this.artistLabel.TabIndex = 23;
            this.artistLabel.Text = "Sample";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Location = new System.Drawing.Point(0, 197);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(329, 13);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Sample";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton2
            // 
            this.playButton2.BackColor = System.Drawing.Color.White;
            this.playButton2.Location = new System.Drawing.Point(126, 300);
            this.playButton2.Name = "playButton2";
            this.playButton2.Size = new System.Drawing.Size(83, 23);
            this.playButton2.TabIndex = 22;
            this.playButton2.Text = "Play";
            this.playButton2.UseVisualStyleBackColor = false;
            this.playButton2.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(80, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 173);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lyricsButton
            // 
            this.lyricsButton.BackColor = System.Drawing.Color.White;
            this.lyricsButton.Location = new System.Drawing.Point(206, 339);
            this.lyricsButton.Name = "lyricsButton";
            this.lyricsButton.Size = new System.Drawing.Size(86, 39);
            this.lyricsButton.TabIndex = 20;
            this.lyricsButton.Text = "Lyrics";
            this.lyricsButton.UseVisualStyleBackColor = false;
            this.lyricsButton.Click += new System.EventHandler(this.lyricsButton_Click);
            // 
            // downloadSongInfoButton
            // 
            this.downloadSongInfoButton.BackColor = System.Drawing.Color.White;
            this.downloadSongInfoButton.Location = new System.Drawing.Point(42, 339);
            this.downloadSongInfoButton.Name = "downloadSongInfoButton";
            this.downloadSongInfoButton.Size = new System.Drawing.Size(86, 39);
            this.downloadSongInfoButton.TabIndex = 19;
            this.downloadSongInfoButton.Text = "Download Song Info";
            this.downloadSongInfoButton.UseVisualStyleBackColor = false;
            this.downloadSongInfoButton.Click += new System.EventHandler(this.downloadSongInfoButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 573);
            this.Controls.Add(this.songDurationLabel);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.musicTrackbar1);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.favoritesButton);
            this.Controls.Add(this.recentlyPlayedButton);
            this.Controls.Add(this.playlistsButton);
            this.Controls.Add(this.songButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolbarPanel.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button songButton;
        private System.Windows.Forms.Button playlistsButton;
        private System.Windows.Forms.Button recentlyPlayedButton;
        private System.Windows.Forms.Button favoritesButton;
        private Button reverseButton;
        private Button playButton1;
        private Button forwardButton;
        private Button shuffleButton;
        private GradientPanel gradientPanel1;
        private Label albumLabel;
        private Label yearLabel;
        private Label genreLabel;
        private Label artistLabel;
        private Label titleLabel;
        private Button playButton2;
        private PictureBox pictureBox1;
        private Button lyricsButton;
        private Button downloadSongInfoButton;
        private GradientPanel toolbarPanel;
        private Button closeButton;
        private ListBox songList;
        private TrackBar musicTrackbar1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private Timer musicTimer;
        private Label songDurationLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem favoriteToolStripMenuItem;
    }
}

