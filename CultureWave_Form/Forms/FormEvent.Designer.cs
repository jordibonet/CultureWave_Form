namespace CultureWave_Form.Forms
{
    partial class FormEvent
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
            labelNameEvents = new Label();
            labelEventDate = new Label();
            labelDescription = new Label();
            roundedTextBoxEvenDateStart = new CultureWave_Form.Controls.RoundedTextBox();
            roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            roundedTextBoxDescription = new CultureWave_Form.Controls.RoundedTextBox();
            roundedTextBox1 = new CultureWave_Form.Controls.RoundedTextBox();
            roundedButtonGenerateIA = new CultureWave_Form.Controls.RoundedButton();
            roundedButtonCreateEvent = new CultureWave_Form.Controls.RoundedButton();
            SuspendLayout();
            // 
            // labelNameEvents
            // 
            labelNameEvents.AutoSize = true;
            labelNameEvents.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelNameEvents.Location = new Point(63, 87);
            labelNameEvents.Name = "labelNameEvents";
            labelNameEvents.Size = new Size(146, 26);
            labelNameEvents.TabIndex = 8;
            labelNameEvents.Text = "Nombre evento";
            // 
            // labelEventDate
            // 
            labelEventDate.AutoSize = true;
            labelEventDate.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelEventDate.Location = new Point(552, 87);
            labelEventDate.Name = "labelEventDate";
            labelEventDate.Size = new Size(127, 26);
            labelEventDate.TabIndex = 9;
            labelEventDate.Text = "Fecha evento";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelDescription.Location = new Point(63, 190);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(177, 26);
            labelDescription.TabIndex = 11;
            labelDescription.Text = "Descripción evento";
            // 
            // roundedTextBoxEvenDateStart
            // 
            roundedTextBoxEvenDateStart.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxEvenDateStart.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxEvenDateStart.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxEvenDateStart.BorderRadius = 20;
            roundedTextBoxEvenDateStart.BorderSize = 3;
            roundedTextBoxEvenDateStart.Font = new Font("Nunito", 12F);
            roundedTextBoxEvenDateStart.Location = new Point(552, 126);
            roundedTextBoxEvenDateStart.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxEvenDateStart.Multiline = false;
            roundedTextBoxEvenDateStart.Name = "roundedTextBoxEvenDateStart";
            roundedTextBoxEvenDateStart.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxEvenDateStart.PasswordChar = false;
            roundedTextBoxEvenDateStart.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxEvenDateStart.PlaceholderText = "YYYY:MM:DD hh:mm";
            roundedTextBoxEvenDateStart.Size = new Size(258, 45);
            roundedTextBoxEvenDateStart.TabIndex = 13;
            roundedTextBoxEvenDateStart.Texts = "";
            roundedTextBoxEvenDateStart.UnderlinedStyle = false;
            // 
            // roundedTextBoxUser
            // 
            roundedTextBoxUser.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxUser.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxUser.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxUser.BorderRadius = 20;
            roundedTextBoxUser.BorderSize = 3;
            roundedTextBoxUser.Font = new Font("Nunito", 12F);
            roundedTextBoxUser.Location = new Point(64, 126);
            roundedTextBoxUser.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxUser.Multiline = false;
            roundedTextBoxUser.Name = "roundedTextBoxUser";
            roundedTextBoxUser.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxUser.PasswordChar = false;
            roundedTextBoxUser.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxUser.PlaceholderText = "";
            roundedTextBoxUser.Size = new Size(404, 45);
            roundedTextBoxUser.TabIndex = 14;
            roundedTextBoxUser.Texts = "";
            roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // roundedTextBoxDescription
            // 
            roundedTextBoxDescription.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxDescription.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxDescription.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxDescription.BorderRadius = 20;
            roundedTextBoxDescription.BorderSize = 3;
            roundedTextBoxDescription.Font = new Font("Nunito", 12F);
            roundedTextBoxDescription.Location = new Point(64, 222);
            roundedTextBoxDescription.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxDescription.Multiline = true;
            roundedTextBoxDescription.Name = "roundedTextBoxDescription";
            roundedTextBoxDescription.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxDescription.PasswordChar = false;
            roundedTextBoxDescription.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxDescription.PlaceholderText = "";
            roundedTextBoxDescription.Size = new Size(404, 123);
            roundedTextBoxDescription.TabIndex = 15;
            roundedTextBoxDescription.Texts = "";
            roundedTextBoxDescription.UnderlinedStyle = false;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBox1.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBox1.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBox1.BorderRadius = 20;
            roundedTextBox1.BorderSize = 3;
            roundedTextBox1.Font = new Font("Nunito", 12F);
            roundedTextBox1.Location = new Point(552, 183);
            roundedTextBox1.Margin = new Padding(5, 6, 5, 6);
            roundedTextBox1.Multiline = false;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Padding = new Padding(9, 11, 9, 11);
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBox1.PlaceholderText = "YYYY:MM:DD hh:mm";
            roundedTextBox1.Size = new Size(258, 45);
            roundedTextBox1.TabIndex = 16;
            roundedTextBox1.Texts = "";
            roundedTextBox1.UnderlinedStyle = false;
            // 
            // roundedButtonGenerateIA
            // 
            roundedButtonGenerateIA.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonGenerateIA.FlatAppearance.BorderSize = 0;
            roundedButtonGenerateIA.FlatStyle = FlatStyle.Flat;
            roundedButtonGenerateIA.Font = new Font("Nunito Medium", 10F);
            roundedButtonGenerateIA.ForeColor = Color.Black;
            roundedButtonGenerateIA.Location = new Point(284, 7);
            roundedButtonGenerateIA.Name = "roundedButtonGenerateIA";
            roundedButtonGenerateIA.Size = new Size(126, 60);
            roundedButtonGenerateIA.TabIndex = 34;
            roundedButtonGenerateIA.Text = "Generar con IA";
            roundedButtonGenerateIA.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCreateEvent
            // 
            roundedButtonCreateEvent.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonCreateEvent.FlatAppearance.BorderSize = 0;
            roundedButtonCreateEvent.FlatStyle = FlatStyle.Flat;
            roundedButtonCreateEvent.Font = new Font("Nunito Medium", 10F);
            roundedButtonCreateEvent.ForeColor = Color.Black;
            roundedButtonCreateEvent.Location = new Point(519, 7);
            roundedButtonCreateEvent.Name = "roundedButtonCreateEvent";
            roundedButtonCreateEvent.Size = new Size(126, 60);
            roundedButtonCreateEvent.TabIndex = 35;
            roundedButtonCreateEvent.Text = "Crear evento";
            roundedButtonCreateEvent.UseVisualStyleBackColor = false;
            // 
            // FormEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(roundedButtonCreateEvent);
            Controls.Add(roundedButtonGenerateIA);
            Controls.Add(roundedTextBox1);
            Controls.Add(roundedTextBoxDescription);
            Controls.Add(roundedTextBoxUser);
            Controls.Add(roundedTextBoxEvenDateStart);
            Controls.Add(labelDescription);
            Controls.Add(labelEventDate);
            Controls.Add(labelNameEvents);
            Name = "FormEvent";
            Text = "FormEvent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Button button1;
        private Label labelNameEvents;
        private Label labelEventDate;
        private Controls.RoundedTextBox roundedTextBox1;
        private Label labelDescription;
        private Controls.RoundedTextBox roundedTextBoxEvenDateStart;
        private Controls.RoundedTextBox roundedTextBoxUser;
        private Controls.RoundedTextBox roundedTextBoxDescription;
        private Controls.RoundedTextBox roundedTextBox2;
        private Controls.RoundedButton roundedButtonGenerateIA;
        private Controls.RoundedButton roundedButtonCreateEvent;
    }
}