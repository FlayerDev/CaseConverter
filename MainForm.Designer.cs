namespace CaseConverter
{
    partial class MainForm
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
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CapitalizedCase = new System.Windows.Forms.Button();
            this.LowerCaseButton = new System.Windows.Forms.Button();
            this.SentenceCase = new System.Windows.Forms.Button();
            this.TitleCase = new System.Windows.Forms.Button();
            this.AlternatingCase = new System.Windows.Forms.Button();
            this.InverseCase = new System.Windows.Forms.Button();
            this.UpperCaseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextBox.Location = new System.Drawing.Point(0, 64);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MainTextBox.Size = new System.Drawing.Size(752, 378);
            this.MainTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Controls.Add(this.UpperCaseButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InverseCase, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlternatingCase, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.TitleCase, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.SentenceCase, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LowerCaseButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CapitalizedCase, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 64);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // CapitalizedCase
            // 
            this.CapitalizedCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CapitalizedCase.Location = new System.Drawing.Point(213, 3);
            this.CapitalizedCase.Name = "CapitalizedCase";
            this.CapitalizedCase.Size = new System.Drawing.Size(99, 26);
            this.CapitalizedCase.TabIndex = 3;
            this.CapitalizedCase.Text = "Capitalized Case";
            this.CapitalizedCase.UseVisualStyleBackColor = true;
            this.CapitalizedCase.Click += new System.EventHandler(this.CapitalizedCase_Click);
            // 
            // LowerCaseButton
            // 
            this.LowerCaseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerCaseButton.Location = new System.Drawing.Point(108, 3);
            this.LowerCaseButton.Name = "LowerCaseButton";
            this.LowerCaseButton.Size = new System.Drawing.Size(99, 26);
            this.LowerCaseButton.TabIndex = 2;
            this.LowerCaseButton.Text = "lower case";
            this.LowerCaseButton.UseVisualStyleBackColor = true;
            this.LowerCaseButton.Click += new System.EventHandler(this.LowerCaseButton_Click);
            // 
            // SentenceCase
            // 
            this.SentenceCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SentenceCase.Location = new System.Drawing.Point(318, 3);
            this.SentenceCase.Name = "SentenceCase";
            this.SentenceCase.Size = new System.Drawing.Size(99, 26);
            this.SentenceCase.TabIndex = 4;
            this.SentenceCase.Text = "Sentence Case";
            this.SentenceCase.UseVisualStyleBackColor = true;
            this.SentenceCase.Click += new System.EventHandler(this.SentenceCase_Click);
            // 
            // TitleCase
            // 
            this.TitleCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleCase.Location = new System.Drawing.Point(423, 3);
            this.TitleCase.Name = "TitleCase";
            this.TitleCase.Size = new System.Drawing.Size(99, 26);
            this.TitleCase.TabIndex = 5;
            this.TitleCase.Text = "Title Case";
            this.TitleCase.UseVisualStyleBackColor = true;
            this.TitleCase.Click += new System.EventHandler(this.TitleCase_Click);
            // 
            // AlternatingCase
            // 
            this.AlternatingCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlternatingCase.Location = new System.Drawing.Point(528, 3);
            this.AlternatingCase.Name = "AlternatingCase";
            this.AlternatingCase.Size = new System.Drawing.Size(114, 26);
            this.AlternatingCase.TabIndex = 6;
            this.AlternatingCase.Text = "AlTeRnAtInG CaSe";
            this.AlternatingCase.UseVisualStyleBackColor = true;
            this.AlternatingCase.Click += new System.EventHandler(this.AlternatingCase_Click);
            // 
            // InverseCase
            // 
            this.InverseCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InverseCase.Location = new System.Drawing.Point(648, 3);
            this.InverseCase.Name = "InverseCase";
            this.InverseCase.Size = new System.Drawing.Size(101, 26);
            this.InverseCase.TabIndex = 7;
            this.InverseCase.Text = "iNVERSE cASE";
            this.InverseCase.UseVisualStyleBackColor = true;
            this.InverseCase.Click += new System.EventHandler(this.InverseCase_Click);
            // 
            // UpperCaseButton
            // 
            this.UpperCaseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperCaseButton.Location = new System.Drawing.Point(3, 3);
            this.UpperCaseButton.Name = "UpperCaseButton";
            this.UpperCaseButton.Size = new System.Drawing.Size(99, 26);
            this.UpperCaseButton.TabIndex = 1;
            this.UpperCaseButton.Text = "UPPER CASE";
            this.UpperCaseButton.UseVisualStyleBackColor = true;
            this.UpperCaseButton.Click += new System.EventHandler(this.UpperCaseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 442);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(760, 400);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button UpperCaseButton;
        private System.Windows.Forms.Button InverseCase;
        private System.Windows.Forms.Button AlternatingCase;
        private System.Windows.Forms.Button TitleCase;
        private System.Windows.Forms.Button SentenceCase;
        private System.Windows.Forms.Button LowerCaseButton;
        private System.Windows.Forms.Button CapitalizedCase;
    }
}

