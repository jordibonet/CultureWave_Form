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
            buttonDeleteReserve = new Button();
            buttonReserve = new Button();
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
            // buttonDeleteReserve
            // 
            buttonDeleteReserve.BackColor = Color.FromArgb(228, 179, 99);
            buttonDeleteReserve.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDeleteReserve.FlatAppearance.BorderSize = 0;
            buttonDeleteReserve.FlatStyle = FlatStyle.Flat;
            buttonDeleteReserve.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteReserve.Location = new Point(791, 39);
            buttonDeleteReserve.Name = "buttonDeleteReserve";
            buttonDeleteReserve.Size = new Size(126, 50);
            buttonDeleteReserve.TabIndex = 22;
            buttonDeleteReserve.Text = "Eliminar Reserva";
            buttonDeleteReserve.UseVisualStyleBackColor = false;
            // 
            // buttonReserve
            // 
            buttonReserve.BackColor = Color.FromArgb(228, 179, 99);
            buttonReserve.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReserve.FlatAppearance.BorderSize = 0;
            buttonReserve.FlatStyle = FlatStyle.Flat;
            buttonReserve.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReserve.Location = new Point(556, 39);
            buttonReserve.Name = "buttonReserve";
            buttonReserve.Size = new Size(126, 50);
            buttonReserve.TabIndex = 21;
            buttonReserve.Text = "Resevar";
            buttonReserve.UseVisualStyleBackColor = false;
            // 
            // FormReserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(buttonDeleteReserve);
            Controls.Add(buttonReserve);
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
        private Button buttonDeleteReserve;
        private Button buttonReserve;
    }
}