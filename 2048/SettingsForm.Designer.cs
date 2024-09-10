namespace _2048
{
    partial class SettingsForm
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
            reSet_Button = new Button();
            button3x3 = new Button();
            button4x4 = new Button();
            button5x5 = new Button();
            button6x6 = new Button();
            SuspendLayout();
            // 
            // reSet_Button
            // 
            reSet_Button.FlatStyle = FlatStyle.Flat;
            reSet_Button.Location = new Point(12, 160);
            reSet_Button.Name = "reSet_Button";
            reSet_Button.Size = new Size(99, 23);
            reSet_Button.TabIndex = 5;
            reSet_Button.Text = "Record ReSet";
            reSet_Button.UseVisualStyleBackColor = true;
            reSet_Button.Click += reSet_Button_Click;
            // 
            // button3x3
            // 
            button3x3.Location = new Point(12, 12);
            button3x3.Name = "button3x3";
            button3x3.Size = new Size(73, 68);
            button3x3.TabIndex = 6;
            button3x3.Text = "3X3";
            button3x3.UseVisualStyleBackColor = true;
            button3x3.Click += button3x3_Click;
            // 
            // button4x4
            // 
            button4x4.Location = new Point(91, 12);
            button4x4.Name = "button4x4";
            button4x4.Size = new Size(73, 68);
            button4x4.TabIndex = 7;
            button4x4.Text = "4X4";
            button4x4.UseVisualStyleBackColor = true;
            button4x4.Click += button4x4_Click;
            // 
            // button5x5
            // 
            button5x5.Location = new Point(12, 86);
            button5x5.Name = "button5x5";
            button5x5.Size = new Size(73, 68);
            button5x5.TabIndex = 8;
            button5x5.Text = "5X5";
            button5x5.UseVisualStyleBackColor = true;
            button5x5.Click += button5x5_Click;
            // 
            // button6x6
            // 
            button6x6.Location = new Point(91, 86);
            button6x6.Name = "button6x6";
            button6x6.Size = new Size(73, 68);
            button6x6.TabIndex = 9;
            button6x6.Text = "6X6";
            button6x6.UseVisualStyleBackColor = true;
            button6x6.Click += button6x6_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(209, 206);
            Controls.Add(button6x6);
            Controls.Add(button5x5);
            Controls.Add(button4x4);
            Controls.Add(button3x3);
            Controls.Add(reSet_Button);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
        }

        #endregion
        private Button reSet_Button;
        private Button button3x3;
        private Button button4x4;
        private Button button5x5;
        private Button button6x6;
    }
}