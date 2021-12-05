﻿//ideas
//increase difficulty with playtime?
//add more sounds for death and flap
//add currency/store
//add options menu for cosmetics
//TODO: add sounds - finish highscore/score UI - create title 

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Flappy_bird
{
    public partial class Game_Form : Form
    {
        private int _pipeSpeed;
        private int _gravity;
        private int _score = 0;
        private int _HighScore;


        //title, character, ground
        private Point title_pos = new Point(213, 92);
        private Point guide_pos = new Point(486, 283);
        private Point ground_pos = new Point(0, 664);

        //buttons
        private Point game_over_pos = new Point(320, 75);
        private Point score_pic_pos = new Point(320, 225);
        private Point score_txt_pos = new Point(584, 235);
        private Point high_score_pic_pos = new Point(284, 375);
        private Point high_score_txt_pos = new Point(622, 385);
        private Point start_pos = new Point(320, 525);

        //top wall of flesh points
        private Point TWOF_pos_1 = new Point(1050, -780);
        private Point TWOF_pos_2 = new Point(1050, -660);
        private Point TWOF_pos_3 = new Point(1050, -540);
        private Point TWOF_pos_4 = new Point(1050, -420);
        //bottom wall of flesh points
        private Point BWOF_pos_1 = new Point(1050, 252);
        private Point BWOF_pos_2 = new Point(1050, 372);
        private Point BWOF_pos_3 = new Point(1050, 492);
        private Point BWOF_pos_4 = new Point(1050, 612);

        public Game_Form()
        {
            InitializeComponent();
            Title_screen();
            Get_HighScore();

        }
        //key events(spacebar + left mouse )
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = -4;
            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = 3;
            }
        }

        private void Left_mouse_down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _gravity = -4;
            }

        }
        private void Left_mouse_up(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _gravity = 3;
            }
        }




        //timers(game_timer + death_timer)
        private void gameTimerEvent(object sender, EventArgs e)
        {
            guide_pic.Top += _gravity;
            Bottom_WOF.Left -= _pipeSpeed;
            Top_WOF.Left -= _pipeSpeed;
            score_lbl.Text = _score.ToString();

            //if left side WOF hits coor 360, add point
            if (Bottom_WOF.Left == 360 || Top_WOF.Left == 360)
            {
                _score++;
                Gain_point();
                Set_HighScore();
            }

            //when wof goes off screen, respawn wof on right
            if (Bottom_WOF.Left < -150 || Top_WOF.Left < -150)
            {
                Spawn_WOF();
            }

            //if guide hits wof/ground
            if (guide_pic.Bounds.IntersectsWith(Bottom_WOF.Bounds) || guide_pic.Bounds.IntersectsWith(Top_WOF.Bounds) || guide_pic.Bounds.IntersectsWith(Ground_pic.Bounds))
            {
                Game_over();
                death_timer.Start();
            }

        }
        private void death_timer_Tick(object sender, EventArgs e)
        {
            guide_pic.Top += 5;
            if (guide_pic.Top >= 600)
            {

                death_timer.Stop();

            }
        }




        //events
        private void Start_button_Click(object sender, EventArgs e)
        {
            Set_pic_positions();
            Hide_start_menu();
            Hide_end_menu();
            Start_game();
        }




        //methods
        private void Title_screen()
        {
            Set_pic_positions();
            Show_start_menu();
        }
        private void Set_pic_positions()
        {
            //start screen excluding start button
            Game_Title.Location = title_pos;
            guide_pic.Location = guide_pos;
            Ground_pic.Location = ground_pos;

            
            //game over screen
            Game_over_img.Location = game_over_pos;
            score.Location = score_pic_pos;
            score_lbl.Location = score_txt_pos;
            hi_score.Location = high_score_pic_pos;
            HighScore_lbl.Location = high_score_txt_pos;
            Start_button.Location = start_pos;


            _score = 0;

        }

        //spawn location options
        private void Spawn_WOF()
        {
            Random random = new Random();
            int number = random.Next(1,5);

            if (number == 1)
            {
                Top_WOF.Location = TWOF_pos_1;
                Bottom_WOF.Location = BWOF_pos_1;

            }
            if (number == 2)
            {
                Top_WOF.Location = TWOF_pos_2;
                Bottom_WOF.Location = BWOF_pos_2;
            }
            if (number == 3)
            {
                Top_WOF.Location = TWOF_pos_3;
                Bottom_WOF.Location = BWOF_pos_3;
            }
            if (number == 4)
            {
                Top_WOF.Location = TWOF_pos_4;
                Bottom_WOF.Location = BWOF_pos_4;
            }
        }


        //start + end game
        private void Start_game()
        {
            _pipeSpeed = 5;
            _gravity = 3;
            game_timer.Start();
            Spawn_WOF();
        }
        private void Game_over()
        {
            game_timer.Stop();//stops game

            Get_HighScore();

            Show_end_menu();
        }


        //start menu
        private void Show_start_menu()
        {
            Game_Title.Show();
            Start_button.Show();

            Game_over_img.Hide();
            score.Hide();
            score_lbl.Hide();
            hi_score.Hide();
            HighScore_lbl.Hide();
        }
        private void Hide_start_menu()
        {
            Game_Title.Hide();
            Start_button.Hide();

            Game_over_img.Hide();
            score.Hide();
            score_lbl.Hide();
            hi_score.Hide();
            HighScore_lbl.Hide();
        }

        //end menu
        private void Show_end_menu()
        {
            Game_over_img.Show();
            score_lbl.Show();
            score.Show();
            HighScore_lbl.Show();
            hi_score.Show();
            Start_button.Show();
        }
        private void Hide_end_menu()
        {
            Game_over_img.Hide();
            score.Hide();
            score_lbl.Hide();
            hi_score.Hide();
            HighScore_lbl.Hide();
        }


        //HighScores
        private void Set_HighScore()
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Resources/HighScores.txt");
            StreamWriter writer = new StreamWriter(filePath, false);
            if (_score > _HighScore)
            {
                writer.Write(_score);
                writer.Close();
            }
            else
            {
                writer.Write(_HighScore);
                writer.Close();
            }
        }
        private void Get_HighScore()
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Resources/HighScores.txt");
            StreamReader current_high = new StreamReader(filePath, false);
            _HighScore = Convert.ToInt32(current_high.ReadLine());
            current_high.Close();
            HighScore_lbl.Text = Convert.ToString(_HighScore);
        }


        //sounds
        private void Gain_point()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.point);
            audio.Play();
        }

    }
}
