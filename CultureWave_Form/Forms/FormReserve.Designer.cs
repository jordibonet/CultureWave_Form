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
            buttonEdit = new Button();
            buttonCreate = new Button();
            buttonReserve = new Button();
            dataGridViewReserves = new DataGridView();
            labelNameReserves = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserves).BeginInit();
            SuspendLayout();
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
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Modificar";
            buttonEdit.UseVisualStyleBackColor = false;
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
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Crear";
            buttonCreate.UseVisualStyleBackColor = false;
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
            buttonReserve.TabIndex = 9;
            buttonReserve.Text = "Resrvar";
            buttonReserve.UseVisualStyleBackColor = false;
            // 
            // dataGridViewReserves
            // 
            dataGridViewReserves.BackgroundColor = Color.FromArgb(255, 248, 241);
            dataGridViewReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReserves.Location = new Point(12, 76);
            dataGridViewReserves.Name = "dataGridViewReserves";
            dataGridViewReserves.Size = new Size(992, 477);
            dataGridViewReserves.TabIndex = 10;
            // 
            // labelNameReserves
            // 
            labelNameReserves.AutoSize = true;
            labelNameReserves.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelNameReserves.Location = new Point(23, 37);
            labelNameReserves.Name = "labelNameReserves";
            labelNameReserves.Size = new Size(91, 26);
            labelNameReserves.TabIndex = 11;
            labelNameReserves.Text = "Reservas";
            // 
            // FormReserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(labelNameReserves);
            Controls.Add(dataGridViewReserves);
            Controls.Add(buttonReserve);
            Controls.Add(buttonCreate);
            Controls.Add(buttonEdit);
            Name = "FormReserve";
            Text = "FormReserve";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserves).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private Button buttonCreate;
        private Button buttonReserve;
        private DataGridView dataGridViewReserves;
        private Label labelNameReserves;
    }
}