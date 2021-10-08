using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimatedGame
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Form f = this.FindForm();

            TwoPlayerScreen tps = new TwoPlayerScreen();



            f.Controls.Add(tps);

            f.Controls.Remove(this);
            outputLabel.BackColor = Color.White;
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            PlayerOneLabel.Text = $"Player One Wins:\n{Form1.PlayerOneWins}";
            PlayerTwoLabel.Text = $"Player Two Wins:\n{Form1.PlayerTwoWins}";
        }

        private void twoPlayer_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            TwoPlayerScreen tps = new TwoPlayerScreen();
            f.Controls.Add(tps);
            f.Controls.Remove(this);
        }

        private void infobutton_Click_1(object sender, EventArgs e)
        {
            outputLabel.BackColor = Color.White;
            outputLabel.Text = "Welcome,\nThis game is called TANKS\nTwo players battle until someone" +
                " dies three times\nDon't Leave the screen or your enemy will score\nPlayer one controls with arrows and the space bar\nPlayer two controls with 'WASD' and 'Z'";

        }
    }
}
