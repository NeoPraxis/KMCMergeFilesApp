/* ********************************************************************
 * Projct:      Merge Files
 * File:        FormMergeTextFiles.cs
 * Language:    C#
 * 
 * Desription:  This project will merge two user selected files into a
 *              single user selected output file
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 2/13/2023  - added all the buttons necessary to open files
 *                      - imported select file routine from previous prj.
 * 0.2   KMC 2/16/2023  - fixed UI design                     
 * *******************************************************************/
using System;
using System.Windows.Forms;

namespace KMCMergeFilesApp
{
    public partial class FormMergeFiles : Form
    {
        public FormMergeFiles()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method selects the user selected file from the windows explorer 
        /// </summary>
        /// <returns>file path</returns>
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

        /// <summary>
        /// This button lets the user select 3 files, first file to merge, second file to merge
        /// and the output file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMerge_Click(object sender, EventArgs e)
        {
            try
            {
                // user selects first file
                String userInputFile1;
                MessageBox.Show("Please select your first file to merge.");
                userInputFile1 = SelectFile();
                listBoxInputFile1.Items.Add(userInputFile1);

                // user selects second file
                String userInputFile2;
                MessageBox.Show("Please select your second file to merge.");
                userInputFile2 = SelectFile();
                listBoxInputFile2.Items.Add(userInputFile2);

                // user selects third and final output file
                String userOutputFile;
                MessageBox.Show("Please select your output file for the merged files.");
                userOutputFile = SelectFile();
                listBoxOutput.Items.Add(userOutputFile);

                // merge the files
                KMCMergeFiles.MergeFiles(userInputFile1, userInputFile2, userOutputFile);
            }
            catch (Exception)
            {

                // if no file is selected, ask for a file, and clear the listbox
                MessageBox.Show("Select two .txt files to merge, with a .txt output file.");
                listBoxInputFile1.Items.Clear();
                listBoxInputFile2.Items.Clear();
                listBoxOutput.Items.Clear();

            }
        }



        // I was going to do three buttons, but it is easier / faster testing wise and UI wise to do one
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
