
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
            this.Game_Title = new System.Windows.Forms.PictureBox();
            this.Start_button = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.Ground_pic = new System.Windows.Forms.PictureBox();
            this.Bottom_WOF = new System.Windows.Forms.PictureBox();
            this.Top_WOF = new System.Windows.Forms.PictureBox();
            this.guide_pic = new System.Windows.Forms.PictureBox();
            this.Game_over_img = new System.Windows.Forms.PictureBox();
            this.HighScore_lbl = new System.Windows.Forms.Label();
            this.Background_img = new System.Windows.Forms.PictureBox();
            this.death_timer = new System.Windows.Forms.Timer(this.components);
            this.hi_score = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom_WOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_WOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guide_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_over_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hi_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            this.SuspendLayout();
            // 
            // game_timer
            // 
            this.game_timer.Interval = 15;
            this.game_timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Game_Title
            // 
            this.Game_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Game_Title.BackColor = System.Drawing.Color.Transparent;
            this.Game_Title.Image = ((System.Drawing.Image)(resources.GetObject("Game_Title.Image")));
            this.Game_Title.Location = new System.Drawing.Point(248, 100);
            this.Game_Title.Margin = new System.Windows.Forms.Padding(1);
            this.Game_Title.Name = "Game_Title";
            this.Game_Title.Size = new System.Drawing.Size(528, 150);
            this.Game_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Game_Title.TabIndex = 7;
            this.Game_Title.TabStop = false;
            // 
            // Start_button
            // 
            this.Start_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Start_button.BackColor = System.Drawing.Color.Transparent;
            this.Start_button.Image = global::Flappy_bird.Properties.Resources.start_button;
            this.Start_button.Location = new System.Drawing.Point(320, 537);
            this.Start_button.Margin = new System.Windows.Forms.Padding(1);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(384, 88);
            this.Start_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start_button.TabIndex = 5;
            this.Start_button.TabStop = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(188)))), ((int)(((byte)(243)))));
            this.score_lbl.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.ForeColor = System.Drawing.Color.Black;
            this.score_lbl.Location = new System.Drawing.Point(584, 260);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(51, 60);
            this.score_lbl.TabIndex = 4;
            this.score_lbl.Text = "0";
            this.score_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Ground_pic
            // 
            this.Ground_pic.BackColor = System.Drawing.Color.Transparent;
            this.Ground_pic.Image = ((System.Drawing.Image)(resources.GetObject("Ground_pic.Image")));
            this.Ground_pic.Location = new System.Drawing.Point(0, 664);
            this.Ground_pic.Name = "Ground_pic";
            this.Ground_pic.Size = new System.Drawing.Size(1024, 136);
            this.Ground_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ground_pic.TabIndex = 3;
            this.Ground_pic.TabStop = false;
            // 
            // Bottom_WOF
            // 
            this.Bottom_WOF.BackColor = System.Drawing.Color.Transparent;
            this.Bottom_WOF.Image = global::Flappy_bird.Properties.Resources.waf;
            this.Bottom_WOF.Location = new System.Drawing.Point(858, 463);
            this.Bottom_WOF.Name = "Bottom_WOF";
            this.Bottom_WOF.Size = new System.Drawing.Size(148, 840);
            this.Bottom_WOF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bottom_WOF.TabIndex = 2;
            this.Bottom_WOF.TabStop = false;
            this.Bottom_WOF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.Bottom_WOF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // Top_WOF
            // 
            this.Top_WOF.BackColor = System.Drawing.Color.Transparent;
            this.Top_WOF.Image = global::Flappy_bird.Properties.Resources.waf;
            this.Top_WOF.Location = new System.Drawing.Point(858, -638);
            this.Top_WOF.Name = "Top_WOF";
            this.Top_WOF.Size = new System.Drawing.Size(148, 840);
            this.Top_WOF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Top_WOF.TabIndex = 1;
            this.Top_WOF.TabStop = false;
            this.Top_WOF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.Top_WOF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // guide_pic
            // 
            this.guide_pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guide_pic.BackColor = System.Drawing.Color.Transparent;
            this.guide_pic.Image = ((System.Drawing.Image)(resources.GetObject("guide_pic.Image")));
            this.guide_pic.Location = new System.Drawing.Point(473, 303);
            this.guide_pic.Margin = new System.Windows.Forms.Padding(1);
            this.guide_pic.Name = "guide_pic";
            this.guide_pic.Size = new System.Drawing.Size(52, 64);
            this.guide_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guide_pic.TabIndex = 0;
            this.guide_pic.TabStop = false;
            this.guide_pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.guide_pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // Game_over_img
            // 
            this.Game_over_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Game_over_img.BackColor = System.Drawing.Color.Transparent;
            this.Game_over_img.Image = global::Flappy_bird.Properties.Resources.game_over;
            this.Game_over_img.Location = new System.Drawing.Point(320, 100);
            this.Game_over_img.Margin = new System.Windows.Forms.Padding(1);
            this.Game_over_img.Name = "Game_over_img";
            this.Game_over_img.Size = new System.Drawing.Size(384, 88);
            this.Game_over_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Game_over_img.TabIndex = 3;
            this.Game_over_img.TabStop = false;
            // 
            // HighScore_lbl
            // 
            this.HighScore_lbl.AutoSize = true;
            this.HighScore_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.HighScore_lbl.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HighScore_lbl.Location = new System.Drawing.Point(622, 410);
            this.HighScore_lbl.Name = "HighScore_lbl";
            this.HighScore_lbl.Size = new System.Drawing.Size(103, 60);
            this.HighScore_lbl.TabIndex = 1;
            this.HighScore_lbl.Text = "999";
            this.HighScore_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Background_img
            // 
            this.Background_img.Image = global::Flappy_bird.Properties.Resources.Forest_background;
            this.Background_img.Location = new System.Drawing.Point(0, 0);
            this.Background_img.Name = "Background_img";
            this.Background_img.Size = new System.Drawing.Size(1024, 838);
            this.Background_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Background_img.TabIndex = 8;
            this.Background_img.TabStop = false;
            this.Background_img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.Background_img.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // death_timer
            // 
            this.death_timer.Interval = 10;
            this.death_timer.Tick += new System.EventHandler(this.death_timer_Tick);
            // 
            // hi_score
            // 
            this.hi_score.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hi_score.BackColor = System.Drawing.Color.Transparent;
            this.hi_score.Image = global::Flappy_bird.Properties.Resources.hi_score;
            this.hi_score.Location = new System.Drawing.Point(297, 400);
            this.hi_score.Margin = new System.Windows.Forms.Padding(1);
            this.hi_score.Name = "hi_score";
            this.hi_score.Size = new System.Drawing.Size(457, 88);
            this.hi_score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hi_score.TabIndex = 9;
            this.hi_score.TabStop = false;
            // 
            // score
            // 
            this.score.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Image = global::Flappy_bird.Properties.Resources.score;
            this.score.Location = new System.Drawing.Point(320, 250);
            this.score.Margin = new System.Windows.Forms.Padding(1);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(384, 88);
            this.score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.score.TabIndex = 10;
            this.score.TabStop = false;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources.Forest_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 799);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.HighScore_lbl);
            this.Controls.Add(this.score);
            this.Controls.Add(this.hi_score);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Game_over_img);
            this.Controls.Add(this.guide_pic);
            this.Controls.Add(this.Game_Title);
            this.Controls.Add(this.Ground_pic);
            this.Controls.Add(this.Bottom_WOF);
            this.Controls.Add(this.Top_WOF);
            this.Controls.Add(this.Background_img);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerraFlap";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Game_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom_WOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_WOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guide_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_over_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hi_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox guide_pic;
        private System.Windows.Forms.PictureBox Top_WOF;
        private System.Windows.Forms.PictureBox Bottom_WOF;
        private System.Windows.Forms.PictureBox Ground_pic;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.PictureBox Start_button;
        private System.Windows.Forms.PictureBox Game_Title;
        private System.Windows.Forms.Label HighScore_lbl;
        private System.Windows.Forms.PictureBox Game_over_img;
        private System.Windows.Forms.PictureBox Background_img;
        private System.Windows.Forms.Timer death_timer;
        private System.Windows.Forms.PictureBox hi_score;
        private System.Windows.Forms.PictureBox score;
    }
}

