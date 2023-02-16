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
            this.SuspendLayout();
            // 
            // buttonSelectFileOne
            // 
            this.buttonSelectFileOne.Location = new System.Drawing.Point(90, 40);
            this.buttonSelectFileOne.Name = "buttonSelectFileOne";
            this.buttonSelectFileOne.Size = new System.Drawing.Size(75, 43);
            this.buttonSelectFileOne.TabIndex = 0;
            this.buttonSelectFileOne.Text = "Select File 1";
            this.buttonSelectFileOne.UseVisualStyleBackColor = true;
            this.buttonSelectFileOne.Click += new System.EventHandler(this.buttonSelectFileOne_Click);
            // 
            // buttonSelectFileTwo
            // 
            this.buttonSelectFileTwo.Location = new System.Drawing.Point(171, 40);
            this.buttonSelectFileTwo.Name = "buttonSelectFileTwo";
            this.buttonSelectFileTwo.Size = new System.Drawing.Size(75, 43);
            this.buttonSelectFileTwo.TabIndex = 1;
            this.buttonSelectFileTwo.Text = "Select File 2";
            this.buttonSelectFileTwo.UseVisualStyleBackColor = true;
            this.buttonSelectFileTwo.Click += new System.EventHandler(this.buttonSelectFileTwo_Click);
            // 
            // buttonSelectOutputFile
            // 
            this.buttonSelectOutputFile.Location = new System.Drawing.Point(252, 40);
            this.buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            this.buttonSelectOutputFile.Size = new System.Drawing.Size(75, 43);
            this.buttonSelectOutputFile.TabIndex = 2;
            this.buttonSelectOutputFile.Text = "Select Output File";
            this.buttonSelectOutputFile.UseVisualStyleBackColor = true;
            this.buttonSelectOutputFile.Click += new System.EventHandler(this.buttonSelectOutputFile_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(165, 179);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 43);
            this.buttonMerge.TabIndex = 3;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // FormMergeFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 401);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonSelectOutputFile);
            this.Controls.Add(this.buttonSelectFileTwo);
            this.Controls.Add(this.buttonSelectFileOne);
            this.Name = "FormMergeFiles";
            this.Text = "FormMergeFiles";
            this.Load += new System.EventHandler(this.FormMergeFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFileOne;
        private System.Windows.Forms.Button buttonSelectFileTwo;
        private System.Windows.Forms.Button buttonSelectOutputFile;
        private System.Windows.Forms.Button buttonMerge;
    }
}

