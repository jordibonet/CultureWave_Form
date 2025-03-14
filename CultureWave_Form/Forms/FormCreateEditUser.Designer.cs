﻿namespace CultureWave_Form.Forms
{
    partial class FormCreateEditUser
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
            roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            labelUser = new Label();
            buttonAceptar = new Button();
            roundedTextBoxEmail = new CultureWave_Form.Controls.RoundedTextBox();
            labelEmail = new Label();
            roundedTextBoxRol = new CultureWave_Form.Controls.RoundedTextBox();
            labelRol = new Label();
            roundedTextBoxPassword = new CultureWave_Form.Controls.RoundedTextBox();
            labelPassword = new Label();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // roundedTextBoxUser
            // 
            roundedTextBoxUser.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxUser.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxUser.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxUser.BorderRadius = 20;
            roundedTextBoxUser.BorderSize = 3;
            roundedTextBoxUser.Font = new Font("Nunito", 12F);
            roundedTextBoxUser.Location = new Point(92, 57);
            roundedTextBoxUser.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxUser.Multiline = false;
            roundedTextBoxUser.Name = "roundedTextBoxUser";
            roundedTextBoxUser.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxUser.PasswordChar = false;
            roundedTextBoxUser.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxUser.PlaceholderText = "";
            roundedTextBoxUser.Size = new Size(334, 45);
            roundedTextBoxUser.TabIndex = 23;
            roundedTextBoxUser.Texts = "";
            roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelUser.Location = new Point(91, 25);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(79, 26);
            labelUser.TabIndex = 22;
            labelUser.Text = "Usuario";
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.FromArgb(228, 179, 99);
            buttonAceptar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAceptar.FlatAppearance.BorderSize = 0;
            buttonAceptar.FlatStyle = FlatStyle.Flat;
            buttonAceptar.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAceptar.Location = new Point(104, 429);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(126, 50);
            buttonAceptar.TabIndex = 27;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // roundedTextBoxEmail
            // 
            roundedTextBoxEmail.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxEmail.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxEmail.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxEmail.BorderRadius = 20;
            roundedTextBoxEmail.BorderSize = 3;
            roundedTextBoxEmail.Font = new Font("Nunito", 12F);
            roundedTextBoxEmail.Location = new Point(92, 150);
            roundedTextBoxEmail.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxEmail.Multiline = false;
            roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            roundedTextBoxEmail.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxEmail.PasswordChar = false;
            roundedTextBoxEmail.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxEmail.PlaceholderText = "";
            roundedTextBoxEmail.Size = new Size(334, 45);
            roundedTextBoxEmail.TabIndex = 26;
            roundedTextBoxEmail.Texts = "";
            roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelEmail.Location = new Point(91, 118);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(171, 26);
            labelEmail.TabIndex = 25;
            labelEmail.Text = "Correo electrónico";
            // 
            // roundedTextBoxRol
            // 
            roundedTextBoxRol.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxRol.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxRol.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxRol.BorderRadius = 20;
            roundedTextBoxRol.BorderSize = 3;
            roundedTextBoxRol.Font = new Font("Nunito", 12F);
            roundedTextBoxRol.Location = new Point(93, 338);
            roundedTextBoxRol.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxRol.Multiline = false;
            roundedTextBoxRol.Name = "roundedTextBoxRol";
            roundedTextBoxRol.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxRol.PasswordChar = false;
            roundedTextBoxRol.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxRol.PlaceholderText = "";
            roundedTextBoxRol.Size = new Size(334, 45);
            roundedTextBoxRol.TabIndex = 31;
            roundedTextBoxRol.Texts = "";
            roundedTextBoxRol.UnderlinedStyle = false;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelRol.Location = new Point(92, 306);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(42, 26);
            labelRol.TabIndex = 30;
            labelRol.Text = "Rol";
            // 
            // roundedTextBoxPassword
            // 
            roundedTextBoxPassword.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxPassword.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxPassword.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxPassword.BorderRadius = 20;
            roundedTextBoxPassword.BorderSize = 3;
            roundedTextBoxPassword.Font = new Font("Nunito", 12F);
            roundedTextBoxPassword.Location = new Point(93, 245);
            roundedTextBoxPassword.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxPassword.Multiline = false;
            roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            roundedTextBoxPassword.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxPassword.PasswordChar = false;
            roundedTextBoxPassword.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxPassword.PlaceholderText = "";
            roundedTextBoxPassword.Size = new Size(334, 45);
            roundedTextBoxPassword.TabIndex = 29;
            roundedTextBoxPassword.Texts = "";
            roundedTextBoxPassword.UnderlinedStyle = false;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelPassword.Location = new Point(92, 213);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(110, 26);
            labelPassword.TabIndex = 28;
            labelPassword.Text = "Contraseña";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(228, 179, 99);
            buttonCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(289, 429);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(126, 50);
            buttonCancelar.TabIndex = 32;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCreateEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(530, 542);
            ControlBox = false;
            Controls.Add(buttonCancelar);
            Controls.Add(roundedTextBoxRol);
            Controls.Add(labelRol);
            Controls.Add(roundedTextBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(buttonAceptar);
            Controls.Add(roundedTextBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(roundedTextBoxUser);
            Controls.Add(labelUser);
            Name = "FormCreateEditUser";
            Text = "FormCreateEditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedTextBox roundedTextBoxUser;
        private Label labelUser;
        private Button buttonAceptar;
        private Controls.RoundedTextBox roundedTextBoxEmail;
        private Label labelEmail;
        private Controls.RoundedTextBox roundedTextBoxRol;
        private Label labelRol;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Label labelPassword;
        private Button buttonCancelar;
    }
}