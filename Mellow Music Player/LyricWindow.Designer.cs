
namespace Mellow_Music_Player
{
    partial class LyricWindow
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lyricToolbarPanel.Size = new System.Drawing.Size(529, 33);
            this.lyricToolbarPanel.TabIndex = 1;
            this.lyricToolbarPanel.TopColor = System.Drawing.Color.Aqua;
            this.lyricToolbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lyricToolbarPanel_MouseDown);
            this.lyricToolbarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lyricToolbarPanel_MouseMove);
            // 
            // lyricTitleLabel
            // 
            this.lyricTitleLabel.AutoSize = true;
            this.lyricTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lyricTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lyricTitleLabel.Location = new System.Drawing.Point(240, 8);
            this.lyricTitleLabel.Name = "lyricTitleLabel";
            this.lyricTitleLabel.Size = new System.Drawing.Size(39, 18);
            this.lyricTitleLabel.TabIndex = 7;
            this.lyricTitleLabel.Text = "Lyrics";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(484, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 33);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(529, 511);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sample";
            // 
            // LyricWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lyricToolbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LyricWindow";
            this.Text = "LyricWindow";
            this.lyricToolbarPanel.ResumeLayout(false);
            this.lyricToolbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GradientPanel lyricToolbarPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label lyricTitleLabel;
    }
}