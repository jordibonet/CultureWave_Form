namespace CultureWave_Form.Forms
{
    partial class FormUser
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
            dataGridViewUsers = new DataGridView();
            labelNameUsers = new Label();
            roundedButtonDelete = new CultureWave_Form.Controls.RoundedButton();
            roundedButtonCreate = new CultureWave_Form.Controls.RoundedButton();
            roundedButtonEdit = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.FromArgb(255, 248, 241);
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 99);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(992, 454);
            dataGridViewUsers.TabIndex = 27;
            // 
            // labelNameUsers
            // 
            labelNameUsers.AutoSize = true;
            labelNameUsers.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelNameUsers.Location = new Point(12, 66);
            labelNameUsers.Name = "labelNameUsers";
            labelNameUsers.Size = new Size(88, 26);
            labelNameUsers.TabIndex = 26;
            labelNameUsers.Text = "Usuarios";
            // 
            // roundedButtonDelete
            // 
            roundedButtonDelete.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonDelete.FlatAppearance.BorderSize = 0;
            roundedButtonDelete.FlatStyle = FlatStyle.Flat;
            roundedButtonDelete.Font = new Font("Nunito Medium", 10F);
            roundedButtonDelete.ForeColor = Color.Black;
            roundedButtonDelete.Location = new Point(624, 19);
            roundedButtonDelete.Name = "roundedButtonDelete";
            roundedButtonDelete.Size = new Size(126, 60);
            roundedButtonDelete.TabIndex = 45;
            roundedButtonDelete.Text = "Eliminar";
            roundedButtonDelete.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCreate
            // 
            roundedButtonCreate.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonCreate.FlatAppearance.BorderSize = 0;
            roundedButtonCreate.FlatStyle = FlatStyle.Flat;
            roundedButtonCreate.Font = new Font("Nunito Medium", 10F);
            roundedButtonCreate.ForeColor = Color.Black;
            roundedButtonCreate.Location = new Point(442, 19);
            roundedButtonCreate.Name = "roundedButtonCreate";
            roundedButtonCreate.Size = new Size(126, 60);
            roundedButtonCreate.TabIndex = 44;
            roundedButtonCreate.Text = "Crear";
            roundedButtonCreate.UseVisualStyleBackColor = false;
            roundedButtonCreate.Click += roundedButtonCreate_Click;
            // 
            // roundedButtonEdit
            // 
            roundedButtonEdit.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonEdit.FlatAppearance.BorderSize = 0;
            roundedButtonEdit.FlatStyle = FlatStyle.Flat;
            roundedButtonEdit.Font = new Font("Nunito Medium", 10F);
            roundedButtonEdit.ForeColor = Color.Black;
            roundedButtonEdit.Location = new Point(259, 19);
            roundedButtonEdit.Name = "roundedButtonEdit";
            roundedButtonEdit.Size = new Size(126, 60);
            roundedButtonEdit.TabIndex = 43;
            roundedButtonEdit.Text = "Modificar";
            roundedButtonEdit.UseVisualStyleBackColor = false;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(roundedButtonDelete);
            Controls.Add(roundedButtonCreate);
            Controls.Add(roundedButtonEdit);
            Controls.Add(dataGridViewUsers);
            Controls.Add(labelNameUsers);
            Name = "FormUser";
            Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewUsers;
        private Label labelNameUsers;
        private Controls.RoundedButton roundedButtonDelete;
        private Controls.RoundedButton roundedButtonCreate;
        private Controls.RoundedButton roundedButtonEdit;
    }
}