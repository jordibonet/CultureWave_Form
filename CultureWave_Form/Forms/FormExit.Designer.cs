namespace CultureWave_Form.Forms
{
    partial class FormExit
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
            buttonExit = new Button();
            buttonLogOut = new Button();
            labeLExit = new Label();
            labelLogOut = new Label();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(228, 179, 99);
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(413, 338);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(126, 50);
            buttonExit.TabIndex = 34;
            buttonExit.Text = "Salir";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(228, 179, 99);
            buttonLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Nunito Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogOut.Location = new Point(413, 170);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(126, 50);
            buttonLogOut.TabIndex = 33;
            buttonLogOut.Text = "Cerrar Sesión";
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // labeLExit
            // 
            labeLExit.AutoSize = true;
            labeLExit.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labeLExit.Location = new Point(413, 294);
            labeLExit.Name = "labeLExit";
            labeLExit.Size = new Size(52, 26);
            labeLExit.TabIndex = 36;
            labeLExit.Text = "Salir";
            // 
            // labelLogOut
            // 
            labelLogOut.AutoSize = true;
            labelLogOut.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelLogOut.Location = new Point(413, 122);
            labelLogOut.Name = "labelLogOut";
            labelLogOut.Size = new Size(128, 26);
            labelLogOut.TabIndex = 35;
            labelLogOut.Text = "Cerrar Sesión";
            // 
            // FormExit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(labeLExit);
            Controls.Add(labelLogOut);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogOut);
            Name = "FormExit";
            Text = "FormExit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Button buttonLogOut;
        private Label labeLExit;
        private Label labelLogOut;
    }
}