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
            buttonDelete = new Button();
            buttonCreate = new Button();
            buttonEdit = new Button();
            dataGridViewUsers = new DataGridView();
            labelNameUsers = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(228, 179, 99);
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(613, 22);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(126, 50);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(228, 179, 99);
            buttonCreate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCreate.Location = new Point(442, 22);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(126, 50);
            buttonCreate.TabIndex = 23;
            buttonCreate.Text = "Crear";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(228, 179, 99);
            buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(274, 22);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(126, 50);
            buttonEdit.TabIndex = 25;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = false;
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
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(dataGridViewUsers);
            Controls.Add(labelNameUsers);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Name = "FormUser";
            Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDelete;
        private Button buttonCreate;
        private Button buttonEdit;
        private DataGridView dataGridViewUsers;
        private Label labelNameUsers;
    }
}