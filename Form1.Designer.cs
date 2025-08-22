namespace PortfolioTask1
{
    partial class PotatoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotatoPlayer));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Title = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.SelectFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(11, 62);
            this.MediaPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(960, 540);
            this.MediaPlayer.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Title.Location = new System.Drawing.Point(11, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(524, 37);
            this.Title.TabIndex = 1;
            this.Title.Text = "My Windows Media Player Wrapper";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(764, 20);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(67, 26);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(835, 20);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(67, 26);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(906, 20);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(67, 26);
            this.SelectFileButton.TabIndex = 4;
            this.SelectFileButton.Text = "Open File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // PotatoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MediaPlayer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PotatoPlayer";
            this.Text = "Potato Player: Boil em Mash em Stick em in a Stew";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button SelectFileButton;
    }
}

