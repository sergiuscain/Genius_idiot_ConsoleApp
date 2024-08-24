namespace _2048
{
    partial class MainMenu_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            play_Button = new Button();
            showTableOfRecords_Button = new Button();
            exit_Button = new Button();
            label1 = new Label();
            name_textBox = new TextBox();
            SuspendLayout();
            // 
            // play_Button
            // 
            play_Button.BackgroundImageLayout = ImageLayout.Center;
            play_Button.FlatStyle = FlatStyle.Flat;
            play_Button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            play_Button.Location = new Point(12, 12);
            play_Button.Name = "play_Button";
            play_Button.Size = new Size(146, 67);
            play_Button.TabIndex = 0;
            play_Button.Text = "Play";
            play_Button.UseVisualStyleBackColor = true;
            play_Button.Click += play_Button_Click;
            // 
            // showTableOfRecords_Button
            // 
            showTableOfRecords_Button.FlatStyle = FlatStyle.Flat;
            showTableOfRecords_Button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            showTableOfRecords_Button.Location = new Point(285, 12);
            showTableOfRecords_Button.Name = "showTableOfRecords_Button";
            showTableOfRecords_Button.Size = new Size(152, 67);
            showTableOfRecords_Button.TabIndex = 1;
            showTableOfRecords_Button.Text = "Records";
            showTableOfRecords_Button.UseVisualStyleBackColor = true;
            showTableOfRecords_Button.Click += showTableOfRecords_Button_Click;
            // 
            // exit_Button
            // 
            exit_Button.FlatStyle = FlatStyle.Popup;
            exit_Button.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            exit_Button.Location = new Point(12, 97);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(75, 39);
            exit_Button.TabIndex = 2;
            exit_Button.Text = "Exit";
            exit_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(164, 12);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 3;
            label1.Text = "Enter name:";
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(164, 40);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(100, 23);
            name_textBox.TabIndex = 4;
            // 
            // MainMenu_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(457, 148);
            Controls.Add(name_textBox);
            Controls.Add(label1);
            Controls.Add(exit_Button);
            Controls.Add(showTableOfRecords_Button);
            Controls.Add(play_Button);
            Name = "MainMenu_Form";
            Text = "2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button play_Button;
        private Button showTableOfRecords_Button;
        private Button exit_Button;
        private Label label1;
        private TextBox name_textBox;
    }
}
