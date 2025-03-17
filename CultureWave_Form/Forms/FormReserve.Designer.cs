namespace CultureWave_Form.Forms
{
    partial class FormReserve
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
            labelNameReserves = new Label();
            labelUser = new Label();
            dataGridViewSpaces = new DataGridView();
            roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            roundedButtonReserve = new CultureWave_Form.Controls.RoundedButton();
            roundedButtonDeleteReserve = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpaces).BeginInit();
            SuspendLayout();
            // 
            // labelNameReserves
            // 
            labelNameReserves.AutoSize = true;
            labelNameReserves.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelNameReserves.Location = new Point(12, 126);
            labelNameReserves.Name = "labelNameReserves";
            labelNameReserves.Size = new Size(91, 26);
            labelNameReserves.TabIndex = 16;
            labelNameReserves.Text = "Reservas";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelUser.Location = new Point(12, 18);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(79, 26);
            labelUser.TabIndex = 17;
            labelUser.Text = "Usuario";
            // 
            // dataGridViewSpaces
            // 
            dataGridViewSpaces.BackgroundColor = Color.FromArgb(255, 248, 241);
            dataGridViewSpaces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpaces.Location = new Point(12, 159);
            dataGridViewSpaces.Name = "dataGridViewSpaces";
            dataGridViewSpaces.Size = new Size(992, 394);
            dataGridViewSpaces.TabIndex = 18;
            // 
            // roundedTextBoxUser
            // 
            roundedTextBoxUser.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxUser.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxUser.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxUser.BorderRadius = 20;
            roundedTextBoxUser.BorderSize = 3;
            roundedTextBoxUser.Font = new Font("Nunito", 12F);
            roundedTextBoxUser.Location = new Point(13, 50);
            roundedTextBoxUser.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxUser.Multiline = false;
            roundedTextBoxUser.Name = "roundedTextBoxUser";
            roundedTextBoxUser.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxUser.PasswordChar = false;
            roundedTextBoxUser.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxUser.PlaceholderText = "";
            roundedTextBoxUser.Size = new Size(298, 45);
            roundedTextBoxUser.TabIndex = 20;
            roundedTextBoxUser.Texts = "";
            roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // roundedButtonReserve
            // 
            roundedButtonReserve.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonReserve.FlatAppearance.BorderSize = 0;
            roundedButtonReserve.FlatStyle = FlatStyle.Flat;
            roundedButtonReserve.Font = new Font("Nunito Medium", 10F);
            roundedButtonReserve.ForeColor = Color.Black;
            roundedButtonReserve.Location = new Point(555, 34);
            roundedButtonReserve.Name = "roundedButtonReserve";
            roundedButtonReserve.Size = new Size(126, 60);
            roundedButtonReserve.TabIndex = 39;
            roundedButtonReserve.Text = "Reservar";
            roundedButtonReserve.UseVisualStyleBackColor = false;
            // 
            // roundedButtonDeleteReserve
            // 
            roundedButtonDeleteReserve.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonDeleteReserve.FlatAppearance.BorderSize = 0;
            roundedButtonDeleteReserve.FlatStyle = FlatStyle.Flat;
            roundedButtonDeleteReserve.Font = new Font("Nunito Medium", 10F);
            roundedButtonDeleteReserve.ForeColor = Color.Black;
            roundedButtonDeleteReserve.Location = new Point(789, 35);
            roundedButtonDeleteReserve.Name = "roundedButtonDeleteReserve";
            roundedButtonDeleteReserve.Size = new Size(126, 60);
            roundedButtonDeleteReserve.TabIndex = 40;
            roundedButtonDeleteReserve.Text = "Eliminar Reserva";
            roundedButtonDeleteReserve.UseVisualStyleBackColor = false;
            // 
            // FormReserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(roundedButtonDeleteReserve);
            Controls.Add(roundedButtonReserve);
            Controls.Add(roundedTextBoxUser);
            Controls.Add(dataGridViewSpaces);
            Controls.Add(labelUser);
            Controls.Add(labelNameReserves);
            Name = "FormReserve";
            Text = "FormReserve";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameReserves;
        private Label labelUser;
        private DataGridView dataGridViewSpaces;
        private Controls.RoundedTextBox roundedTextBoxUser;
        private Controls.RoundedButton roundedButtonReserve;
        private Controls.RoundedButton roundedButtonDeleteReserve;
    }
}