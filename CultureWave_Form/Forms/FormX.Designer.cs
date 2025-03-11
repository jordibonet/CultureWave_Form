namespace CultureWave_Form.Forms
{
    partial class FormX
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
            pictureBox1 = new PictureBox();
            labelCultureWave = new Label();
            pictureBoxBackground = new PictureBox();
            labelHome = new Label();
            labelEvents = new Label();
            labelReservations = new Label();
            labelSpaces = new Label();
            labelUsers = new Label();
            labelExits = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelCultureWave
            // 
            labelCultureWave.AutoSize = true;
            labelCultureWave.Font = new Font("Nunito", 12F, FontStyle.Bold);
            labelCultureWave.Location = new Point(79, 30);
            labelCultureWave.Name = "labelCultureWave";
            labelCultureWave.Size = new Size(132, 22);
            labelCultureWave.TabIndex = 1;
            labelCultureWave.Text = "CULTUREWAVE";
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.BackColor = Color.FromArgb(255, 248, 241);
            pictureBoxBackground.Location = new Point(-4, 79);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(227, 603);
            pictureBoxBackground.TabIndex = 2;
            pictureBoxBackground.TabStop = false;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.BackColor = Color.FromArgb(255, 248, 241);
            labelHome.Font = new Font("Nunito Medium", 14F, FontStyle.Bold);
            labelHome.Location = new Point(96, 128);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(64, 26);
            labelHome.TabIndex = 3;
            labelHome.Text = "Home";
            // 
            // labelEvents
            // 
            labelEvents.AutoSize = true;
            labelEvents.BackColor = Color.FromArgb(255, 248, 241);
            labelEvents.Font = new Font("Nunito Medium", 14F, FontStyle.Bold);
            labelEvents.Location = new Point(96, 210);
            labelEvents.Name = "labelEvents";
            labelEvents.Size = new Size(81, 26);
            labelEvents.TabIndex = 4;
            labelEvents.Text = "Eventos";
            // 
            // labelReservations
            // 
            labelReservations.AutoSize = true;
            labelReservations.BackColor = Color.FromArgb(255, 248, 241);
            labelReservations.Font = new Font("Nunito Medium", 14F, FontStyle.Bold);
            labelReservations.Location = new Point(96, 294);
            labelReservations.Name = "labelReservations";
            labelReservations.Size = new Size(91, 26);
            labelReservations.TabIndex = 5;
            labelReservations.Text = "Reservas";
            // 
            // labelSpaces
            // 
            labelSpaces.AutoSize = true;
            labelSpaces.BackColor = Color.FromArgb(255, 248, 241);
            labelSpaces.Font = new Font("Nunito Medium", 14F, FontStyle.Bold);
            labelSpaces.Location = new Point(96, 367);
            labelSpaces.Name = "labelSpaces";
            labelSpaces.Size = new Size(87, 26);
            labelSpaces.TabIndex = 6;
            labelSpaces.Text = "Espacios";
            // 
            // labelUsers
            // 
            labelUsers.AutoSize = true;
            labelUsers.BackColor = Color.FromArgb(255, 248, 241);
            labelUsers.Font = new Font("Nunito Medium", 14F, FontStyle.Bold);
            labelUsers.Location = new Point(96, 442);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(88, 26);
            labelUsers.TabIndex = 7;
            labelUsers.Text = "Usuarios";
            // 
            // labelExits
            // 
            labelExits.AutoSize = true;
            labelExits.BackColor = Color.FromArgb(255, 248, 241);
            labelExits.Font = new Font("Nunito Medium", 14F, FontStyle.Bold);
            labelExits.Location = new Point(99, 517);
            labelExits.Name = "labelExits";
            labelExits.Size = new Size(52, 26);
            labelExits.TabIndex = 8;
            labelExits.Text = "Salir";
            // 
            // FormX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(labelExits);
            Controls.Add(labelUsers);
            Controls.Add(labelSpaces);
            Controls.Add(labelReservations);
            Controls.Add(labelEvents);
            Controls.Add(labelHome);
            Controls.Add(pictureBoxBackground);
            Controls.Add(labelCultureWave);
            Controls.Add(pictureBox1);
            Name = "FormX";
            Text = "FormX";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelCultureWave;
        private PictureBox pictureBoxBackground;
        private Label labelHome;
        private Label labelEvents;
        private Label labelReservations;
        private Label labelSpaces;
        private Label labelUsers;
        private Label labelExits;
    }
}