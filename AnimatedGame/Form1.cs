///Devloper: Sam Wolfgram
///Date: October 7 2021
///Discription: A multiplayer areana shooter in 2D
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedGame
{
    public partial class Form1 : Form
    {
        //variables that need to be manipulated anywhere
        public static string Winner = ""; 
        public static int PlayerOneWins = 0;
        public static int PlayerTwoWins = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // put the proper screen on
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
        }
    }
}
