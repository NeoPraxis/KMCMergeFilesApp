using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace KMCMergeFilesApp
{
    internal class KMCMergeFiles
    {

        #region properties
        #endregion properties

        #region data
        #endregion data

        #region methods
        /// <summary>
        /// This method merges two user selected files and outputs them into a user selected output file
        /// </summary>
        /// <param name="userFirstSelectedFile"></param>
        /// <param name="userSecondSelectedFile"></param>
        public static void MergeFiles(string userInputFile1, string userInputFile2, string userOutputFile)
        {
            int value1;
            int value2;
            StreamReader reader1 = null, reader2 = null;
            StreamWriter writer = null;

            try
            {
                reader1 = new StreamReader(userInputFile1);
                reader2 = new StreamReader(userInputFile2);
                writer = new StreamWriter(userOutputFile);

                while ((!reader1.EndOfStream) && (!reader2.EndOfStream))
                {
                   
                    value1 = Convert.ToInt32(reader1.ReadLine());
                    value2 = Convert.ToInt32(reader2.ReadLine());
                    if (value1 < value2)
                    {
                        writer.WriteLine(value1.ToString());
                        //reader1.ReadLine();
                    }
                    else if (value1 > value2)
                    {
                        writer.WriteLine(value2.ToString());
                        //reader2.ReadLine();
                    }
                    else if (value1 == value2)
                    {
                        writer.WriteLine(value1);
                        //reader1.ReadLine();
                    }
                    
                        
               
                }

                while (!reader1.EndOfStream && reader2.EndOfStream)
                {
                    value1 = Convert.ToInt32(reader1.ReadLine());
                    writer.WriteLine(value1.ToString());
                }

                while (!reader2.EndOfStream && reader1.EndOfStream)
                {
                    value2 = Convert.ToInt32(reader2.ReadLine());
                    writer.WriteLine(value2.ToString());
                }
                


            }
            catch (Exception ex) 
            {
                //throw new Exception(ex.Message);
            }
            finally
            {
                reader1.Close();
                reader2.Close();
                writer.Close();
            }
            //while (!reader1.EndOfStream && !reader2.EndOfStream)
            //{
                //int value; // first one outputs reader 1 and 2
                // second one outputs reader 1
                // third one outputs reader 2

                /*if (!reader1.EndOfStream || !reader2.EndOfStream)
                {
                    int value1 = Convert.ToInt32(line1);
                    int value2 = Convert.ToInt32(line2);

                    if (value1 < value2)
                    {
                        value = value1;
                        line1 = reader1.ReadLine();
                    }
                    else
                    {
                        value = value2;
                        line2 = reader2.ReadLine();
                    }
                }

                else if (reader1.EndOfStream)
                {
                    value = Convert.ToInt32(line1);
                    line1 = reader1.ReadLine();
                }
                else
                {
                    value = Convert.ToInt32(line2);
                    line2 = reader2.ReadLine();
                }
                writer.WriteLine(value.ToString().Trim());
            }*/
            
        }
    }
    #endregion methods
    #region events
    #endregion events
}

