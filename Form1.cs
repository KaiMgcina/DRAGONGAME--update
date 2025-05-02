namespace DRAGONGAME_GAME_START_INTERFACE
{
    public partial class Form1 : Form
    {
        // varaibles for players to enter thei player name and dragon names
        public static string Player1Name;
        public static string Player2Name;
        public static string Player1DragName;
        public static string Player2DragName;

        // player arrays for now till assigned
        public static string[] P1data;
        public static string[] P2data;
        public static int[] P1values;
        public static int[] P2values;

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



        

        Form2 F2 = new Form2();
        Form1 F1 = new Form1();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //player 2 save button
        private void button1_Click(object sender, EventArgs e)
        {

            Player2Name = textBoxP2name.Text;
            Player2DragName = textBoxP2dname.Text;
            //population of arrays for strings
            P1data.SetValue(Player2Name, 0);
            P1data.SetValue(Player2DragName, 1);


            //if statements to populate integer arrays depending on a raido button click
            if (radioButtonFire2.Checked)
                P1values = (int[])radioButtonFire2.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }

            if (radioButtonIce2.Checked)
                P1values = (int[])radioButtonIce2.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }
            if (radioButtonWind2.Checked)
                P1values = (int[])radioButtonWind2.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }
            if (radioButtonEarth2.Checked)
                P1values = (int[])radioButtonEarth2.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }
            //disable button after click
            buttonSave1.Enabled = false;
        }
        //method to disable and enable start button
        public void enable()
        {
            //initial disable of start button
            buttonStart.Enabled = false;    
            //condition to enable start button once save buttons are disabled
            if ((buttonSave1.Enabled = false) && (buttonSave2.Enabled = false)) 
                buttonStart.Enabled = true;
        }

        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // command to bring up the second form when the start button is clicked
            F2.Show();
            //command to hide for 1 when the start button is clicked
            F1.Hide();
            
        }

        //player 1 save buttton
        private void buttonSave1_Click(object sender, EventArgs e)
        {

            Player1Name = textBoxP1name.Text;
            Player1DragName = textBoxP1dname.Text;
            //population of arrays for strings
            P1data.SetValue(Player1Name, 0);
            P1data.SetValue(Player1DragName, 1);

           
            //if statements to populate integer arrays depending on a raido button click
            if(radioButtonFire1.Checked)
                P1values = (int[])radioButtonFire1.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }

            if (radioButtonIce1.Checked)
                P1values = (int[])radioButtonIce1.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }
            if (radioButtonWind1.Checked)
                P1values = (int[])radioButtonWind1.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }
            if (radioButtonEarth1.Checked)
                P1values = (int[])radioButtonEarth1.Tag;
            for (int i = 0; i < P1values.Length; i++)
            {
                P1values.SetValue(P1values[i], i);
            }
            //disable button after click
            buttonSave2.Enabled = false;
        }
        //assignment of constants for dragon starts to player 1 radio butttons

        private void radioButtonFire1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFire1.Tag = new int[4] { Form1.FIRE_DRAG_HP, Form1.FIRE_DRAG_ATK, Form1.FIRE_DRAG_SPATK, Form1.FIRE_DRAG_BLOCK };
        }

        private void radioButtonIce1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonIce1.Tag = new int[4] { Form1.ICE_DRAG_HP, Form1.ICE_DRAG_ATK, Form1.ICE_DRAG_SPATK, Form1.ICE_DRAG_BLOCK };
        }

        private void radioButtonWind1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonWind1.Tag = new int[4] { Form1.WIND_DRAG_HP, Form1.WIND_DRAG_ATK, Form1.WIND_DRAG_SPATK, Form1.WIND_DRAG_BLOCK };

        }

        private void radioButtonEarth1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonEarth1.Tag = new int[4] { Form1.EARTH_DRAG_HP, Form1.EARTH_DRAG_ATK, Form1.EARTH_DRAG_SPATK, Form1.EARTH_DRAG_BLOCK };
        }

        //Stat of constant assignment to player 2 dragon radio buttons
        private void radioButtonFire2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFire2.Tag = new int[4] { Form1.FIRE_DRAG_HP, Form1.FIRE_DRAG_ATK, Form1.FIRE_DRAG_SPATK, Form1.FIRE_DRAG_BLOCK };
        }

        private void radioButtonIce2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonIce2.Tag = new int[4] { Form1.ICE_DRAG_HP, Form1.ICE_DRAG_ATK, Form1.ICE_DRAG_SPATK, Form1.ICE_DRAG_BLOCK };
        }

        private void radioButtonWind2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonWind2.Tag = new int[4] { Form1.WIND_DRAG_HP, Form1.WIND_DRAG_ATK, Form1.WIND_DRAG_SPATK, Form1.WIND_DRAG_BLOCK };

        }

        private void radioButtonEarth2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonEarth2.Tag = new int[4] { Form1.EARTH_DRAG_HP, Form1.EARTH_DRAG_ATK, Form1.EARTH_DRAG_SPATK, Form1.EARTH_DRAG_BLOCK };
        }

        



    }
}
