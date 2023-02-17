/* ********************************************************************
 * Projct:      Merge Files
 * File:        KMCMergeFiles.cs
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
 * 0.1   KMC 2/13/2023  - created merge file class
 *                      - added logic to open the files
 *                      - added logic to compare files
 *                      - added logic to convert the files
 * 0.2   KMC 2/14/2023  - mapped out overall structure of code on board
 *                      - got one input value to display in output file
 * 0.3   KMC 2/15/2023  - added logic to get all values to display and
 *                        be in order WOULD NOT DISPLAY FINAL VALUE OF 100
 * 0.4   KMC 2/16/2023  - redid all the logic to try 3 while loops, could
 *                        not get the values to display in the right order
 *                        or display the final value, 100.
 *                      - redid all the logic again from square one, using
 *                        the single while loop method I was using, and found
 *                        that I could use ternary operators to solve my final
 *                        value not being read as "null".
 *                        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
 *                      - edited while loop to compare value1 / value2 to max values
 *                      - touched up some of the logic, got the whole program to work with one while loop
 *                        and a single if else for maximum efficiency.
 *                      - FINAL
 *                      
 * *******************************************************************/
using System;
using System.IO;
using System.Windows.Forms;

namespace KMCMergeFilesApp
{
    internal class KMCMergeFiles
    {

        #region methods
        /// <summary>
        /// This method merges two user selected files and outputs them into a user selected output file
        /// </summary>
        /// <param name="userFirstSelectedFile"></param>
        /// <param name="userSecondSelectedFile"></param>
        public static void MergeFiles(string userInputFile1, string userInputFile2, string userOutputFile)
        {
            StreamReader reader1, reader2;
            StreamWriter writer; 
            int value1, value2;

            // open the files from the button
            reader1 = new StreamReader(userInputFile1);
            reader2 = new StreamReader(userInputFile2);
            writer = new StreamWriter(userOutputFile);

            // convert them so we can compare the values
            value1 = Convert.ToInt32(reader1.ReadLine());
            value2 = Convert.ToInt32(reader2.ReadLine());

            // when value1 is less than the max value, or while value2 is less than the max value
            while (value1 < Int32.MaxValue || value2 < Int32.MaxValue)
            {
                // add the smaller value
                if (value1 > value2)
                {
                    writer.WriteLine(value2.ToString());    // write to file
                    string string2 = reader2.ReadLine();    // read line
                    // if end of file, set value to max, else convert the value to int
                    value2 = string2 == null ? Int32.MaxValue : Convert.ToInt32(string2);  
                }
                else
                {
                    writer.WriteLine(value1.ToString());    
                    string string1 = reader1.ReadLine();    
                    value1 = string1 == null ? Int32.MaxValue : Convert.ToInt32(string1);
                }
            }
            // close all files
            reader1.Close();
            reader2.Close();
            writer.Close();
            // message box to tell user the files were merged
            MessageBox.Show("Files merged!");
        }
    }
}
#endregion methods
#region events
#endregion events


