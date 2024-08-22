namespace GeniusIdiot_WinForms
{
    partial class PlayForm
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
            BackButton = new Button();
            textQuestLabel = new Label();
            userAnswerTextBox = new TextBox();
            nextQuestion = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ActiveCaption;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(713, 334);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // textQuestLabel
            // 
            textQuestLabel.AutoSize = true;
            textQuestLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            textQuestLabel.Location = new Point(8, 22);
            textQuestLabel.Name = "textQuestLabel";
            textQuestLabel.Size = new Size(38, 15);
            textQuestLabel.TabIndex = 1;
            textQuestLabel.Text = "label1";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(8, 63);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(413, 23);
            userAnswerTextBox.TabIndex = 2;
            // 
            // nextQuestion
            // 
            nextQuestion.FlatStyle = FlatStyle.Flat;
            nextQuestion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextQuestion.Location = new Point(331, 97);
            nextQuestion.Name = "nextQuestion";
            nextQuestion.Size = new Size(90, 27);
            nextQuestion.TabIndex = 3;
            nextQuestion.Text = "Далее";
            nextQuestion.UseVisualStyleBackColor = true;
            nextQuestion.Click += nextQuestion_Click;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(853, 370);
            Controls.Add(nextQuestion);
            Controls.Add(userAnswerTextBox);
            Controls.Add(textQuestLabel);
            Controls.Add(BackButton);
            Name = "PlayForm";
            Text = "PlayForm";
            Load += PlayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label textQuestLabel;
        private TextBox userAnswerTextBox;
        private Button nextQuestion;
    }
}