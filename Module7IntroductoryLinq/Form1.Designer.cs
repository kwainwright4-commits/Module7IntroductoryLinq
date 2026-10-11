namespace Module7IntroductoryLinq
{
    partial class Form1
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
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.NumericUpDown nudMinimumGpa;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnFilterProgram;
        private System.Windows.Forms.Button btnFilterGpa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortGpa;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblResults;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.nudMinimumGpa = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnFilterProgram = new System.Windows.Forms.Button();
            this.btnFilterGpa = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortGpa = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumGpa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 110);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(760, 300);
            this.dgvStudents.TabIndex = 0;
            // 
            // cboProgram
            // 
            this.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgram.FormattingEnabled = true;
            this.cboProgram.Location = new System.Drawing.Point(12, 12);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(220, 21);
            this.cboProgram.TabIndex = 1;
            // 
            // nudMinimumGpa
            // 
            this.nudMinimumGpa.DecimalPlaces = 2;
            this.nudMinimumGpa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinimumGpa.Location = new System.Drawing.Point(250, 12);
            this.nudMinimumGpa.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMinimumGpa.Name = "nudMinimumGpa";
            this.nudMinimumGpa.Size = new System.Drawing.Size(60, 20);
            this.nudMinimumGpa.TabIndex = 2;
            this.nudMinimumGpa.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(330, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 45);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(90, 30);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnFilterProgram
            // 
            this.btnFilterProgram.Location = new System.Drawing.Point(108, 45);
            this.btnFilterProgram.Name = "btnFilterProgram";
            this.btnFilterProgram.Size = new System.Drawing.Size(110, 30);
            this.btnFilterProgram.TabIndex = 5;
            this.btnFilterProgram.Text = "Filter Program";
            this.btnFilterProgram.UseVisualStyleBackColor = true;
            this.btnFilterProgram.Click += new System.EventHandler(this.btnFilterProgram_Click);
            // 
            // btnFilterGpa
            // 
            this.btnFilterGpa.Location = new System.Drawing.Point(224, 45);
            this.btnFilterGpa.Name = "btnFilterGpa";
            this.btnFilterGpa.Size = new System.Drawing.Size(90, 30);
            this.btnFilterGpa.TabIndex = 6;
            this.btnFilterGpa.Text = "Filter GPA";
            this.btnFilterGpa.UseVisualStyleBackColor = true;
            this.btnFilterGpa.Click += new System.EventHandler(this.btnFilterGpa_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(416, 45);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(110, 30);
            this.btnSortName.TabIndex = 8;
            this.btnSortName.Text = "Sort by Last Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortGpa
            // 
            this.btnSortGpa.Location = new System.Drawing.Point(532, 45);
            this.btnSortGpa.Name = "btnSortGpa";
            this.btnSortGpa.Size = new System.Drawing.Size(110, 30);
            this.btnSortGpa.TabIndex = 9;
            this.btnSortGpa.Text = "Sort by GPA";
            this.btnSortGpa.UseVisualStyleBackColor = true;
            this.btnSortGpa.Click += new System.EventHandler(this.btnSortGpa_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(648, 45);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(90, 30);
            this.btnSummary.TabIndex = 10;
            this.btnSummary.Text = "Display Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResults.Location = new System.Drawing.Point(12, 80);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(760, 23);
            this.lblResults.TabIndex = 11;
            this.lblResults.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnSortGpa);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFilterGpa);
            this.Controls.Add(this.btnFilterProgram);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.nudMinimumGpa);
            this.Controls.Add(this.cboProgram);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Student Records - LINQ Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumGpa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

