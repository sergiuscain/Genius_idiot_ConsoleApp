namespace GeniusIdiot_WinForms
{
    partial class ShowQuestions
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
            ResultsGridView = new DataGridView();
            Question = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            AddQuestion = new Button();
            yourQuestionTextBox = new TextBox();
            yourAnswerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            delQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ResultsGridView).BeginInit();
            SuspendLayout();
            // 
            // ResultsGridView
            // 
            ResultsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsGridView.Columns.AddRange(new DataGridViewColumn[] { Question, Answer });
            ResultsGridView.Location = new Point(16, 6);
            ResultsGridView.Name = "ResultsGridView";
            ResultsGridView.Size = new Size(728, 432);
            ResultsGridView.TabIndex = 0;
            // 
            // Question
            // 
            Question.HeaderText = "Вопрос";
            Question.Name = "Question";
            // 
            // Answer
            // 
            Answer.HeaderText = "Ответ";
            Answer.Name = "Answer";
            // 
            // AddQuestion
            // 
            AddQuestion.BackColor = SystemColors.GradientInactiveCaption;
            AddQuestion.BackgroundImageLayout = ImageLayout.Center;
            AddQuestion.FlatStyle = FlatStyle.Flat;
            AddQuestion.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            AddQuestion.Location = new Point(702, 9);
            AddQuestion.Name = "AddQuestion";
            AddQuestion.Size = new Size(42, 41);
            AddQuestion.TabIndex = 1;
            AddQuestion.Text = "+";
            AddQuestion.TextImageRelation = TextImageRelation.ImageAboveText;
            AddQuestion.UseVisualStyleBackColor = false;
            AddQuestion.Click += AddQuestion_Click;
            // 
            // yourQuestionTextBox
            // 
            yourQuestionTextBox.Location = new Point(395, 27);
            yourQuestionTextBox.Multiline = true;
            yourQuestionTextBox.Name = "yourQuestionTextBox";
            yourQuestionTextBox.Size = new Size(195, 49);
            yourQuestionTextBox.TabIndex = 2;
            // 
            // yourAnswerTextBox
            // 
            yourAnswerTextBox.BackColor = SystemColors.InactiveCaption;
            yourAnswerTextBox.Location = new Point(596, 43);
            yourAnswerTextBox.Name = "yourAnswerTextBox";
            yourAnswerTextBox.Size = new Size(100, 23);
            yourAnswerTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(395, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Вопрос";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(596, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Ответ";
            // 
            // delQuestionButton
            // 
            delQuestionButton.BackColor = Color.FromArgb(255, 192, 192);
            delQuestionButton.FlatStyle = FlatStyle.Flat;
            delQuestionButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            delQuestionButton.Location = new Point(702, 56);
            delQuestionButton.Name = "delQuestionButton";
            delQuestionButton.Size = new Size(42, 42);
            delQuestionButton.TabIndex = 6;
            delQuestionButton.Text = "-";
            delQuestionButton.UseVisualStyleBackColor = false;
            delQuestionButton.Click += delQuestionButton_Click;
            // 
            // ShowQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(760, 448);
            Controls.Add(delQuestionButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yourAnswerTextBox);
            Controls.Add(yourQuestionTextBox);
            Controls.Add(AddQuestion);
            Controls.Add(ResultsGridView);
            Name = "ShowQuestions";
            Text = "ShowQuestions";
            Load += ShowQuestions_Load;
            ((System.ComponentModel.ISupportInitialize)ResultsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView ResultsGridView;
        public DataGridViewTextBoxColumn Question;
        public DataGridViewTextBoxColumn Answer;
        private Button AddQuestion;
        private TextBox yourQuestionTextBox;
        private TextBox yourAnswerTextBox;
        private Label label1;
        private Label label2;
        private Button delQuestionButton;
    }
}