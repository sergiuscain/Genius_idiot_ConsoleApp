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
            AddQuestion.Location = new Point(702, 6);
            AddQuestion.Name = "AddQuestion";
            AddQuestion.Size = new Size(42, 41);
            AddQuestion.TabIndex = 1;
            AddQuestion.Text = "+";
            AddQuestion.TextImageRelation = TextImageRelation.ImageAboveText;
            AddQuestion.UseVisualStyleBackColor = false;
            AddQuestion.Click += AddQuestion_Click;
            // 
            // ShowQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddQuestion);
            Controls.Add(ResultsGridView);
            Name = "ShowQuestions";
            Text = "ShowQuestions";
            ((System.ComponentModel.ISupportInitialize)ResultsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView ResultsGridView;
        public DataGridViewTextBoxColumn Question;
        public DataGridViewTextBoxColumn Answer;
        private Button AddQuestion;
    }
}