
namespace Flappy_bird
{
    partial class Game_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Form));
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.Leaderboards_button = new System.Windows.Forms.PictureBox();
            this.Start_button = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.Ground_pic = new System.Windows.Forms.PictureBox();
            this.Bot_pipe_pic = new System.Windows.Forms.PictureBox();
            this.Top_pipe_pic = new System.Windows.Forms.PictureBox();
            this.bird_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Leaderboards_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot_pipe_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_pipe_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // game_timer
            // 
            this.game_timer.Interval = 20;
            this.game_timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Leaderboards_button
            // 
            this.Leaderboards_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Leaderboards_button.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboards_button.Image = ((System.Drawing.Image)(resources.GetObject("Leaderboards_button.Image")));
            this.Leaderboards_button.Location = new System.Drawing.Point(342, 423);
            this.Leaderboards_button.Margin = new System.Windows.Forms.Padding(1);
            this.Leaderboards_button.Name = "Leaderboards_button";
            this.Leaderboards_button.Size = new System.Drawing.Size(218, 89);
            this.Leaderboards_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Leaderboards_button.TabIndex = 6;
            this.Leaderboards_button.TabStop = false;
            // 
            // Start_button
            // 
            this.Start_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start_button.BackColor = System.Drawing.Color.Transparent;
            this.Start_button.Image = ((System.Drawing.Image)(resources.GetObject("Start_button.Image")));
            this.Start_button.Location = new System.Drawing.Point(47, 423);
            this.Start_button.Margin = new System.Windows.Forms.Padding(1);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(218, 89);
            this.Start_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start_button.TabIndex = 5;
            this.Start_button.TabStop = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.Transparent;
            this.score_lbl.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.ForeColor = System.Drawing.Color.Black;
            this.score_lbl.Image = global::Flappy_bird.Properties.Resources.ground;
            this.score_lbl.Location = new System.Drawing.Point(310, 605);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(52, 60);
            this.score_lbl.TabIndex = 4;
            this.score_lbl.Text = "0";
            // 
            // Ground_pic
            // 
            this.Ground_pic.Image = global::Flappy_bird.Properties.Resources.ground;
            this.Ground_pic.Location = new System.Drawing.Point(0, 582);
            this.Ground_pic.Name = "Ground_pic";
            this.Ground_pic.Size = new System.Drawing.Size(682, 92);
            this.Ground_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground_pic.TabIndex = 3;
            this.Ground_pic.TabStop = false;
            // 
            // Bot_pipe_pic
            // 
            this.Bot_pipe_pic.Image = global::Flappy_bird.Properties.Resources.pipe;
            this.Bot_pipe_pic.Location = new System.Drawing.Point(582, 359);
            this.Bot_pipe_pic.Name = "Bot_pipe_pic";
            this.Bot_pipe_pic.Size = new System.Drawing.Size(100, 226);
            this.Bot_pipe_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bot_pipe_pic.TabIndex = 2;
            this.Bot_pipe_pic.TabStop = false;
            // 
            // Top_pipe_pic
            // 
            this.Top_pipe_pic.BackColor = System.Drawing.Color.Transparent;
            this.Top_pipe_pic.Image = global::Flappy_bird.Properties.Resources.pipedown;
            this.Top_pipe_pic.Location = new System.Drawing.Point(582, 0);
            this.Top_pipe_pic.Name = "Top_pipe_pic";
            this.Top_pipe_pic.Size = new System.Drawing.Size(100, 218);
            this.Top_pipe_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top_pipe_pic.TabIndex = 1;
            this.Top_pipe_pic.TabStop = false;
            // 
            // bird_pic
            // 
            this.bird_pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bird_pic.BackColor = System.Drawing.Color.Transparent;
            this.bird_pic.Image = global::Flappy_bird.Properties.Resources.guide;
            this.bird_pic.Location = new System.Drawing.Point(310, 241);
            this.bird_pic.Margin = new System.Windows.Forms.Padding(1);
            this.bird_pic.Name = "bird_pic";
            this.bird_pic.Size = new System.Drawing.Size(64, 64);
            this.bird_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bird_pic.TabIndex = 0;
            this.bird_pic.TabStop = false;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(682, 674);
            this.Controls.Add(this.Leaderboards_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.Ground_pic);
            this.Controls.Add(this.Bot_pipe_pic);
            this.Controls.Add(this.Top_pipe_pic);
            this.Controls.Add(this.bird_pic);
            this.Name = "Game_Form";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Leaderboards_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot_pipe_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_pipe_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird_pic;
        private System.Windows.Forms.PictureBox Top_pipe_pic;
        private System.Windows.Forms.PictureBox Bot_pipe_pic;
        private System.Windows.Forms.PictureBox Ground_pic;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.PictureBox Start_button;
        private System.Windows.Forms.PictureBox Leaderboards_button;
    }
}

