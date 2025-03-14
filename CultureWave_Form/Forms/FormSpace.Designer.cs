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
            buttonReserve = new Button();
            buttonCreate = new Button();
            buttonEdit = new Button();
            labelNameSpaces = new Label();
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
            // buttonReserve
            // 
            buttonReserve.BackColor = Color.FromArgb(228, 179, 99);
            buttonReserve.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReserve.FlatAppearance.BorderSize = 0;
            buttonReserve.FlatStyle = FlatStyle.Flat;
            buttonReserve.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReserve.Location = new Point(782, 12);
            buttonReserve.Name = "buttonReserve";
            buttonReserve.Size = new Size(126, 50);
            buttonReserve.TabIndex = 13;
            buttonReserve.Text = "Resrvar";
            buttonReserve.UseVisualStyleBackColor = false;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(228, 179, 99);
            buttonCreate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCreate.Location = new Point(598, 12);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(126, 50);
            buttonCreate.TabIndex = 12;
            buttonCreate.Text = "Crear";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(228, 179, 99);
            buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(415, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(126, 50);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Modificar";
            buttonEdit.UseVisualStyleBackColor = false;
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
            // FormSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(labelNameSpaces);
            Controls.Add(dataGridViewSpaces);
            Controls.Add(buttonReserve);
            Controls.Add(buttonCreate);
            Controls.Add(buttonEdit);
            Name = "FormSpace";
            Text = "FormSpace";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSpaces;
        private Button buttonReserve;
        private Button buttonCreate;
        private Button buttonEdit;
        private Label labelNameSpaces;
    }
}