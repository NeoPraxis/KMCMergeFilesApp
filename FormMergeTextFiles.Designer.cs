namespace KMCMergeFilesApp
{
    partial class FormMergeFiles
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
            this.buttonSelectFileOne = new System.Windows.Forms.Button();
            this.buttonSelectFileTwo = new System.Windows.Forms.Button();
            this.buttonSelectOutputFile = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.listBoxInputFile1 = new System.Windows.Forms.ListBox();
            this.listBoxInputFile2 = new System.Windows.Forms.ListBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.labelFile1 = new System.Windows.Forms.Label();
            this.labelFile2 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelectFileOne
            // 
            this.buttonSelectFileOne.Location = new System.Drawing.Point(378, 159);
            this.buttonSelectFileOne.Name = "buttonSelectFileOne";
            this.buttonSelectFileOne.Size = new System.Drawing.Size(75, 43);
            this.buttonSelectFileOne.TabIndex = 0;
            this.buttonSelectFileOne.Text = "Select File 1";
            this.buttonSelectFileOne.UseVisualStyleBackColor = true;
            this.buttonSelectFileOne.Visible = false;
            this.buttonSelectFileOne.Click += new System.EventHandler(this.buttonSelectFileOne_Click);
            // 
            // buttonSelectFileTwo
            // 
            this.buttonSelectFileTwo.Location = new System.Drawing.Point(399, 208);
            this.buttonSelectFileTwo.Name = "buttonSelectFileTwo";
            this.buttonSelectFileTwo.Size = new System.Drawing.Size(75, 43);
            this.buttonSelectFileTwo.TabIndex = 1;
            this.buttonSelectFileTwo.Text = "Select File 2";
            this.buttonSelectFileTwo.UseVisualStyleBackColor = true;
            this.buttonSelectFileTwo.Visible = false;
            this.buttonSelectFileTwo.Click += new System.EventHandler(this.buttonSelectFileTwo_Click);
            // 
            // buttonSelectOutputFile
            // 
            this.buttonSelectOutputFile.Location = new System.Drawing.Point(480, 208);
            this.buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            this.buttonSelectOutputFile.Size = new System.Drawing.Size(75, 43);
            this.buttonSelectOutputFile.TabIndex = 2;
            this.buttonSelectOutputFile.Text = "Select Output File";
            this.buttonSelectOutputFile.UseVisualStyleBackColor = true;
            this.buttonSelectOutputFile.Visible = false;
            this.buttonSelectOutputFile.Click += new System.EventHandler(this.buttonSelectOutputFile_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(110, 208);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(123, 43);
            this.buttonMerge.TabIndex = 3;
            this.buttonMerge.Text = "Merge Files";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // listBoxInputFile1
            // 
            this.listBoxInputFile1.FormattingEnabled = true;
            this.listBoxInputFile1.ItemHeight = 16;
            this.listBoxInputFile1.Location = new System.Drawing.Point(12, 25);
            this.listBoxInputFile1.Name = "listBoxInputFile1";
            this.listBoxInputFile1.Size = new System.Drawing.Size(315, 36);
            this.listBoxInputFile1.TabIndex = 4;
            // 
            // listBoxInputFile2
            // 
            this.listBoxInputFile2.FormattingEnabled = true;
            this.listBoxInputFile2.ItemHeight = 16;
            this.listBoxInputFile2.Location = new System.Drawing.Point(12, 88);
            this.listBoxInputFile2.Name = "listBoxInputFile2";
            this.listBoxInputFile2.Size = new System.Drawing.Size(315, 36);
            this.listBoxInputFile2.TabIndex = 5;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 16;
            this.listBoxOutput.Location = new System.Drawing.Point(12, 150);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(315, 36);
            this.listBoxOutput.TabIndex = 6;
            // 
            // labelFile1
            // 
            this.labelFile1.AutoSize = true;
            this.labelFile1.Location = new System.Drawing.Point(12, 9);
            this.labelFile1.Name = "labelFile1";
            this.labelFile1.Size = new System.Drawing.Size(39, 16);
            this.labelFile1.TabIndex = 7;
            this.labelFile1.Text = "File 1";
            // 
            // labelFile2
            // 
            this.labelFile2.AutoSize = true;
            this.labelFile2.Location = new System.Drawing.Point(12, 69);
            this.labelFile2.Name = "labelFile2";
            this.labelFile2.Size = new System.Drawing.Size(39, 16);
            this.labelFile2.TabIndex = 8;
            this.labelFile2.Text = "File 2";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 131);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(45, 16);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output";
            // 
            // FormMergeFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 263);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelFile2);
            this.Controls.Add(this.labelFile1);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.listBoxInputFile2);
            this.Controls.Add(this.listBoxInputFile1);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonSelectOutputFile);
            this.Controls.Add(this.buttonSelectFileTwo);
            this.Controls.Add(this.buttonSelectFileOne);
            this.Name = "FormMergeFiles";
            this.Text = "MergeFiles";
            this.Load += new System.EventHandler(this.FormMergeFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFileOne;
        private System.Windows.Forms.Button buttonSelectFileTwo;
        private System.Windows.Forms.Button buttonSelectOutputFile;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.ListBox listBoxInputFile1;
        private System.Windows.Forms.ListBox listBoxInputFile2;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label labelFile1;
        private System.Windows.Forms.Label labelFile2;
        private System.Windows.Forms.Label labelOutput;
    }
}

