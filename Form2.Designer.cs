namespace DRAGONGAME_GAME_START_INTERFACE
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "{Player 1 Dragon Name}, Dragon Type";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(346, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 120);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opponent : {Player 2 Name} ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Location = new Point(34, 325);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(722, 227);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Battle Logs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(197, 21);
            label1.TabIndex = 0;
            label1.Text = "HP : {Dragon  choice HP}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(140, 39);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(88, 67);
            label3.Name = "label3";
            label3.Size = new Size(193, 21);
            label3.TabIndex = 1;
            label3.Text = "HP : {Dragon choice HP}";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(16, 98);
            button1.Name = "button1";
            button1.Size = new Size(208, 39);
            button1.TabIndex = 1;
            button1.Text = "Attack";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(16, 146);
            button2.Name = "button2";
            button2.Size = new Size(208, 40);
            button2.TabIndex = 2;
            button2.Text = "Special Attack";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(16, 197);
            button3.Name = "button3";
            button3.Size = new Size(208, 41);
            button3.TabIndex = 3;
            button3.Text = "Block";
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(16, 37);
            label4.Name = "label4";
            label4.Size = new Size(336, 25);
            label4.TabIndex = 2;
            label4.Text = "{Player 2 Dragon Name}, Dragon Type\r\n";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(698, 205);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Player 1 Turn :\n\n----------------------------------------------------\n\nPlayer 2 Turn :\n\n\n----------------------------------------------------\n\nPlayer 1 Turn:\n\n";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 607);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "PLAYER TURN INTERFACE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}