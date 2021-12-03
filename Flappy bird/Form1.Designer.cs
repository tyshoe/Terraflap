
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
            this.bird_pic = new System.Windows.Forms.PictureBox();
            this.Top_pipe_pic = new System.Windows.Forms.PictureBox();
            this.Bot_pipe_pic = new System.Windows.Forms.PictureBox();
            this.Ground_pic = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_pipe_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot_pipe_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // bird_pic
            // 
            this.bird_pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bird_pic.BackColor = System.Drawing.Color.Transparent;
            this.bird_pic.Image = global::Flappy_bird.Properties.Resources.bird;
            this.bird_pic.Location = new System.Drawing.Point(282, 262);
            this.bird_pic.Margin = new System.Windows.Forms.Padding(1);
            this.bird_pic.Name = "bird_pic";
            this.bird_pic.Size = new System.Drawing.Size(80, 60);
            this.bird_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bird_pic.TabIndex = 0;
            this.bird_pic.TabStop = false;
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
            // game_timer
            // 
            this.game_timer.Enabled = true;
            this.game_timer.Interval = 20;
            this.game_timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(682, 674);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.Ground_pic);
            this.Controls.Add(this.Bot_pipe_pic);
            this.Controls.Add(this.Top_pipe_pic);
            this.Controls.Add(this.bird_pic);
            this.Name = "Game_Form";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bird_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_pipe_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot_pipe_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).EndInit();
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
    }
}

