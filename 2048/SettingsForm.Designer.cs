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
            saveSettings_Button = new Button();
            mapSize_Label = new Label();
            blockSize_Label = new Label();
            mapSize_TextBox = new TextBox();
            blockSize_TextBox = new TextBox();
            reSet_Button = new Button();
            SuspendLayout();
            // 
            // saveSettings_Button
            // 
            saveSettings_Button.FlatStyle = FlatStyle.Flat;
            saveSettings_Button.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveSettings_Button.Location = new Point(241, 227);
            saveSettings_Button.Name = "saveSettings_Button";
            saveSettings_Button.Size = new Size(112, 57);
            saveSettings_Button.TabIndex = 0;
            saveSettings_Button.Text = "Save";
            saveSettings_Button.UseVisualStyleBackColor = true;
            saveSettings_Button.Click += saveSettings_Button_Click;
            // 
            // mapSize_Label
            // 
            mapSize_Label.AutoSize = true;
            mapSize_Label.Location = new Point(11, 16);
            mapSize_Label.Name = "mapSize_Label";
            mapSize_Label.Size = new Size(54, 15);
            mapSize_Label.TabIndex = 1;
            mapSize_Label.Text = "mapSize:";
            // 
            // blockSize_Label
            // 
            blockSize_Label.AutoSize = true;
            blockSize_Label.Location = new Point(104, 16);
            blockSize_Label.Name = "blockSize_Label";
            blockSize_Label.Size = new Size(59, 15);
            blockSize_Label.TabIndex = 2;
            blockSize_Label.Text = "blockSize:";
            // 
            // mapSize_TextBox
            // 
            mapSize_TextBox.Location = new Point(11, 34);
            mapSize_TextBox.Name = "mapSize_TextBox";
            mapSize_TextBox.Size = new Size(54, 23);
            mapSize_TextBox.TabIndex = 3;
            // 
            // blockSize_TextBox
            // 
            blockSize_TextBox.Location = new Point(104, 34);
            blockSize_TextBox.Name = "blockSize_TextBox";
            blockSize_TextBox.Size = new Size(59, 23);
            blockSize_TextBox.TabIndex = 4;
            // 
            // reSet_Button
            // 
            reSet_Button.FlatStyle = FlatStyle.Flat;
            reSet_Button.Location = new Point(11, 261);
            reSet_Button.Name = "reSet_Button";
            reSet_Button.Size = new Size(99, 23);
            reSet_Button.TabIndex = 5;
            reSet_Button.Text = "Record ReSet";
            reSet_Button.UseVisualStyleBackColor = true;
            reSet_Button.Click += reSet_Button_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(369, 304);
            Controls.Add(reSet_Button);
            Controls.Add(blockSize_TextBox);
            Controls.Add(mapSize_TextBox);
            Controls.Add(blockSize_Label);
            Controls.Add(mapSize_Label);
            Controls.Add(saveSettings_Button);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveSettings_Button;
        private Label mapSize_Label;
        private Label blockSize_Label;
        private TextBox mapSize_TextBox;
        private TextBox blockSize_TextBox;
        private Button reSet_Button;
    }
}