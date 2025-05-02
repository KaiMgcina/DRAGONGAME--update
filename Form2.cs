using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRAGONGAME_GAME_START_INTERFACE
{
    public partial class Form2 : Form
    {

        public static int player1;
        public static int player2;

        
        


      


        public Form2()
        {
            InitializeComponent();
            labelWhoStarts.Hide();
            Form1.P1data.SetValue(Form1.Player1Name, 0);
            Form1.P1data.SetValue(Form1.Player1DragName, 0);
            
        }

        //randomroll method to get a random number from 1-6
        public int randomRoll()
        {
            Random r = new Random();
            int num = r.Next(1, 6);
            return num;
        }

        //takle initiative method to show sho will start after two calls of the random roll method
        public void takeInitiative()
        {

            player1 = randomRoll();
            player2 = randomRoll();
            //conditionals to decide who will start based on who gets the higher number
            if (player1 > player2)
                player1 = 1;
            labelWhoStarts.Text = player1.ToString();
                labelWhoStarts.Show();
            if (player2 > player1)
                player2 = 2;
            labelWhoStarts.Text = player2.ToString();
            labelWhoStarts.Show();
            if (player1 == player2)
            {
                //loop to re run the roll in case both players numbers are the same.
                while (player1 == player2)
                {
                    player1 = randomRoll();
                    player2 = randomRoll();
                    if (player1 > player2)
                        player1 = 1;
                    labelWhoStarts.Text = player1.ToString();
                    labelWhoStarts.Show();
                    if (player2 > player1)
                        player2 = 2;
                    labelWhoStarts.Text = player2.ToString();
                    labelWhoStarts.Show();
                }
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
