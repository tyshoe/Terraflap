//ideas
//increase difficulty with playtime?
//add more sounds for death and flap
//add currency/store
//add options menu for cosmetics

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


        private Point title_pos = new Point(213, 92);
        private Point guide_pos = new Point(486, 283);//window size/2 - ground size
        private Point start_pos = new Point(320, 500);
        private Point ground_pos = new Point(0, 664);
        private Point game_over_pos = new Point(320, 150);
        private Point high_score_pos = new Point(310, 412);

        private Point TWOF_pos_1 = new Point(1050, -780);
        private Point TWOF_pos_2 = new Point(1050, -660);
        private Point TWOF_pos_3 = new Point(1050, -540);
        private Point TWOF_pos_4 = new Point(1050, -420);

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

        private void gameTimerEvent(object sender, EventArgs e)
        {
            guide_pic.Top += _gravity;
            Bottom_WOF.Left -= _pipeSpeed;
            Top_WOF.Left -= _pipeSpeed;
            score_lbl.Text = _score.ToString();

            //if left side WOF hits coor 240, add point
            if (Bottom_WOF.Left == 360 || Top_WOF.Left == 360)
            {
                _score++;
                Gain_point();
                Set_HighScore();
            }

            //when wof goes off screen, respawn wof on right
            if (Bottom_WOF.Left < -150 || Top_WOF.Left < -150)
            {
                WOF_spawn();
            }

            //if guide hits wof/ground
            if (guide_pic.Bounds.IntersectsWith(Bottom_WOF.Bounds) || guide_pic.Bounds.IntersectsWith(Top_WOF.Bounds) || guide_pic.Bounds.IntersectsWith(Ground_pic.Bounds))
            {
                Game_over();
                death_timer.Start();
                

            }

        }

        //method to set sound to play the point gain sound
        private void Gain_point() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.point); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void WOF_spawn()
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


        private void Start_game()
        {
            _pipeSpeed = 5;
            _gravity = 3;
            game_timer.Start();
            Game_over_img.Hide();
            HighScore_lbl.Hide();
            WOF_spawn();
        }

        private void Game_over()
        {
            game_timer.Stop();//stops game

            Get_HighScore();

            Game_over_img.Location = game_over_pos;

            Game_over_img.Show();
            HighScore_lbl.Show();
            Start_button.Show();
            
        }

        private void Title_screen()
        {
            Start_conditions();

            Game_over_img.Hide();
            HighScore_lbl.Hide();
        }
         
        private void Start_button_Click(object sender, EventArgs e)
        {
            Start_conditions();
            Start_button.Hide();
            Game_Title.Hide();
            Start_game();
        }
        private void Start_conditions()
        {
            Game_Title.Location = title_pos;
            guide_pic.Location = guide_pos;
            Start_button.Location = start_pos;
            Ground_pic.Location = ground_pos;
            HighScore_lbl.Location = high_score_pos;
            _score = 0;
        }

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
            HighScore_lbl.Text = "HighScore: " + Convert.ToString(_HighScore);
            
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

        private void death_timer_Tick(object sender, EventArgs e)
        {
            guide_pic.Top += 5;
            if (guide_pic.Top >= 600)
            {

                death_timer.Stop();

            }
        }
    }
}
