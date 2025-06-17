using System.Windows.Forms;

namespace DRAGONGAME_GAME_START_INTERFACE
{
    public partial class Form1 : Form
    {
        // varaibles for players to enter thei player name and dragon names

        public string Player1Name;
        public string Player2Name;
        public string Player1DragName;
        public string Player2DragName;


        public string[] P1data = new string[3];
        public string[] P2data = new string [3];
        public int[] P1values = new int [4];
        public int[] P2values = new int [4];


        // constant for dragons name and their individual stats

        const string ICE_DRAG_NAME = "Ice Dragon";
        const int ICE_DRAG_HP = 20;
        const int ICE_DRAG_ATK = 5;
        const int ICE_DRAG_SPATK = 12;
        const int ICE_DRAG_BLOCK = 4;



        const string FIRE_DRAG_NAME = "Fire Dragon";
        const int FIRE_DRAG_HP = 20;
        const int FIRE_DRAG_ATK = 5;
        const int FIRE_DRAG_SPATK = 12;
        const int FIRE_DRAG_BLOCK = 4;



        const string EARTH_DRAG_NAME = "Fire Dragon";
        const int EARTH_DRAG_HP = 20;
        const int EARTH_DRAG_ATK = 5;
        const int EARTH_DRAG_SPATK = 12;
        const int EARTH_DRAG_BLOCK = 4;



        const string WIND_DRAG_NAME = "Fire Dragon";
        const int WIND_DRAG_HP = 20;
        const int WIND_DRAG_ATK = 5;
        const int WIND_DRAG_SPATK = 12;
        const int WIND_DRAG_BLOCK = 4;






        public Form1()
        {
            InitializeComponent();
            //initial disabling of the start button
            button2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //broken button
        private void button1_Click(object sender, EventArgs e)
        {



        }
        //method to enable start button when both save buttons have been clicked
        public void enable()
        {

            //condition to enable start button once save buttons are disabled
            if (button1.Enabled == false && button3.Enabled == false)
                button2.Enabled = true;

        }

        
        private void button3_Click(object sender, EventArgs e)
        {

        }



        //start button
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SEEEYUH IN THE PLAYER TURN FORM");
            // command to bring up the second form when the start button is clicked


            //passing arrays
            object[] data = new object[] { P1values, P1data, P2values, P2data };
            Form2 F2 = new Form2(data);
            F2.Show();
            MessageBox.Show("WELCOME TO PLAYER TURN FORM");
            

            //command to hide for 1 when the start button is clicked
            this.Hide();
        }

       
        
        // start code unable to use
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //WIND 1
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {


        }

        //EARTH 1
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        // FIRE 2
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {


        }

        //ICE 2
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        //WIND 3
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {


        }

        //EARTH 2
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //end of unusable code


        //player 1 save button
        private void button1_Click_1(object sender, EventArgs e)
        {


            //assigning textbox input to variables to store those inputs
            Player1Name = textBox1.Text;
            Player1DragName = textBox2.Text;
            //population of arrays for strings
            P1data[0] = Player1Name;
            P1data[1] = Player1DragName;


            //if statements to check which radio button is clicked and populate integer arrays and constant dragon name to the data array depending on a raido button click


            if (radioButton1.Checked)
               

            P1data[2] = FIRE_DRAG_NAME;
            P1values[0] = FIRE_DRAG_HP;
            P1values[1] = FIRE_DRAG_BLOCK;
            P1values[2] = FIRE_DRAG_ATK;
            P1values[3] = FIRE_DRAG_SPATK;


            if (radioButton2.Checked)
            
            P1data[2] = ICE_DRAG_NAME;
            P1values[0] = ICE_DRAG_HP;
            P1values[1] = ICE_DRAG_BLOCK;
             P1values[2] = ICE_DRAG_ATK;
             P1values[3] = ICE_DRAG_SPATK;


            if (radioButton3.Checked)
            
            P1data[2] = WIND_DRAG_NAME;
            P1values[0] = WIND_DRAG_HP;
            P1values[1] = WIND_DRAG_BLOCK;
            P1values[2] = WIND_DRAG_ATK;
             P1values[3] = WIND_DRAG_SPATK;



            if (radioButton4.Checked)
           
             P1data[2] = EARTH_DRAG_NAME;
            P1values[0] = EARTH_DRAG_HP;
             P1values[1] = EARTH_DRAG_BLOCK;
            P1values[2] = EARTH_DRAG_ATK;
             P1values[3] = EARTH_DRAG_SPATK;

            MessageBox.Show("player saved");
            button1.Enabled = false;
            enable();
            
           
        }


        //player 2 save button
        private void button3_Click_1(object sender, EventArgs e)
        {


            //assigning textbox input to variables to store those inputs
            Player2Name = textBox3.Text;
            Player2DragName = textBox4.Text;
            //population of arrays for strings
            P2data[0] = Player2Name;
            P2data[1] = Player2DragName;


            //if statements to check which raido button is clicked and populate integer arrays and constsnat dragon name to the data array depending on a raido button click



            if (radioButton5.Checked)
                P2data[2] = FIRE_DRAG_NAME;
            P2values[0] = FIRE_DRAG_HP;
            P2values[1] = FIRE_DRAG_BLOCK;
            P2values[2] = FIRE_DRAG_ATK;
            P2values[3] = FIRE_DRAG_SPATK;


            if (radioButton6.Checked)
                P2data[2] = ICE_DRAG_NAME;
            P2values[0] = ICE_DRAG_HP;
            P2values[1] = ICE_DRAG_BLOCK;
            P2values[2] = ICE_DRAG_ATK;
            P2values[3] = ICE_DRAG_SPATK;


            if (radioButton7.Checked)
                P2data[2] = WIND_DRAG_NAME;
            P2values[0] = WIND_DRAG_HP;
            P2values[1] = WIND_DRAG_BLOCK;
            P2values[2] = WIND_DRAG_ATK;
            P2values[3] = WIND_DRAG_SPATK;


            if (radioButton8.Checked)
                P2data[2] = EARTH_DRAG_NAME;
            P2values[0] = EARTH_DRAG_HP;
            P2values[1] = EARTH_DRAG_BLOCK;
            P2values[2] = EARTH_DRAG_ATK;
            P2values[3] = EARTH_DRAG_SPATK;

            MessageBox.Show("player saved");
            button3.Enabled = false;
            enable();





        }
    }
}
