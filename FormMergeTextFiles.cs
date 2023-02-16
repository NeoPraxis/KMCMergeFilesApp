using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMCMergeFilesApp
{
    public partial class FormMergeFiles : Form
    {
        public FormMergeFiles()
        {
            InitializeComponent();
        }
        public string SelectFile()
        {
            String filePath = String.Empty;

            // all of this code use the openFileDialog 

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Config the intital directory 
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = " txt files (*.txt)|*.txt" + "|"
                    + " comma seperated values (*.csv)|*.csv" + "|"
                    + " configuration files (*.cfg)|*.cfg" + "|"
                    + " All Files (*.*)|*.";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Get the selected file name from the user 
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //get path of the selected file 
                    filePath = openFileDialog.FileName;
                    MessageBox.Show(filePath);
                }


            }
            return filePath;

        }
        private void FormMergeFiles_Load(object sender, EventArgs e)
        {

        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            String userInputFile1;
            userInputFile1 = SelectFile();

            String userInputFile2;
            userInputFile2 = SelectFile();

            String userOutputFile;
            userOutputFile = SelectFile();

            KMCMergeFiles.MergeFiles(userInputFile1, userInputFile2, userOutputFile);
        }
        private void buttonSelectFileOne_Click(object sender, EventArgs e)
        {
            String userInputFile1;
            userInputFile1 = SelectFile();
        }
        

        private void buttonSelectFileTwo_Click(object sender, EventArgs e)
        {
            String secondFilePath;
            secondFilePath = SelectFile();
        }

        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            String outputFilePath;
            outputFilePath = SelectFile();
        }

    }
}
