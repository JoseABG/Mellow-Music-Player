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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.songButton = new System.Windows.Forms.Button();
            this.playlistsButton = new System.Windows.Forms.Button();
            this.recentlyPlayedButton = new System.Windows.Forms.Button();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.downloadSongInfoButton = new System.Windows.Forms.Button();
            this.lyricsButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.playButton2 = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.playButton1 = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // songButton
            // 
            this.songButton.Location = new System.Drawing.Point(0, 0);
            this.songButton.Margin = new System.Windows.Forms.Padding(0);
            this.songButton.Name = "songButton";
            this.songButton.Size = new System.Drawing.Size(225, 60);
            this.songButton.TabIndex = 0;
            this.songButton.Text = "Songs";
            this.songButton.UseVisualStyleBackColor = true;
            this.songButton.Click += new System.EventHandler(this.songButton_Click);
            // 
            // playlistsButton
            // 
            this.playlistsButton.Location = new System.Drawing.Point(225, 0);
            this.playlistsButton.Margin = new System.Windows.Forms.Padding(0);
            this.playlistsButton.Name = "playlistsButton";
            this.playlistsButton.Size = new System.Drawing.Size(225, 60);
            this.playlistsButton.TabIndex = 1;
            this.playlistsButton.Text = "Playlists";
            this.playlistsButton.UseVisualStyleBackColor = true;
            // 
            // recentlyPlayedButton
            // 
            this.recentlyPlayedButton.Location = new System.Drawing.Point(450, 0);
            this.recentlyPlayedButton.Margin = new System.Windows.Forms.Padding(0);
            this.recentlyPlayedButton.Name = "recentlyPlayedButton";
            this.recentlyPlayedButton.Size = new System.Drawing.Size(225, 60);
            this.recentlyPlayedButton.TabIndex = 2;
            this.recentlyPlayedButton.Text = "Recently Played";
            this.recentlyPlayedButton.UseVisualStyleBackColor = true;
            // 
            // favoritesButton
            // 
            this.favoritesButton.Location = new System.Drawing.Point(675, 0);
            this.favoritesButton.Margin = new System.Windows.Forms.Padding(0);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(225, 60);
            this.favoritesButton.TabIndex = 3;
            this.favoritesButton.Text = "Favorites";
            this.favoritesButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(533, 484);
            this.listBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(637, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 147);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // downloadSongInfoButton
            // 
            this.downloadSongInfoButton.Location = new System.Drawing.Point(579, 575);
            this.downloadSongInfoButton.Name = "downloadSongInfoButton";
            this.downloadSongInfoButton.Size = new System.Drawing.Size(100, 45);
            this.downloadSongInfoButton.TabIndex = 6;
            this.downloadSongInfoButton.Text = "Download Song Info";
            this.downloadSongInfoButton.UseVisualStyleBackColor = true;
            // 
            // lyricsButton
            // 
            this.lyricsButton.Location = new System.Drawing.Point(766, 575);
            this.lyricsButton.Name = "lyricsButton";
            this.lyricsButton.Size = new System.Drawing.Size(100, 45);
            this.lyricsButton.TabIndex = 7;
            this.lyricsButton.Text = "Lyrics";
            this.lyricsButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(702, 385);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 15);
            this.titleLabel.TabIndex = 8;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(702, 411);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(0, 15);
            this.artistLabel.TabIndex = 9;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(702, 485);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(0, 15);
            this.genreLabel.TabIndex = 10;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(702, 460);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(0, 15);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(702, 435);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(0, 15);
            this.albumLabel.TabIndex = 12;
            // 
            // playButton2
            // 
            this.playButton2.Location = new System.Drawing.Point(675, 528);
            this.playButton2.Name = "playButton2";
            this.playButton2.Size = new System.Drawing.Size(97, 27);
            this.playButton2.TabIndex = 13;
            this.playButton2.Text = "Play";
            this.playButton2.UseVisualStyleBackColor = true;
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(27, 98);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(75, 23);
            this.reverseButton.TabIndex = 14;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            // 
            // playButton1
            // 
            this.playButton1.Location = new System.Drawing.Point(123, 98);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(75, 23);
            this.playButton1.TabIndex = 15;
            this.playButton1.Text = "Play";
            this.playButton1.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(218, 98);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 23);
            this.forwardButton.TabIndex = 16;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(766, 98);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 17;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 661);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.playButton2);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lyricsButton);
            this.Controls.Add(this.downloadSongInfoButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.favoritesButton);
            this.Controls.Add(this.recentlyPlayedButton);
            this.Controls.Add(this.playlistsButton);
            this.Controls.Add(this.songButton);
            this.DoubleBuffered = true;
            this.Name = "Manager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button songButton;
        private System.Windows.Forms.Button playlistsButton;
        private System.Windows.Forms.Button recentlyPlayedButton;
        private System.Windows.Forms.Button favoritesButton;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button downloadSongInfoButton;
        private Button lyricsButton;
        private Label titleLabel;
        private Label artistLabel;
        private Label genreLabel;
        private Label yearLabel;
        private Label albumLabel;
        private Button playButton2;
        private Button reverseButton;
        private Button playButton1;
        private Button forwardButton;
        private Button shuffleButton;
    }
}

