namespace IBSolution.Graph
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourcesPathBox = new System.Windows.Forms.TextBox();
            this.SourcesLabeL = new System.Windows.Forms.Label();
            this.LineDetailsPath = new System.Windows.Forms.TextBox();
            this.SniffLabel = new System.Windows.Forms.Label();
            this.TargetPathLabel = new System.Windows.Forms.Label();
            this.TargetFileBox = new System.Windows.Forms.TextBox();
            this.SourcesButton = new System.Windows.Forms.Button();
            this.SnifFilePath = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.SelectLineDetailsDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectSourcesDir = new System.Windows.Forms.OpenFileDialog();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(this.SourcesPathBox, 0, 1);
            tableLayoutPanel1.Controls.Add(this.SourcesLabeL, 0, 0);
            tableLayoutPanel1.Controls.Add(this.LineDetailsPath, 0, 3);
            tableLayoutPanel1.Controls.Add(this.SniffLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(this.TargetPathLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(this.TargetFileBox, 0, 5);
            tableLayoutPanel1.Controls.Add(this.SourcesButton, 1, 1);
            tableLayoutPanel1.Controls.Add(this.SnifFilePath, 1, 3);
            tableLayoutPanel1.Controls.Add(this.CloseButton, 1, 7);
            tableLayoutPanel1.Controls.Add(this.RunButton, 0, 7);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.63025F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.36975F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new System.Drawing.Size(450, 360);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SourcesPathBox
            // 
            this.SourcesPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SourcesPathBox.Location = new System.Drawing.Point(3, 93);
            this.SourcesPathBox.Name = "SourcesPathBox";
            this.SourcesPathBox.ReadOnly = true;
            this.SourcesPathBox.Size = new System.Drawing.Size(219, 20);
            this.SourcesPathBox.TabIndex = 0;
            this.SourcesPathBox.Text = "None";
            // 
            // SourcesLabeL
            // 
            this.SourcesLabeL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SourcesLabeL.AutoSize = true;
            this.SourcesLabeL.ForeColor = System.Drawing.Color.White;
            this.SourcesLabeL.Location = new System.Drawing.Point(3, 77);
            this.SourcesLabeL.Name = "SourcesLabeL";
            this.SourcesLabeL.Size = new System.Drawing.Size(68, 13);
            this.SourcesLabeL.TabIndex = 100000;
            this.SourcesLabeL.Text = "SourcesPath";
            // 
            // LineDetailsPath
            // 
            this.LineDetailsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LineDetailsPath.Location = new System.Drawing.Point(3, 136);
            this.LineDetailsPath.Name = "LineDetailsPath";
            this.LineDetailsPath.ReadOnly = true;
            this.LineDetailsPath.Size = new System.Drawing.Size(219, 20);
            this.LineDetailsPath.TabIndex = 2;
            this.LineDetailsPath.Text = "None";
            // 
            // SniffLabel
            // 
            this.SniffLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SniffLabel.AutoSize = true;
            this.SniffLabel.ForeColor = System.Drawing.Color.White;
            this.SniffLabel.Location = new System.Drawing.Point(3, 120);
            this.SniffLabel.Name = "SniffLabel";
            this.SniffLabel.Size = new System.Drawing.Size(103, 13);
            this.SniffLabel.TabIndex = 100002;
            this.SniffLabel.Text = "Line Details FilePath";
            // 
            // TargetPathLabel
            // 
            this.TargetPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TargetPathLabel.AutoSize = true;
            this.TargetPathLabel.ForeColor = System.Drawing.Color.White;
            this.TargetPathLabel.Location = new System.Drawing.Point(3, 163);
            this.TargetPathLabel.Name = "TargetPathLabel";
            this.TargetPathLabel.Size = new System.Drawing.Size(170, 13);
            this.TargetPathLabel.TabIndex = 100003;
            this.TargetPathLabel.Text = "Target FileName with no extension";
            // 
            // TargetFileBox
            // 
            this.TargetFileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TargetFileBox.Location = new System.Drawing.Point(3, 179);
            this.TargetFileBox.Name = "TargetFileBox";
            this.TargetFileBox.Size = new System.Drawing.Size(219, 20);
            this.TargetFileBox.TabIndex = 3;
            this.TargetFileBox.Text = "Loki_file";
            // 
            // SourcesButton
            // 
            this.SourcesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SourcesButton.Location = new System.Drawing.Point(300, 93);
            this.SourcesButton.Name = "SourcesButton";
            this.SourcesButton.Size = new System.Drawing.Size(75, 23);
            this.SourcesButton.TabIndex = 1;
            this.SourcesButton.Text = "Select";
            this.SourcesButton.UseVisualStyleBackColor = true;
            this.SourcesButton.Click += new System.EventHandler(this.SourcesButton_Click);
            // 
            // SnifFilePath
            // 
            this.SnifFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SnifFilePath.Location = new System.Drawing.Point(300, 136);
            this.SnifFilePath.Name = "SnifFilePath";
            this.SnifFilePath.Size = new System.Drawing.Size(75, 22);
            this.SnifFilePath.TabIndex = 2;
            this.SnifFilePath.Text = "Select";
            this.SnifFilePath.UseVisualStyleBackColor = true;
            this.SnifFilePath.Click += new System.EventHandler(this.SnifFilePath_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CloseButton.Location = new System.Drawing.Point(300, 329);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 28);
            this.CloseButton.TabIndex = 100006;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RunButton.Location = new System.Drawing.Point(75, 329);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 28);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // SelectLineDetailsDialog
            // 
            this.SelectLineDetailsDialog.FileName = "Select File";
            this.SelectLineDetailsDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm\";*.xlsb;";
            // 
            // SelectSourcesDir
            // 
            this.SelectSourcesDir.FileName = "Select sources File";
            this.SelectSourcesDir.Filter = "\"Text|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "LOKI-LogicOrderingKonsolidatorInterface";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox SourcesPathBox;
        private System.Windows.Forms.Label SourcesLabeL;
        private System.Windows.Forms.TextBox LineDetailsPath;
        private System.Windows.Forms.Label SniffLabel;
        private System.Windows.Forms.Label TargetPathLabel;
        private System.Windows.Forms.TextBox TargetFileBox;
        private System.Windows.Forms.Button SourcesButton;
        private System.Windows.Forms.Button SnifFilePath;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.OpenFileDialog SelectLineDetailsDialog;
        private System.Windows.Forms.OpenFileDialog SelectSourcesDir;
    }
}