using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace AnimatedGame
{
    public partial class TwoPlayerScreen : UserControl
    {
        #region gobal variables 
        //Class and object setup
        SolidBrush brushBullet = new SolidBrush(Color.Black);
        Tank playerOne;
        Tank playerTwo;
        List<Bullet> bullets = new List<Bullet>();
        SoundPlayer player = new SoundPlayer(Properties.Resources.GameOver);

        
        //Player variables
        Boolean rightKey, leftKey, downKey, upKey, shootKeyOne, wKey, aKey, sKey, dKey, shootKeyTwo;
        int playerOneScore = 0;
        int playerTwoScore = 0;
        int bulletSize = 9;
        int bulletSpeed = 18;
        int playerSize = 40;
        int playerSpeed = 8;
        Boolean playerControl = false;
        Boolean gameOn = false;


        private void TwoPlayerScreen_Load(object sender, EventArgs e)
        {
            gameOn = true;
        }


        //timer setup
        int countdown = 35;
        int timer = 3;
        #endregion

        public TwoPlayerScreen()
        {
            InitializeComponent();
            //create the players
            playerOne = new Tank(playerSpeed, 1, this.Width - this.Width/4, 0 + playerSize, playerSize, new SolidBrush(Color.Blue));
            playerTwo = new Tank(playerSpeed, 1, this.Width/4 - playerSize, this.Height - playerSize*2, playerSize, new SolidBrush(Color.Red));
        }
        #region Button Press and release
        private void TwoPlayerScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Collecting key press data
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKey = true;
                    break;
                case Keys.Right:
                    rightKey = true;
                    break;
                case Keys.Up:
                    upKey = true;
                    break;
                case Keys.Down:
                    downKey = true;
                    break;
                case Keys.Space:
                    shootKeyOne = true;
                    break;
                case Keys.Z:
                    shootKeyTwo = true;
                    break;
                case Keys.W:
                    wKey = true;
                    break;
                case Keys.A:
                    aKey = true;
                    break;
                case Keys.S:
                    sKey = true;
                    break;
                case Keys.D:
                    dKey = true;
                    break;
            }
        }
        private void TwoPlayerScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //collecting end of key press data
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKey = false;
                    break;
                case Keys.Right:
                    rightKey = false;
                    break;
                case Keys.Up:
                    upKey = false;
                    break;
                case Keys.Down:
                    downKey = false;
                    break;
                case Keys.Space:
                    shootKeyOne = false;
                    break;
                case Keys.Z:
                    shootKeyTwo = false;
                    break;
                case Keys.W:
                    wKey = false;
                    break;
                case Keys.A:
                    aKey = false;
                    break;
                case Keys.S:
                    sKey = false;
                    break;
                case Keys.D:
                    dKey = false;
                    break;
            }
        }
        #endregion

        #region game Logic
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if (gameOn)
            {


                //checking if the countdown is over
                if (playerControl)
                {
                    #region Player Logic
                    //move player 1
                    if (rightKey && upKey)
                    {
                        playerOne.Move(5);
                    }
                    else if (leftKey && upKey)
                    {
                        playerOne.Move(6);
                    }
                    else if (leftKey && downKey)
                    {
                        playerOne.Move(7);
                    }
                    else if (rightKey && downKey)
                    {
                        playerOne.Move(8);
                    }
                    else
                    {
                        if (leftKey)
                        {
                            playerOne.Move(3);
                        }
                        if (rightKey)
                        {
                            playerOne.Move(1);
                        }
                        if (upKey)
                        {
                            playerOne.Move(2);
                        }
                        if (downKey)
                        {
                            playerOne.Move(4);
                        }
                    }

                    //move player 2
                    if (dKey && wKey)
                    {
                        playerTwo.Move(5);
                    }
                    else if (aKey && wKey)
                    {
                        playerTwo.Move(6);
                    }
                    else if (aKey && sKey)
                    {
                        playerTwo.Move(7);
                    }
                    else if (dKey && sKey)
                    {
                        playerTwo.Move(8);
                    }
                    else
                    {
                        if (aKey)
                        {
                            playerTwo.Move(3);
                        }
                        if (dKey)
                        {
                            playerTwo.Move(1);
                        }
                        if (wKey)
                        {
                            playerTwo.Move(2);
                        }
                        if (sKey)
                        {
                            playerTwo.Move(4);
                        }
                    }
                    //player one shoot
                    if (playerOne.reaload == 0)
                    {
                        if (shootKeyOne)
                        {
                            //Making sure that the bullet spwans infront of the players, so they don't collide
                            switch (playerOne.dir)
                            {
                                case 1:
                                    CreateBullet(playerOne.x + playerOne.size, playerOne.y + playerOne.size / 2 - bulletSize / 2, playerOne.dir);
                                    break;
                                case 2:
                                    CreateBullet(playerOne.x + playerOne.size / 2 - bulletSize / 2, playerOne.y - bulletSize, playerOne.dir);
                                    break;
                                case 3:
                                    CreateBullet(playerOne.x - bulletSize, playerOne.y + playerOne.size / 2 - bulletSize / 2, playerOne.dir);
                                    break;
                                case 4:
                                    CreateBullet(playerOne.x + playerOne.size / 2 - bulletSize / 2, playerOne.y + playerOne.size, playerOne.dir);
                                    break;
                                case 5:
                                    CreateBullet(playerOne.x + playerOne.size, playerOne.y + bulletSize, playerOne.dir);
                                    break;
                                case 6:
                                    CreateBullet(playerOne.x - bulletSize, playerOne.y - bulletSize, playerOne.dir);
                                    break;
                                case 7:
                                    CreateBullet(playerOne.x - bulletSize, playerOne.y + playerOne.size, playerOne.dir);
                                    break;
                                case 8:
                                    CreateBullet(playerOne.x + playerOne.size, playerOne.y + playerOne.size, playerOne.dir);
                                    break;
                            }

                            playerOne.reaload = 5;
                        }


                    }
                    else playerOne.reaload--;
                    //Player Two shoot
                    if (playerTwo.reaload == 0)
                    {
                        if (shootKeyTwo)
                        {
                            switch (playerTwo.dir)
                            {
                                case 1:
                                    CreateBullet(playerTwo.x + playerTwo.size, playerTwo.y + playerTwo.size / 2 - bulletSize / 2, playerTwo.dir);
                                    break;
                                case 2:
                                    CreateBullet(playerTwo.x + playerTwo.size / 2 - bulletSize / 2, playerTwo.y - bulletSize, playerTwo.dir);
                                    break;
                                case 3:
                                    CreateBullet(playerTwo.x - bulletSize, playerTwo.y + playerTwo.size / 2 - bulletSize / 2, playerTwo.dir);
                                    break;
                                case 4:
                                    CreateBullet(playerTwo.x + playerTwo.size / 2 - bulletSize / 2, playerTwo.y + playerTwo.size, playerTwo.dir);
                                    break;
                                case 5:
                                    CreateBullet(playerTwo.x + playerTwo.size, playerTwo.y + bulletSize, playerTwo.dir);
                                    break;
                                case 6:
                                    CreateBullet(playerTwo.x - bulletSize, playerTwo.y - bulletSize, playerTwo.dir);
                                    break;
                                case 7:
                                    CreateBullet(playerTwo.x - bulletSize, playerTwo.y + playerTwo.size, playerTwo.dir);
                                    break;
                                case 8:
                                    CreateBullet(playerTwo.x + playerTwo.size, playerTwo.y + playerTwo.size, playerTwo.dir);
                                    break;
                            }

                            playerTwo.reaload = 5;
                        }


                    }
                    else playerTwo.reaload--;

                    //Collision checks
                    foreach (Bullet b in bullets)
                    {
                        if (playerOne.Collision(b, playerOne.x, playerOne.y, playerOne.size))
                        {
                            ScorePoint("PlayerTwo");
                            break;
                        }
                        if (playerTwo.Collision(b, playerTwo.x, playerTwo.y, playerTwo.size))
                        {
                            ScorePoint("PlayerOne");
                            break;
                        }
                    }
                    #endregion

                }
                else
                {
                    countdown--;
                }
                if (countdown == 0)
                {
                    //counting down the timer
                    countdown = 35;
                    timer--;
                    countdownLabel.Text = $"{timer}";
                }
                if (timer == 0)
                {
                    //Starting the game
                    playerControl = true;
                    countdownLabel.Text = "";
                }
                #region bullets and removing offscreemn players
                //remove bullets off screen
                try
                {
                    if (bullets[0].y > this.Height || bullets[0].y < 0 || bullets[0].x > this.Width || bullets[0].x < 0)
                    {
                        bullets.RemoveAt(0);
                    }


                }
                catch
                {
                    //try and catch because sometimes there are no bullets 
                }
                if (playerOne.y > this.Height || playerOne.y < 0 - playerOne.size || playerOne.x > this.Width || playerOne.x < 0 - playerOne.size)
                {
                    ScorePoint("PlayerTwo");
                }
                if (playerTwo.y > this.Height || playerTwo.y < 0 - playerTwo.size || playerTwo.x > this.Width || playerTwo.x < 0 - playerTwo.size)
                {
                    ScorePoint("PlayerOne");
                }
                foreach (Bullet b in bullets)
                {
                    //moving the bullets
                    b.Move();
                }
                #endregion

                //updating the score labels
                playerOneScoreLabel.Text = $"{playerOneScore}";
                playerTwoScoreLabel.Text = $"{playerTwoScore}";
                Refresh();
            }
        }

        public void CreateBullet(int _x, int _y, int _dir)
        {
            //create a bullet in the list
            Bullet b = new Bullet(bulletSpeed, _x, _y, bulletSize, _dir, brushBullet);
            bullets.Add(b);
        }

        public void ScorePoint (string _player)
        {
            //resesting player position
            playerOne.x = this.Width - this.Width / 4;
            playerOne.y = 0 + playerSize;
            playerTwo.x = this.Width / 4 - playerSize;
            playerTwo.y = this.Height - playerSize*2;
            countdownLabel.Text = "3";
            timer = 3;
            playerControl = false;

            //checking who scored
            if (_player == "PlayerTwo")
            {
                playerTwoScore++;
            }
            if (_player == "PlayerOne")
            {
                playerOneScore++;
            }

            //checking if someone won the game
            if (playerOneScore == 3)
            {

                    Form1.PlayerOneWins++;
                    playerTwoScore = 0;
                    playerOneScore = 0;
                    gameOn = false;
                    Form1.Winner = "One";
                    player.Play();

                    Form f = this.FindForm();

                    f.Controls.Remove(this);

                    GameOverScreen gos = new GameOverScreen();

                    f.Controls.Add(gos);
                    

                
            }
            if (playerTwoScore == 3)
            {

                
                    Form1.PlayerTwoWins++;
                    playerTwoScore = 0;
                    playerOneScore = 0;
                    gameOn = false;
                    Form1.Winner = "Two";
                    player.Play();

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                   GameOverScreen gos = new GameOverScreen();
                
                    f.Controls.Add(gos);

                    
                

            }
            //resest the bullets
            bullets.Clear();
            
        }
        #endregion
        private void TwoPlayerScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw bullets
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillEllipse(b.brushColor, b.x, b.y, b.size, b.size);
            }
            //draw players
            e.Graphics.FillEllipse(playerOne.brushColor, playerOne.x, playerOne.y, playerOne.size, playerOne.size);
            e.Graphics.FillEllipse(playerTwo.brushColor, playerTwo.x, playerTwo.y, playerTwo.size, playerTwo.size);
        }
    }
}
