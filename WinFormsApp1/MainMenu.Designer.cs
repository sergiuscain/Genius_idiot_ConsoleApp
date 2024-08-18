namespace WinFormsApp1
{
    partial class MainMenuForm
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
            PlayButton = new Button();
            ShowResultsButton = new Button();
            ShowQuestionsButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.FlatStyle = FlatStyle.Flat;
            PlayButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            PlayButton.ForeColor = SystemColors.ActiveCaptionText;
            PlayButton.Location = new Point(12, 12);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(265, 101);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Начать игру";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // ShowResultsButton
            // 
            ShowResultsButton.FlatStyle = FlatStyle.Flat;
            ShowResultsButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            ShowResultsButton.ForeColor = SystemColors.ActiveCaptionText;
            ShowResultsButton.Location = new Point(12, 130);
            ShowResultsButton.Name = "ShowResultsButton";
            ShowResultsButton.Size = new Size(265, 101);
            ShowResultsButton.TabIndex = 1;
            ShowResultsButton.Text = "Показать рузультаты";
            ShowResultsButton.UseVisualStyleBackColor = true;
            ShowResultsButton.Click += ShowResultsButton_Click;
            // 
            // ShowQuestionsButton
            // 
            ShowQuestionsButton.FlatStyle = FlatStyle.Flat;
            ShowQuestionsButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            ShowQuestionsButton.ForeColor = SystemColors.ActiveCaptionText;
            ShowQuestionsButton.Location = new Point(12, 247);
            ShowQuestionsButton.Name = "ShowQuestionsButton";
            ShowQuestionsButton.Size = new Size(265, 101);
            ShowQuestionsButton.TabIndex = 2;
            ShowQuestionsButton.Text = "Список вопросов";
            ShowQuestionsButton.UseVisualStyleBackColor = true;
            ShowQuestionsButton.Click += ShowQuestionsButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            ExitButton.ForeColor = SystemColors.ControlText;
            ExitButton.Location = new Point(12, 373);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(265, 101);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1331, 601);
            Controls.Add(ExitButton);
            Controls.Add(ShowQuestionsButton);
            Controls.Add(ShowResultsButton);
            Controls.Add(PlayButton);
            Name = "MainMenuForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button PlayButton;
        private Button ShowResultsButton;
        private Button ShowQuestionsButton;
        private Button ExitButton;
    }
}
