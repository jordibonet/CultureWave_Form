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
            labeLExit = new Label();
            labelLogOut = new Label();
            roundedButtonExit = new CultureWave_Form.Controls.RoundedButton();
            roundedButtonLogOut = new CultureWave_Form.Controls.RoundedButton();
            SuspendLayout();
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
            // roundedButtonExit
            // 
            roundedButtonExit.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonExit.FlatAppearance.BorderSize = 0;
            roundedButtonExit.FlatStyle = FlatStyle.Flat;
            roundedButtonExit.Font = new Font("Nunito Medium", 10F);
            roundedButtonExit.ForeColor = Color.Black;
            roundedButtonExit.Location = new Point(413, 337);
            roundedButtonExit.Name = "roundedButtonExit";
            roundedButtonExit.Size = new Size(126, 60);
            roundedButtonExit.TabIndex = 37;
            roundedButtonExit.Text = "Salir";
            roundedButtonExit.UseVisualStyleBackColor = false;
            roundedButtonExit.Click += roundedButtonExit_Click;
            // 
            // roundedButtonLogOut
            // 
            roundedButtonLogOut.BackColor = Color.FromArgb(228, 179, 99);
            roundedButtonLogOut.FlatAppearance.BorderSize = 0;
            roundedButtonLogOut.FlatStyle = FlatStyle.Flat;
            roundedButtonLogOut.Font = new Font("Nunito Medium", 10F);
            roundedButtonLogOut.ForeColor = Color.Black;
            roundedButtonLogOut.Location = new Point(413, 166);
            roundedButtonLogOut.Name = "roundedButtonLogOut";
            roundedButtonLogOut.Size = new Size(126, 60);
            roundedButtonLogOut.TabIndex = 38;
            roundedButtonLogOut.Text = "Cerrar Sesión";
            roundedButtonLogOut.UseVisualStyleBackColor = false;
            // 
            // FormExit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(roundedButtonLogOut);
            Controls.Add(roundedButtonExit);
            Controls.Add(labeLExit);
            Controls.Add(labelLogOut);
            Name = "FormExit";
            Text = "FormExit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labeLExit;
        private Label labelLogOut;
        private Controls.RoundedButton roundedButtonExit;
        private Controls.RoundedButton roundedButtonLogOut;
    }
}