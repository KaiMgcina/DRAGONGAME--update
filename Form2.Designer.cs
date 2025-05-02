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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBoxInTurn = new GroupBox();
            buttonInTurnBLOCK = new Button();
            buttonInTurnSPK = new Button();
            buttonInTurnATK = new Button();
            labelInTurnhp = new Label();
            groupBoxWaiting = new GroupBox();
            labelWaitingDnameandType = new Label();
            labelWaitingHp = new Label();
            label2 = new Label();
            groupBoxLogs = new GroupBox();
            richTextBoxLogs = new RichTextBox();
            labelWhoStarts = new Label();
            groupBoxInTurn.SuspendLayout();
            groupBoxWaiting.SuspendLayout();
            groupBoxLogs.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInTurn
            // 
            groupBoxInTurn.BackColor = Color.Transparent;
            groupBoxInTurn.Controls.Add(buttonInTurnBLOCK);
            groupBoxInTurn.Controls.Add(buttonInTurnSPK);
            groupBoxInTurn.Controls.Add(buttonInTurnATK);
            groupBoxInTurn.Controls.Add(labelInTurnhp);
            groupBoxInTurn.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxInTurn.ForeColor = Color.Gold;
            groupBoxInTurn.Location = new Point(34, 29);
            groupBoxInTurn.Name = "groupBoxInTurn";
            groupBoxInTurn.Size = new Size(249, 265);
            groupBoxInTurn.TabIndex = 0;
            groupBoxInTurn.TabStop = false;
            groupBoxInTurn.Text = "{Player 1 Dragon Name}, Dragon Type";
            // 
            // buttonInTurnBLOCK
            // 
            buttonInTurnBLOCK.BackColor = Color.White;
            buttonInTurnBLOCK.FlatStyle = FlatStyle.Flat;
            buttonInTurnBLOCK.Location = new Point(16, 197);
            buttonInTurnBLOCK.Name = "buttonInTurnBLOCK";
            buttonInTurnBLOCK.Size = new Size(208, 41);
            buttonInTurnBLOCK.TabIndex = 3;
            buttonInTurnBLOCK.Text = "Block";
            buttonInTurnBLOCK.UseVisualStyleBackColor = false;
            // 
            // buttonInTurnSPK
            // 
            buttonInTurnSPK.BackColor = Color.White;
            buttonInTurnSPK.FlatStyle = FlatStyle.Flat;
            buttonInTurnSPK.Location = new Point(16, 146);
            buttonInTurnSPK.Name = "buttonInTurnSPK";
            buttonInTurnSPK.Size = new Size(208, 40);
            buttonInTurnSPK.TabIndex = 2;
            buttonInTurnSPK.Text = "Special Attack";
            buttonInTurnSPK.UseVisualStyleBackColor = false;
            // 
            // buttonInTurnATK
            // 
            buttonInTurnATK.BackColor = Color.White;
            buttonInTurnATK.FlatStyle = FlatStyle.Flat;
            buttonInTurnATK.Location = new Point(16, 98);
            buttonInTurnATK.Name = "buttonInTurnATK";
            buttonInTurnATK.Size = new Size(208, 39);
            buttonInTurnATK.TabIndex = 1;
            buttonInTurnATK.Text = "Attack";
            buttonInTurnATK.UseVisualStyleBackColor = false;
            // 
            // labelInTurnhp
            // 
            labelInTurnhp.AutoSize = true;
            labelInTurnhp.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelInTurnhp.Location = new Point(16, 38);
            labelInTurnhp.Name = "labelInTurnhp";
            labelInTurnhp.Size = new Size(239, 20);
            labelInTurnhp.TabIndex = 0;
            labelInTurnhp.Text = "HP : {Dragon  choice HP}";
            // 
            // groupBoxWaiting
            // 
            groupBoxWaiting.BackColor = Color.Transparent;
            groupBoxWaiting.Controls.Add(labelWaitingDnameandType);
            groupBoxWaiting.Controls.Add(labelWaitingHp);
            groupBoxWaiting.Controls.Add(label2);
            groupBoxWaiting.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxWaiting.ForeColor = Color.Gold;
            groupBoxWaiting.Location = new Point(346, 127);
            groupBoxWaiting.Name = "groupBoxWaiting";
            groupBoxWaiting.Size = new Size(436, 120);
            groupBoxWaiting.TabIndex = 1;
            groupBoxWaiting.TabStop = false;
            groupBoxWaiting.Text = "Opponent : {Player 2 Name} ";
            groupBoxWaiting.Enter += groupBox2_Enter;
            // 
            // labelWaitingDnameandType
            // 
            labelWaitingDnameandType.AutoSize = true;
            labelWaitingDnameandType.Font = new Font("Showcard Gothic", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelWaitingDnameandType.Location = new Point(16, 37);
            labelWaitingDnameandType.Name = "labelWaitingDnameandType";
            labelWaitingDnameandType.Size = new Size(400, 23);
            labelWaitingDnameandType.TabIndex = 2;
            labelWaitingDnameandType.Text = "{Player 2 Dragon Name}, Dragon Type\r\n";
            // 
            // labelWaitingHp
            // 
            labelWaitingHp.AutoSize = true;
            labelWaitingHp.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelWaitingHp.Location = new Point(88, 67);
            labelWaitingHp.Name = "labelWaitingHp";
            labelWaitingHp.Size = new Size(235, 20);
            labelWaitingHp.TabIndex = 1;
            labelWaitingHp.Text = "HP : {Dragon choice HP}";
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
            // groupBoxLogs
            // 
            groupBoxLogs.BackColor = Color.Transparent;
            groupBoxLogs.Controls.Add(richTextBoxLogs);
            groupBoxLogs.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxLogs.ForeColor = Color.Gold;
            groupBoxLogs.Location = new Point(34, 325);
            groupBoxLogs.Name = "groupBoxLogs";
            groupBoxLogs.Size = new Size(722, 227);
            groupBoxLogs.TabIndex = 2;
            groupBoxLogs.TabStop = false;
            groupBoxLogs.Text = "Battle Logs";
            // 
            // richTextBoxLogs
            // 
            richTextBoxLogs.ForeColor = Color.Gold;
            richTextBoxLogs.Location = new Point(6, 22);
            richTextBoxLogs.Name = "richTextBoxLogs";
            richTextBoxLogs.Size = new Size(698, 205);
            richTextBoxLogs.TabIndex = 0;
            richTextBoxLogs.Text = "Player 1 Turn :\n\n----------------------------------------------------\n\nPlayer 2 Turn :\n\n\n----------------------------------------------------\n\nPlayer 1 Turn:\n\n";
            richTextBoxLogs.TextChanged += richTextBox1_TextChanged;
            // 
            // labelWhoStarts
            // 
            labelWhoStarts.AutoSize = true;
            labelWhoStarts.Location = new Point(526, 60);
            labelWhoStarts.Name = "labelWhoStarts";
            labelWhoStarts.Size = new Size(86, 15);
            labelWhoStarts.TabIndex = 3;
            labelWhoStarts.Text = "labelWhoStarts";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 607);
            Controls.Add(labelWhoStarts);
            Controls.Add(groupBoxLogs);
            Controls.Add(groupBoxWaiting);
            Controls.Add(groupBoxInTurn);
            ForeColor = Color.Gold;
            Name = "Form2";
            Text = "PLAYER TURN INTERFACE";
            Load += Form2_Load;
            groupBoxInTurn.ResumeLayout(false);
            groupBoxInTurn.PerformLayout();
            groupBoxWaiting.ResumeLayout(false);
            groupBoxWaiting.PerformLayout();
            groupBoxLogs.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInTurn;
        private GroupBox groupBoxWaiting;
        private GroupBox groupBoxLogs;
        private Label labelInTurnhp;
        private Button buttonInTurnBLOCK;
        private Button buttonInTurnSPK;
        private Button buttonInTurnATK;
        private Label labelWaitingDnameandType;
        private Label labelWaitingHp;
        private Label label2;
        private RichTextBox richTextBoxLogs;
        private Label labelWhoStarts;
    }
}