
namespace Mellow_Music_Player
{
    partial class SongInfoSearch
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
            this.infoToolbarPanel = new Mellow_Music_Player.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.gradientPanel1 = new Mellow_Music_Player.GradientPanel();
            this.downloadLyricsButton = new System.Windows.Forms.Button();
            this.downloadInfoButton = new System.Windows.Forms.Button();
            this.albumLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infoToolbarPanel.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoToolbarPanel
            // 
            this.infoToolbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoToolbarPanel.BottomColor = System.Drawing.Color.SkyBlue;
            this.infoToolbarPanel.Controls.Add(this.label3);
            this.infoToolbarPanel.Controls.Add(this.closeButton);
            this.infoToolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.infoToolbarPanel.Name = "infoToolbarPanel";
            this.infoToolbarPanel.Size = new System.Drawing.Size(870, 33);
            this.infoToolbarPanel.TabIndex = 2;
            this.infoToolbarPanel.TopColor = System.Drawing.Color.Aqua;
            this.infoToolbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.infoToolbarPanel_MouseDown);
            this.infoToolbarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.infoToolbarPanel_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(387, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Info Downloader";
            this.label3.BackColor = System.Drawing.Color.Transparent;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(825, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 33);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.BottomColor = System.Drawing.Color.SkyBlue;
            this.gradientPanel1.Controls.Add(this.downloadLyricsButton);
            this.gradientPanel1.Controls.Add(this.downloadInfoButton);
            this.gradientPanel1.Controls.Add(this.albumLabel);
            this.gradientPanel1.Controls.Add(this.yearLabel);
            this.gradientPanel1.Controls.Add(this.genreLabel);
            this.gradientPanel1.Controls.Add(this.artistLabel);
            this.gradientPanel1.Controls.Add(this.titleLabel);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(435, 170);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(435, 470);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.Color.Aqua;
            // 
            // downloadLyricsButton
            // 
            this.downloadLyricsButton.Location = new System.Drawing.Point(218, 385);
            this.downloadLyricsButton.Name = "downloadLyricsButton";
            this.downloadLyricsButton.Size = new System.Drawing.Size(217, 85);
            this.downloadLyricsButton.TabIndex = 34;
            this.downloadLyricsButton.Text = "Download Lyrics";
            this.downloadLyricsButton.UseVisualStyleBackColor = true;
            // 
            // downloadInfoButton
            // 
            this.downloadInfoButton.Location = new System.Drawing.Point(0, 385);
            this.downloadInfoButton.Name = "downloadInfoButton";
            this.downloadInfoButton.Size = new System.Drawing.Size(217, 85);
            this.downloadInfoButton.TabIndex = 33;
            this.downloadInfoButton.Text = "Download Song Info";
            this.downloadInfoButton.UseVisualStyleBackColor = true;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(214, 286);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(46, 15);
            this.albumLabel.TabIndex = 32;
            this.albumLabel.Text = "Sample";
            this.albumLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(214, 311);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(46, 15);
            this.yearLabel.TabIndex = 31;
            this.yearLabel.Text = "Sample";
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(214, 336);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(46, 15);
            this.genreLabel.TabIndex = 30;
            this.genreLabel.Text = "Sample";
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(214, 262);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(46, 15);
            this.artistLabel.TabIndex = 29;
            this.artistLabel.Text = "Sample";
            this.albumLabel.BackColor = System.Drawing.Color.Transparent;
            this.artistLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(214, 236);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 15);
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Sample";
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(434, 469);
            this.listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(522, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artist:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Song name:";
            // 
            // SongInfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.infoToolbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SongInfoSearch";
            this.Text = "SongInfoSearch";
            this.infoToolbarPanel.ResumeLayout(false);
            this.infoToolbarPanel.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel infoToolbarPanel;
        private System.Windows.Forms.Button closeButton;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button downloadLyricsButton;
        private System.Windows.Forms.Button downloadInfoButton;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}