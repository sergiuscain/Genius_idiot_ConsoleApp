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
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            CountRightAnswers = new DataGridViewTextBoxColumn();
            Diagnose = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, CountRightAnswers, Diagnose });
            dataGridView1.Location = new Point(1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 449);
            dataGridView1.TabIndex = 0;
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
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Text = "ResultsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn CountRightAnswers;
        private DataGridViewTextBoxColumn Diagnose;
    }
}