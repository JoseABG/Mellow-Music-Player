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
            this.songButton = new System.Windows.Forms.Button();
            this.playlistsButton = new System.Windows.Forms.Button();
            this.recentlyPlayedButton = new System.Windows.Forms.Button();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.playButton1 = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
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
            this.toolbarPanel = new Mellow_Music_Player.GradientPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // songButton
            // 
            this.songButton.Location = new System.Drawing.Point(0, 36);
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
            this.playlistsButton.Location = new System.Drawing.Point(225, 36);
            this.playlistsButton.Margin = new System.Windows.Forms.Padding(0);
            this.playlistsButton.Name = "playlistsButton";
            this.playlistsButton.Size = new System.Drawing.Size(225, 60);
            this.playlistsButton.TabIndex = 1;
            this.playlistsButton.Text = "Playlists";
            this.playlistsButton.UseVisualStyleBackColor = true;
            // 
            // recentlyPlayedButton
            // 
            this.recentlyPlayedButton.Location = new System.Drawing.Point(450, 36);
            this.recentlyPlayedButton.Margin = new System.Windows.Forms.Padding(0);
            this.recentlyPlayedButton.Name = "recentlyPlayedButton";
            this.recentlyPlayedButton.Size = new System.Drawing.Size(225, 60);
            this.recentlyPlayedButton.TabIndex = 2;
            this.recentlyPlayedButton.Text = "Recently Played";
            this.recentlyPlayedButton.UseVisualStyleBackColor = true;
            // 
            // favoritesButton
            // 
            this.favoritesButton.Location = new System.Drawing.Point(675, 36);
            this.favoritesButton.Margin = new System.Windows.Forms.Padding(0);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(225, 60);
            this.favoritesButton.TabIndex = 3;
            this.favoritesButton.Text = "Favorites";
            this.favoritesButton.UseVisualStyleBackColor = true;
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(34, 133);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(75, 23);
            this.reverseButton.TabIndex = 14;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            // 
            // playButton1
            // 
            this.playButton1.Location = new System.Drawing.Point(130, 133);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(75, 23);
            this.playButton1.TabIndex = 15;
            this.playButton1.Text = "Play";
            this.playButton1.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(225, 133);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 23);
            this.forwardButton.TabIndex = 16;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(773, 133);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 17;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
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
            this.gradientPanel1.Location = new System.Drawing.Point(516, 193);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(384, 469);
            this.gradientPanel1.TabIndex = 18;
            this.gradientPanel1.TopColor = System.Drawing.Color.Aqua;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(198, 277);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(46, 15);
            this.albumLabel.TabIndex = 26;
            this.albumLabel.Text = "Sample";
            this.albumLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(198, 302);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(46, 15);
            this.yearLabel.TabIndex = 25;
            this.yearLabel.Text = "Sample";
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(198, 327);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(46, 15);
            this.genreLabel.TabIndex = 24;
            this.genreLabel.Text = "Sample";
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(198, 253);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(46, 15);
            this.artistLabel.TabIndex = 23;
            this.artistLabel.Text = "Sample";
            this.artistLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(198, 227);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 15);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Sample";
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // playButton2
            // 
            this.playButton2.BackColor = System.Drawing.Color.White;
            this.playButton2.Location = new System.Drawing.Point(164, 348);
            this.playButton2.Name = "playButton2";
            this.playButton2.Size = new System.Drawing.Size(97, 27);
            this.playButton2.TabIndex = 22;
            this.playButton2.Text = "Play";
            this.playButton2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            // 
            // lyricsButton
            // 
            this.lyricsButton.BackColor = System.Drawing.Color.White;
            this.lyricsButton.Location = new System.Drawing.Point(257, 393);
            this.lyricsButton.Name = "lyricsButton";
            this.lyricsButton.Size = new System.Drawing.Size(100, 45);
            this.lyricsButton.TabIndex = 20;
            this.lyricsButton.Text = "Lyrics";
            this.lyricsButton.UseVisualStyleBackColor = false;
            this.lyricsButton.Click += new System.EventHandler(this.lyricsButton_Click);
            // 
            // downloadSongInfoButton
            // 
            this.downloadSongInfoButton.BackColor = System.Drawing.Color.White;
            this.downloadSongInfoButton.Location = new System.Drawing.Point(66, 393);
            this.downloadSongInfoButton.Name = "downloadSongInfoButton";
            this.downloadSongInfoButton.Size = new System.Drawing.Size(100, 45);
            this.downloadSongInfoButton.TabIndex = 19;
            this.downloadSongInfoButton.Text = "Download Song Info";
            this.downloadSongInfoButton.UseVisualStyleBackColor = false;
            this.downloadSongInfoButton.Click += new System.EventHandler(this.downloadSongInfoButton_Click);
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarPanel.BottomColor = System.Drawing.Color.SkyBlue;
            this.toolbarPanel.Controls.Add(this.closeButton);
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(900, 33);
            this.toolbarPanel.TabIndex = 20;
            this.toolbarPanel.TopColor = System.Drawing.Color.Aqua;
            this.toolbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel2_MouseDown);
            this.toolbarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradientPanel2_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(856, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 33);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(517, 469);
            this.listBox1.TabIndex = 21;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 661);
            this.Controls.Add(this.listBox1);
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
            this.Load += new System.EventHandler(this.Manager_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private ListBox listBox1;
    }
}

