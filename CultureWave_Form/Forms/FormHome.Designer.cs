namespace CultureWave_Form.Forms
{
    partial class FormHome
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
            labelActiveEvents = new Label();
            labelRecentReservations = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // labelActiveEvents
            // 
            labelActiveEvents.AutoSize = true;
            labelActiveEvents.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelActiveEvents.Location = new Point(12, 18);
            labelActiveEvents.Name = "labelActiveEvents";
            labelActiveEvents.Size = new Size(190, 26);
            labelActiveEvents.TabIndex = 2;
            labelActiveEvents.Text = "EVENTOS ACTIVOS";
            // 
            // labelRecentReservations
            // 
            labelRecentReservations.AutoSize = true;
            labelRecentReservations.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelRecentReservations.Location = new Point(12, 294);
            labelRecentReservations.Name = "labelRecentReservations";
            labelRecentReservations.Size = new Size(218, 26);
            labelRecentReservations.TabIndex = 3;
            labelRecentReservations.Text = "RESERVAS RECIENTES";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 248, 241);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(992, 225);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(255, 248, 241);
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 328);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(992, 225);
            dataGridView2.TabIndex = 5;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(labelRecentReservations);
            Controls.Add(labelActiveEvents);
            Name = "FormHome";
            Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelActiveEvents;
        private Label labelRecentReservations;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}