
namespace Mellow_Music_Player
{
    partial class PlaylistsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lyricToolbarPanel = new Mellow_Music_Player.GradientPanel();
            this.lyricTitleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.songPlaylistList = new System.Windows.Forms.ListBox();
            this.playlistsLists = new System.Windows.Forms.ListBox();
            this.addPlaylistButton = new System.Windows.Forms.Button();
            this.deletePlaylistButton = new System.Windows.Forms.Button();
            this.playlistNameTextBox = new System.Windows.Forms.TextBox();
            this.addSongToPlaylistButton = new System.Windows.Forms.Button();
            this.deleteSongFromPlaylistButton = new System.Windows.Forms.Button();
            this.lyricToolbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lyricToolbarPanel
            // 
            this.lyricToolbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lyricToolbarPanel.BottomColor = System.Drawing.Color.SkyBlue;
            this.lyricToolbarPanel.Controls.Add(this.lyricTitleLabel);
            this.lyricToolbarPanel.Controls.Add(this.closeButton);
            this.lyricToolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.lyricToolbarPanel.Name = "lyricToolbarPanel";
            this.lyricToolbarPanel.Size = new System.Drawing.Size(600, 29);
            this.lyricToolbarPanel.TabIndex = 2;
            this.lyricToolbarPanel.TopColor = System.Drawing.Color.Aqua;
            // 
            // lyricTitleLabel
            // 
            this.lyricTitleLabel.AutoSize = true;
            this.lyricTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lyricTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic);
            this.lyricTitleLabel.Location = new System.Drawing.Point(273, 7);
            this.lyricTitleLabel.Name = "lyricTitleLabel";
            this.lyricTitleLabel.Size = new System.Drawing.Size(54, 18);
            this.lyricTitleLabel.TabIndex = 7;
            this.lyricTitleLabel.Text = "Playlists";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(560, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 29);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // songPlaylistList
            // 
            this.songPlaylistList.FormattingEnabled = true;
            this.songPlaylistList.Location = new System.Drawing.Point(0, 162);
            this.songPlaylistList.Name = "songPlaylistList";
            this.songPlaylistList.Size = new System.Drawing.Size(300, 407);
            this.songPlaylistList.TabIndex = 3;
            // 
            // playlistsLists
            // 
            this.playlistsLists.FormattingEnabled = true;
            this.playlistsLists.Location = new System.Drawing.Point(300, 162);
            this.playlistsLists.Name = "playlistsLists";
            this.playlistsLists.Size = new System.Drawing.Size(300, 407);
            this.playlistsLists.TabIndex = 4;
            // 
            // addPlaylistButton
            // 
            this.addPlaylistButton.Location = new System.Drawing.Point(202, 49);
            this.addPlaylistButton.Name = "addPlaylistButton";
            this.addPlaylistButton.Size = new System.Drawing.Size(81, 23);
            this.addPlaylistButton.TabIndex = 5;
            this.addPlaylistButton.Text = "Add Playlist";
            this.addPlaylistButton.UseVisualStyleBackColor = true;
            this.addPlaylistButton.Click += new System.EventHandler(this.addPlaylistButton_Click);
            // 
            // deletePlaylistButton
            // 
            this.deletePlaylistButton.Location = new System.Drawing.Point(236, 87);
            this.deletePlaylistButton.Name = "deletePlaylistButton";
            this.deletePlaylistButton.Size = new System.Drawing.Size(132, 23);
            this.deletePlaylistButton.TabIndex = 6;
            this.deletePlaylistButton.Text = "Delete Selected Playlist";
            this.deletePlaylistButton.UseVisualStyleBackColor = true;
            // 
            // playlistNameTextBox
            // 
            this.playlistNameTextBox.Location = new System.Drawing.Point(289, 49);
            this.playlistNameTextBox.Name = "playlistNameTextBox";
            this.playlistNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.playlistNameTextBox.TabIndex = 7;
            // 
            // addSongToPlaylistButton
            // 
            this.addSongToPlaylistButton.Location = new System.Drawing.Point(151, 118);
            this.addSongToPlaylistButton.Name = "addSongToPlaylistButton";
            this.addSongToPlaylistButton.Size = new System.Drawing.Size(132, 23);
            this.addSongToPlaylistButton.TabIndex = 8;
            this.addSongToPlaylistButton.Text = "Add Selected Song";
            this.addSongToPlaylistButton.UseVisualStyleBackColor = true;
            // 
            // deleteSongFromPlaylistButton
            // 
            this.deleteSongFromPlaylistButton.Location = new System.Drawing.Point(313, 118);
            this.deleteSongFromPlaylistButton.Name = "deleteSongFromPlaylistButton";
            this.deleteSongFromPlaylistButton.Size = new System.Drawing.Size(132, 23);
            this.deleteSongFromPlaylistButton.TabIndex = 9;
            this.deleteSongFromPlaylistButton.Text = "Delete Selected Song";
            this.deleteSongFromPlaylistButton.UseVisualStyleBackColor = true;
            // 
            // PlaylistsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 571);
            this.Controls.Add(this.deleteSongFromPlaylistButton);
            this.Controls.Add(this.addSongToPlaylistButton);
            this.Controls.Add(this.playlistNameTextBox);
            this.Controls.Add(this.deletePlaylistButton);
            this.Controls.Add(this.addPlaylistButton);
            this.Controls.Add(this.playlistsLists);
            this.Controls.Add(this.songPlaylistList);
            this.Controls.Add(this.lyricToolbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistsWindow";
            this.Text = "PlaylistsWindow";
            this.lyricToolbarPanel.ResumeLayout(false);
            this.lyricToolbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel lyricToolbarPanel;
        private System.Windows.Forms.Label lyricTitleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox songPlaylistList;
        private System.Windows.Forms.ListBox playlistsLists;
        private System.Windows.Forms.Button addPlaylistButton;
        private System.Windows.Forms.Button deletePlaylistButton;
        private System.Windows.Forms.TextBox playlistNameTextBox;
        private System.Windows.Forms.Button addSongToPlaylistButton;
        private System.Windows.Forms.Button deleteSongFromPlaylistButton;
    }
}