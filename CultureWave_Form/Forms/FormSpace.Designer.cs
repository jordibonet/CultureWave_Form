namespace CultureWave_Form.Forms
{
    partial class FormSpace
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
            dataGridViewSpaces = new DataGridView();
            labelNameSpaces = new Label();
            roundedButtonEdit = new CultureWave_Form.Controls.RoundedButton();
            roundedButtonCreate = new CultureWave_Form.Controls.RoundedButton();
            roundedButtonReserve = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpaces).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSpaces
            // 
            dataGridViewSpaces.BackgroundColor = Color.FromArgb(255, 248, 241);
            dataGridViewSpaces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpaces.Location = new Point(12, 76);
            dataGridViewSpaces.Name = "dataGridViewSpaces";
            dataGridViewSpaces.Size = new Size(992, 477);
            dataGridViewSpaces.TabIndex = 14;
            // 
            // labelNameSpaces
            // 
            labelNameSpaces.AutoSize = true;
            labelNameSpaces.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelNameSpaces.Location = new Point(12, 47);
            labelNameSpaces.Name = "labelNameSpaces";
            labelNameSpaces.Size = new Size(87, 26);
            labelNameSpaces.TabIndex = 15;
            labelNameSpaces.Text = "Espacios";
            // 
            // roundedButtonEdit
            // 
            roundedButtonEdit.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonEdit.FlatAppearance.BorderSize = 0;
            roundedButtonEdit.FlatStyle = FlatStyle.Flat;
            roundedButtonEdit.Font = new Font("Nunito Medium", 10F);
            roundedButtonEdit.ForeColor = Color.Black;
            roundedButtonEdit.Location = new Point(417, 8);
            roundedButtonEdit.Name = "roundedButtonEdit";
            roundedButtonEdit.Size = new Size(126, 60);
            roundedButtonEdit.TabIndex = 40;
            roundedButtonEdit.Text = "Modificar";
            roundedButtonEdit.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCreate
            // 
            roundedButtonCreate.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonCreate.FlatAppearance.BorderSize = 0;
            roundedButtonCreate.FlatStyle = FlatStyle.Flat;
            roundedButtonCreate.Font = new Font("Nunito Medium", 10F);
            roundedButtonCreate.ForeColor = Color.Black;
            roundedButtonCreate.Location = new Point(600, 8);
            roundedButtonCreate.Name = "roundedButtonCreate";
            roundedButtonCreate.Size = new Size(126, 60);
            roundedButtonCreate.TabIndex = 41;
            roundedButtonCreate.Text = "Crear";
            roundedButtonCreate.UseVisualStyleBackColor = false;
            // 
            // roundedButtonReserve
            // 
            roundedButtonReserve.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonReserve.FlatAppearance.BorderSize = 0;
            roundedButtonReserve.FlatStyle = FlatStyle.Flat;
            roundedButtonReserve.Font = new Font("Nunito Medium", 10F);
            roundedButtonReserve.ForeColor = Color.Black;
            roundedButtonReserve.Location = new Point(782, 8);
            roundedButtonReserve.Name = "roundedButtonReserve";
            roundedButtonReserve.Size = new Size(126, 60);
            roundedButtonReserve.TabIndex = 42;
            roundedButtonReserve.Text = "Reservar";
            roundedButtonReserve.UseVisualStyleBackColor = false;
            // 
            // FormSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(roundedButtonReserve);
            Controls.Add(roundedButtonCreate);
            Controls.Add(roundedButtonEdit);
            Controls.Add(labelNameSpaces);
            Controls.Add(dataGridViewSpaces);
            Name = "FormSpace";
            Text = "FormSpace";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSpaces;
        private Label labelNameSpaces;
        private Controls.RoundedButton roundedButtonEdit;
        private Controls.RoundedButton roundedButtonCreate;
        private Controls.RoundedButton roundedButtonReserve;
    }
}