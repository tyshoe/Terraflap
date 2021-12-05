//ideas
//add highscore with text file
//add leaderboards screen
//add different modes
//increase difficulty with playtime?
//difficulty settings
//add more sounds for death and flap
//start menu

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


        private Point start_menu_title = new Point(213, 92);
        private Point start_menu_guide = new Point(486, 283);//window size/2 - ground size
        private Point start_menu_start = new Point(320, 500);
        private Point ground = new Point(0, 664);
        private Point game_over = new Point(320, 150);

        public Game_Form()
        {
            InitializeComponent();
            Title_screen();
            Get_HighScore();

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            guide_pic.Top += _gravity;
            Bottom_WAF.Left -= _pipeSpeed;
            Top_WAF.Left -= _pipeSpeed;
            score_lbl.Text = _score.ToString();

            //if left side pipe hits coor 240, add point
            if (Bottom_WAF.Left == 240 || Top_WAF.Left == 240)
            {
                _score++;
                gain_point();
                Set_HighScore();
            }

            //when pipe goes off screen, change pipe to start over again
            if (Bottom_WAF.Left < -100 || Top_WAF.Left < -100)
            {
                pipe_location();
            }

            //if guide hits pipe/ground
            if (guide_pic.Bounds.IntersectsWith(Bottom_WAF.Bounds) || guide_pic.Bounds.IntersectsWith(Top_WAF.Bounds) || guide_pic.Bounds.IntersectsWith(Ground_pic.Bounds))
            {
                Game_over();
            }

        }

        //method to set sound to play the point gain sound
        private void gain_point() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.point); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void pipe_location()
        {
            Random random = new Random();
            int number = random.Next(1,4);

            if (number == 1)//top location
            {
                Top_WAF.Top = -800;
                Top_WAF.Left = 1100;


                Bottom_WAF.Top = 250;
                Bottom_WAF.Left = 1100;

            }
            if (number == 2)//middle location
            {
                Top_WAF.Top = 0;
                Top_WAF.Left = 1100;

                Bottom_WAF.Top = 375;
                Bottom_WAF.Left = 1100;

            }
            if (number == 3)//bottom location
            {
                Top_WAF.Top = 0;
                Top_WAF.Left = 1100;

                Bottom_WAF.Top = 500;
                Bottom_WAF.Left = 1100;
            }
            if (number == 4)
            {
                Top_WAF.Top = 0;
                Top_WAF.Left = 1100;

                Bottom_WAF.Top = 500;
                Bottom_WAF.Left = 1100;
            }
            if (number == 5)
            {
                Top_WAF.Top = 0;
                Top_WAF.Left = 1100;

                Bottom_WAF.Top = 500;
                Bottom_WAF.Left = 1100;
            }
            if (number == 6)
            {
                Top_WAF.Top = 0;
                Top_WAF.Left = 1100;

                Bottom_WAF.Top = 500;
                Bottom_WAF.Left = 1100;
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

        private void reset_game()
        {
            _score = 0;
            Bottom_WAF.Left = 1100;
            Top_WAF.Left = 1100;
            guide_pic.Location = start_menu_guide;
            _pipeSpeed = 0;
            _gravity = 0;
        }

        private void start_game()
        {
            _pipeSpeed = 5;
            _gravity = 3;
            game_timer.Start();
            Game_over_img.Hide();
            HighScore_lbl.Hide();
        }

        private void Game_over()
        {
            game_timer.Stop();//stops game
            Get_HighScore();
            Game_over_img.Location = game_over;
            Game_over_img.Show();
            HighScore_lbl.Show();
            Start_button.Show();
            
        }

        private void Title_screen()
        {
            Game_Title.Location = start_menu_title;
            guide_pic.Location = start_menu_guide;
            Start_button.Location = start_menu_start;
            Bottom_WAF.Left = 1100;
            Top_WAF.Left = 1100;
            Game_over_img.Hide();
            HighScore_lbl.Hide();
            Ground_pic.Location = ground;
        }
         
        private void Start_button_Click(object sender, EventArgs e)
        {
            reset_game();
            Start_button.Hide();
            Game_Title.Hide();
            start_game();
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
                _gravity = 4;
            }
        }
    }
}
