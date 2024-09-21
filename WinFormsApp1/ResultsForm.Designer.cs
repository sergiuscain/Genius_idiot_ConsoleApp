namespace GeniusIdiot_WinForms
{
    partial class ResultsForm
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
            resultsGridView = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            CountRightAnswers = new DataGridViewTextBoxColumn();
            Diagnose = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsGridView
            // 
            resultsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsGridView.Columns.AddRange(new DataGridViewColumn[] { Name, CountRightAnswers, Diagnose });
            resultsGridView.Location = new Point(1, 1);
            resultsGridView.Name = "resultsGridView";
            resultsGridView.Size = new Size(343, 449);
            resultsGridView.TabIndex = 0;
            resultsGridView.CellContentClick += resultsGridView_CellContentClick;
            // 
            // Name
            // 
            Name.HeaderText = "Имя";
            Name.Name = "Name";
            // 
            // CountRightAnswers
            // 
            CountRightAnswers.HeaderText = "Кол-во правильных ответов";
            CountRightAnswers.Name = "CountRightAnswers";
            // 
            // Diagnose
            // 
            Diagnose.HeaderText = "Диагноз";
            Diagnose.Name = "Diagnose";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(343, 447);
            Controls.Add(resultsGridView);
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsGridView;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn CountRightAnswers;
        private DataGridViewTextBoxColumn Diagnose;
    }
}