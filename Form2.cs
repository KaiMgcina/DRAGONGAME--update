using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DRAGONGAME_GAME_START_INTERFACE
{

    public partial class Form2 : Form
    {
        public static string[] P1data;
        public static string[] P2data;
        public static int[] P1values;
        public static int[] P2values;
        public static int player1;
        public static int player2;
        int currentPlayerIndex = 1;
        int secondplayerIndex = 2;
        static bool player1isBlocking;
        static bool player2isBlocking;


        public Form2(object[] data)
        {
            InitializeComponent();

            //passing array
            P1values = (int[])data[0];
            P1data = (String[])data[1];
            P2values = (int[])data[2];
            P2data = (String[])data[3];
            randomRoll();
            takeInitiative();
            displayinformationgroupbox();
            //initially hiding of the rest button
            buttonREST.Hide();
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

                MessageBox.Show("PLAYER 1 STARTS");

            if (player2 > player1)

                MessageBox.Show("PLAYER 2 STARTS");
            if (player1 == player2)
            {
                //loop to re run the roll in case both players numbers are the same.
                while (player1 == player2)
                {
                    player1 = randomRoll();
                    player2 = randomRoll();
                    if (player1 > player2)
                        MessageBox.Show("PLAYER 1 STARTS");

                    if (player2 > player1)
                        MessageBox.Show("PLAYER 2 STARTS");

                }
            }

        }
        public void displayinformationgroupbox()
        {
            //displaying information depnding on which player rooled higher number
            if (player1 > player2)
            {

                label1.Text = P1data[2];
                label5.Text = P1data[0];
                label6.Text = P1data[2];
                string hp = P1values[0].ToString();
                label7.Text = (hp);


                label4.Text = P2data[0];
                label3.Text = P2data[1];
                label8.Text = P2data[2];
                string hp2 = P2values[0].ToString();
                label9.Text = P2data[0];

            }
            else if (player2 > player1)
            {
                label1.Text = P2data[0];
                label5.Text = P2data[1];
                label6.Text = P2data[2];
                label7.Text = P2data[0];
                string hp = P2values[0].ToString();
                label7.Text = (hp);

                label4.Text = P1data[0];
                label3.Text = P1data[1];
                label8.Text = P1data[2];
                label9.Text = P1data[0];





            }
        }


        // method for block which is called in the block button method
        //
        public void block(int Playerindex)
        {
            switch (Playerindex)
            {
                case 1:
                    player1isBlocking = true;
                    break;
                case 2:
                    player2isBlocking = true;
                    break;
                default:
                    // Optionally handle unexpected Playerindex values here
                    break;
            }


        }
        // attack method
        public void Attack(int PLAYER1, int PLAYER2)
        {
            int damage;
            string attackerDragon;
            string defenderDragon;
            int[] attackerStats;
            int[] defenderStats;
            bool[] isBlocking;
            switch (PLAYER1)
            {
                case 1:
                    damage = P1values[2];
                    attackerDragon = P1data[1];
                    attackerStats = P1values;
                    break;
                default:
                    damage = P2values[2];
                    attackerDragon = P2data[1];
                    attackerStats = P2values;
                    break;
            }
            switch (PLAYER2)
            {
                case 1:
                    defenderDragon = P1data[1];
                    defenderStats = P1values;
                    isBlocking = new bool[] { player1isBlocking };
                    break;
                default:
                    defenderDragon = P2data[1];
                    defenderStats = P2values;
                    isBlocking = new bool[] { player2isBlocking };
                    break;
            }
            if (isBlocking[0])
            {
                switch (PLAYER2)
                {
                    case 0:
                        damage -= P1values[2];
                        break;
                    default:
                        damage -= P2values[2];
                        break;
                }
            }

            // Apply damage to the defender’s stats
            defenderStats[0] -= damage;

            // Adjust player’s stats based on who the defender is
            switch (PLAYER2)
            {
                case 0:
                    P1values[2] -= defenderStats[0];
                    break;
                default:
                    P2values[0] -= defenderStats[0];
                    break;
            }
            // displaing information after move has been completed
            defenderStats[0] -= damage;
            richTextBox1.AppendText(attackerDragon + "damage done" + damage);
        }

        // same as normal attack method but using special attack values
        public void SpecialAttack(int attackerIndex, int defenderIndex)
        {
            int damage;
            string attackerDragon;
            string defenderDragon;
            int[] attackerStats;
            int[] defenderStats;
            bool[] isBlocking;
            // determing whose move it is 
            switch (attackerIndex)
            {
                case 1:
                    damage = P1values[1];
                    attackerDragon = P1data[3];
                    attackerStats = P1values;
                    break;
                default:
                    damage = P2values[1];
                    attackerDragon = P2data[3];
                    attackerStats = P2values;
                    break;
            }
            switch (defenderIndex)
            {
                case 1:
                    defenderDragon = P1data[1];
                    defenderStats = P1values;
                    isBlocking = new bool[] { player1isBlocking };
                    break;
                default:
                    defenderDragon = P2data[1];
                    defenderStats = P2values;
                    isBlocking = new bool[] { player2isBlocking };
                    break;
            }
            // calculating damage if block has been played
            if (isBlocking[0])
            {
                switch (defenderIndex)
                {
                    case 0:
                        damage -= P1values[3];
                        break;
                    default:
                        damage -= P2values[3];
                        break;
                }
            }

            defenderStats[0] -= damage;

            switch (defenderIndex)
            {
                case 0:
                    P1values[0] -= defenderStats[0];
                    break;
                default:
                    P2values[0] -= defenderStats[0];
                    break;
            }

            // displaying text

            richTextBox1.AppendText(attackerDragon + "damage done with special" + damage);

        }

        private void DamageDealt1()
        {
            //Health -= amount; 
            //if (Health < 0) Health = 0;

        }
        private void ResetBlock1()
        {
            //IsBlocking = false;
        }

        //method used to switch turns after player has selected move
        private void SwitchTurn()
        {
            if (P1values[0] == 0)

            {
                richTextBox1.AppendText("Game over Player 2 has won");
            }
            else if (P2values[0] == 0)

            {
                richTextBox1.AppendText("Game over Player 1 has won");
            }

            else if (P1values[0] > 1)
            {

                string temp1 = label1.Text;
                label1.Text = label4.Text;
                label4.Text = temp1;

                string temp2 = label5.Text;
                label5.Text = label3.Text;
                label3.Text = temp2;







            }
            else if (P2values[0] > 1)
            {

                string temp1 = label1.Text;
                label1.Text = label4.Text;
                label4.Text = temp1;

                string temp2 = label5.Text;
                label5.Text = label3.Text;
                label3.Text = temp2;







            }
        }



        private void ResetBlock2()
        {
            // IsBlocking = false;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //block
            int attackerIndex;

            if (currentPlayerIndex == 1)
            {
                attackerIndex = 1;

            }
            else
            {
                attackerIndex = 2;


                block(attackerIndex);


            }


            SwitchTurn();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //attack button
            int attackerIndex;
            int defenderIndex;
            if (currentPlayerIndex == 1)
            {
                attackerIndex = 1;
                defenderIndex = 2;
            }
            else
            {
                attackerIndex = 1;
                defenderIndex = 2;

                Attack(attackerIndex, defenderIndex);


            }
            SwitchTurn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //special attack
            int attackerIndex;
            int defenderIndex;
            if (currentPlayerIndex == 1)
            {
                attackerIndex = 1;
                defenderIndex = 2;
            }
            else
            {
                attackerIndex = 1;
                defenderIndex = 2;

                SpecialAttack(attackerIndex, defenderIndex);


            }
            // hides attack, special attack and block
            button2.Hide();//special attack
            button1.Hide();//attack
            button3.Hide();//block
            //show the rest button
            buttonREST.Show();

            SwitchTurn();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //health
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //dragon type
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //health
        }
        //rest method for the rest button
        public void Rest(string Name)
        {
            Name = label1.Text; // name gets the value of dragon name in the action group box
            //tells the player when the button is clicked that their dragon is too tired to attack
            richTextBox1.AppendText(Name + " is too tired to fight, and rests a while");
        }

        private void buttonREST_Click(object sender, EventArgs e)
        {

            Rest(Name); // rest method call
            //re showing the attack,special attack and block buttons
            button2.Show();//special attack
            button1.Show();//attack
            button3.Show();//block
            //re hiding the rest button
            buttonREST.Hide();
        }
    }
}
