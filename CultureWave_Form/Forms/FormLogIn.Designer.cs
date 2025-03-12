namespace CultureWave_Form
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCultureWave = new Label();
            roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            roundedTextBoxPassword = new CultureWave_Form.Controls.RoundedTextBox();
            labelUser = new Label();
            labelPassword = new Label();
            buttonLogIn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelCultureWave
            // 
            labelCultureWave.AutoSize = true;
            labelCultureWave.Font = new Font("Nunito", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCultureWave.Location = new Point(510, 232);
            labelCultureWave.Name = "labelCultureWave";
            labelCultureWave.Size = new Size(262, 44);
            labelCultureWave.TabIndex = 0;
            labelCultureWave.Text = "CULTUREWAVE";
            // 
            // roundedTextBoxUser
            // 
            roundedTextBoxUser.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxUser.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxUser.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxUser.BorderRadius = 10;
            roundedTextBoxUser.BorderSize = 3;
            roundedTextBoxUser.Font = new Font("Nunito Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBoxUser.Location = new Point(394, 344);
            roundedTextBoxUser.Margin = new Padding(5, 4, 5, 4);
            roundedTextBoxUser.Multiline = false;
            roundedTextBoxUser.Name = "roundedTextBoxUser";
            roundedTextBoxUser.Padding = new Padding(9, 16, 9, 16);
            roundedTextBoxUser.PasswordChar = false;
            roundedTextBoxUser.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxUser.PlaceholderText = "";
            roundedTextBoxUser.Size = new Size(492, 55);
            roundedTextBoxUser.TabIndex = 1;
            roundedTextBoxUser.Texts = "";
            roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // roundedTextBoxPassword
            // 
            roundedTextBoxPassword.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxPassword.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxPassword.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxPassword.BorderRadius = 10;
            roundedTextBoxPassword.BorderSize = 3;
            roundedTextBoxPassword.Font = new Font("Nunito Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBoxPassword.Location = new Point(394, 447);
            roundedTextBoxPassword.Margin = new Padding(5, 4, 5, 4);
            roundedTextBoxPassword.Multiline = false;
            roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            roundedTextBoxPassword.Padding = new Padding(9, 16, 9, 16);
            roundedTextBoxPassword.PasswordChar = false;
            roundedTextBoxPassword.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxPassword.PlaceholderText = "";
            roundedTextBoxPassword.Size = new Size(492, 55);
            roundedTextBoxPassword.TabIndex = 2;
            roundedTextBoxPassword.Texts = "";
            roundedTextBoxPassword.UnderlinedStyle = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Nunito Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(394, 318);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(67, 22);
            labelUser.TabIndex = 3;
            labelUser.Text = "Usuario";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Nunito Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(394, 421);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(94, 22);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Contraseña";
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.FromArgb(228, 179, 99);
            buttonLogIn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogIn.Location = new Point(572, 559);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(140, 60);
            buttonLogIn.TabIndex = 5;
            buttonLogIn.Text = "Iniciar Sesión";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(544, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 192);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 241);
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogIn);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(roundedTextBoxPassword);
            Controls.Add(roundedTextBoxUser);
            Controls.Add(labelCultureWave);
            Name = "FormLogin";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCultureWave;
        private Controls.RoundedTextBox roundedTextBoxUser;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Label labelUser;
        private Label labelPassword;
        private Button buttonLogIn;
        private PictureBox pictureBox1;
    }
}
