//ideas
//add highscore with text file
//add leaderboards screen
//add different modes
//increase difficulty with playtime?
//difficulty settings
//add more sounds for death and flap
//start menu

using System;
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
        private int _pipeSpeed = 10;
        private int _gravity = 8;
        private int _score = 0;


        public Game_Form()
        {
            InitializeComponent();
            Bot_pipe_pic.Left = 700;
            Top_pipe_pic.Left = 700;

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird_pic.Top += _gravity;
            Bot_pipe_pic.Left -= _pipeSpeed;
            Top_pipe_pic.Left -= _pipeSpeed;
            score_lbl.Text = _score.ToString();

            
            //if left side pipe hits coor 240, add point
            if (Bot_pipe_pic.Left == 240 || Top_pipe_pic.Left == 240)
            {
                _score++;
                gain_point();
            }



            //when pipe goes off screen, change pipe to start over again
            if (Bot_pipe_pic.Left < -100 || Top_pipe_pic.Left < -100)
            {
                pipe_location();
            }



            //if bird hits pipes or ground
            if (bird_pic.Bounds.IntersectsWith(Bot_pipe_pic.Bounds) || bird_pic.Bounds.IntersectsWith(Top_pipe_pic.Bounds) || bird_pic.Bounds.IntersectsWith(Ground_pic.Bounds))
            {
                _ = endGameAsync();
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
            System.Random random = new System.Random();
            int number = random.Next(1,4);

            if (number == 1)//top location
            {
                Top_pipe_pic.Top = -125;
                Top_pipe_pic.Left = 700;
                Top_pipe_pic.Height = 218;


                Bot_pipe_pic.Top = 250;
                Bot_pipe_pic.Left = 700;
                Bot_pipe_pic.Height = 351;

            }
            if (number == 2)//middle location
            {
                Top_pipe_pic.Top = 0;
                Top_pipe_pic.Left = 700;
                Top_pipe_pic.Height = 218;

                Bot_pipe_pic.Top = 375;
                Bot_pipe_pic.Left = 700;
                Bot_pipe_pic.Height = 226;

            }
            if (number == 3)//bottom location
            {
                Top_pipe_pic.Top = 0;
                Top_pipe_pic.Left = 700;
                Top_pipe_pic.Height = 343;

                Bot_pipe_pic.Top = 500;
                Bot_pipe_pic.Left = 700;
                Bot_pipe_pic.Height = 226;
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = 8;
            }
        }

        private void reset_game()
        {
            _score = 0;
            Bot_pipe_pic.Left = 700;
            Top_pipe_pic.Left = 700;
            bird_pic.Location = new Point(268, 268);
            _pipeSpeed = 0;
            _gravity = 0;

        }

        private void start_game()
        {
            _pipeSpeed = 10;
            _gravity = 5;
            game_timer.Start();
        }

        private async Task endGameAsync()
        {
            game_timer.Stop();//stops game

            //message box
            DialogResult d;
            d = MessageBox.Show("Play Again?", "Game Over!", MessageBoxButtons.YesNo);

            if (d == DialogResult.No)//if they want to close game
            {
                Close();
            }
            if (d == DialogResult.Yes)//if they want to continue
            {
                reset_game();
                await Task.Delay(750);
                start_game();
                 
            }
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            Start_button.Hide();
            Leaderboards_button.Hide();
            start_game();
        }
    }
}
