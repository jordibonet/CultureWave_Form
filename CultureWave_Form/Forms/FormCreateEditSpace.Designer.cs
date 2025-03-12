namespace CultureWave_Form.Forms
{
    partial class FormCreateEditSpace
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
            roundedTextBoxNameEvent = new CultureWave_Form.Controls.RoundedTextBox();
            labelNameSpace = new Label();
            roundedTextBoxMeters = new CultureWave_Form.Controls.RoundedTextBox();
            labelMeters = new Label();
            roundedRadioButtonYes = new CultureWave_Form.Controls.RoundedRadioButton();
            roundedRadioButtonNo = new CultureWave_Form.Controls.RoundedRadioButton();
            SuspendLayout();
            // 
            // roundedTextBoxNameEvent
            // 
            roundedTextBoxNameEvent.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxNameEvent.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxNameEvent.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxNameEvent.BorderRadius = 20;
            roundedTextBoxNameEvent.BorderSize = 3;
            roundedTextBoxNameEvent.Font = new Font("Nunito", 12F);
            roundedTextBoxNameEvent.Location = new Point(45, 69);
            roundedTextBoxNameEvent.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxNameEvent.Multiline = false;
            roundedTextBoxNameEvent.Name = "roundedTextBoxNameEvent";
            roundedTextBoxNameEvent.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxNameEvent.PasswordChar = false;
            roundedTextBoxNameEvent.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxNameEvent.PlaceholderText = "";
            roundedTextBoxNameEvent.Size = new Size(404, 45);
            roundedTextBoxNameEvent.TabIndex = 16;
            roundedTextBoxNameEvent.Texts = "";
            roundedTextBoxNameEvent.UnderlinedStyle = false;
            // 
            // labelNameSpace
            // 
            labelNameSpace.AutoSize = true;
            labelNameSpace.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelNameSpace.Location = new Point(44, 30);
            labelNameSpace.Name = "labelNameSpace";
            labelNameSpace.Size = new Size(146, 26);
            labelNameSpace.TabIndex = 15;
            labelNameSpace.Text = "Nombre evento";
            // 
            // roundedTextBoxMeters
            // 
            roundedTextBoxMeters.BackColor = Color.FromArgb(255, 248, 241);
            roundedTextBoxMeters.BorderColor = Color.FromArgb(172, 93, 51);
            roundedTextBoxMeters.BorderFocusColor = Color.FromArgb(228, 179, 99);
            roundedTextBoxMeters.BorderRadius = 20;
            roundedTextBoxMeters.BorderSize = 3;
            roundedTextBoxMeters.Font = new Font("Nunito", 12F);
            roundedTextBoxMeters.Location = new Point(45, 171);
            roundedTextBoxMeters.Margin = new Padding(5, 6, 5, 6);
            roundedTextBoxMeters.Multiline = false;
            roundedTextBoxMeters.Name = "roundedTextBoxMeters";
            roundedTextBoxMeters.Padding = new Padding(9, 11, 9, 11);
            roundedTextBoxMeters.PasswordChar = false;
            roundedTextBoxMeters.PlaceholderColor = Color.FromArgb(18, 18, 18);
            roundedTextBoxMeters.PlaceholderText = "";
            roundedTextBoxMeters.Size = new Size(404, 45);
            roundedTextBoxMeters.TabIndex = 18;
            roundedTextBoxMeters.Texts = "";
            roundedTextBoxMeters.UnderlinedStyle = false;
            // 
            // labelMeters
            // 
            labelMeters.AutoSize = true;
            labelMeters.Font = new Font("Nunito", 14F, FontStyle.Bold);
            labelMeters.Location = new Point(44, 132);
            labelMeters.Name = "labelMeters";
            labelMeters.Size = new Size(166, 26);
            labelMeters.TabIndex = 17;
            labelMeters.Text = "Metros cuadrados";
            // 
            // roundedRadioButtonYes
            // 
            roundedRadioButtonYes.AutoSize = true;
            roundedRadioButtonYes.CheckedColor = Color.FromArgb(172, 93, 51);
            roundedRadioButtonYes.Font = new Font("Nunito", 14F, FontStyle.Bold);
            roundedRadioButtonYes.Location = new Point(537, 76);
            roundedRadioButtonYes.MinimumSize = new Size(0, 21);
            roundedRadioButtonYes.Name = "roundedRadioButtonYes";
            roundedRadioButtonYes.Padding = new Padding(10, 0, 0, 0);
            roundedRadioButtonYes.Size = new Size(70, 30);
            roundedRadioButtonYes.TabIndex = 20;
            roundedRadioButtonYes.TabStop = true;
            roundedRadioButtonYes.Text = "Yes";
            roundedRadioButtonYes.UnCheckedColor = Color.FromArgb(172, 93, 51);
            roundedRadioButtonYes.UseVisualStyleBackColor = true;
            // 
            // roundedRadioButtonNo
            // 
            roundedRadioButtonNo.AutoSize = true;
            roundedRadioButtonNo.CheckedColor = Color.FromArgb(172, 93, 51);
            roundedRadioButtonNo.Font = new Font("Nunito", 14F, FontStyle.Bold);
            roundedRadioButtonNo.Location = new Point(662, 76);
            roundedRadioButtonNo.MinimumSize = new Size(0, 21);
            roundedRadioButtonNo.Name = "roundedRadioButtonNo";
            roundedRadioButtonNo.Padding = new Padding(10, 0, 0, 0);
            roundedRadioButtonNo.Size = new Size(65, 30);
            roundedRadioButtonNo.TabIndex = 21;
            roundedRadioButtonNo.TabStop = true;
            roundedRadioButtonNo.Text = "No";
            roundedRadioButtonNo.UnCheckedColor = Color.FromArgb(172, 93, 51);
            roundedRadioButtonNo.UseVisualStyleBackColor = true;
            // 
            // FormCreateEditSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 565);
            Controls.Add(roundedRadioButtonNo);
            Controls.Add(roundedRadioButtonYes);
            Controls.Add(roundedTextBoxMeters);
            Controls.Add(labelMeters);
            Controls.Add(roundedTextBoxNameEvent);
            Controls.Add(labelNameSpace);
            Name = "FormCreateEditSpace";
            Text = "FormCreateEditSpace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedTextBox roundedTextBoxNameEvent;
        private Label labelNameSpace;
        private Controls.RoundedTextBox roundedTextBoxMeters;
        private Label labelMeters;
        private Controls.RoundedRadioButton roundedRadioButtonYes;
        private Controls.RoundedRadioButton roundedRadioButtonNo;
    }
}