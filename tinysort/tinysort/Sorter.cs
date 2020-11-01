using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tinysort.Variables;
using static tinysort.Form1;
namespace tinysort
{
    class Sorter
    {
        public static void sortMethod()
        {
            // collects names of files in a given directory and lumps them in an array
            try
            {

                string[] sFileNames = Directory.GetFiles(dirPath, "*");

                foreach (string element in sFileNames)
                {
                    //converts the full paths to the files to just their actual names and adds them into an ArrayList
                    fileNames.Add(Path.GetFileName(element));
                }
                //checks if directory doesn't already exist, then creates it
                if (!Directory.Exists(Path.Combine(dirPath, "images")))
                {
                    Directory.CreateDirectory(Path.Combine(dirPath, "images"));
                }
                if (!Directory.Exists(Path.Combine(dirPath, "text_files")))
                {
                    Directory.CreateDirectory(Path.Combine(dirPath, "text_files"));
                }

                if (!Directory.Exists(Path.Combine(dirPath, "videos")))
                {
                    Directory.CreateDirectory(Path.Combine(dirPath, "videos"));
                }

                if (!Directory.Exists(Path.Combine(dirPath, "applications")))
                {
                    Directory.CreateDirectory(Path.Combine(dirPath, "applications"));
                }

            }
            catch (ArgumentNullException)
            {
                System.Windows.Forms.MessageBox.Show("An argument null exception has occured! Please select a directory that is not empty!");
            }

            foreach (string fileName in fileNames)
            {
                //extension check

                if (imageExtensions.Contains(Path.GetExtension(fileName)))
                {
                    if (imgCheckChecked)
                    {
                        //assigns the target path
                        targPath = Path.Combine(dirPath, "images");

                        //creates the source file location
                        string sourceFile = Path.Combine(dirPath, fileName);//implement this as showed on that blogspot website
                        //creates the destination
                        string destFile = Path.Combine(targPath, fileName);
                        //initiates the transfer + checks for unknown exceptions
                        try
                        {
                            File.Move(sourceFile, destFile);
                        }
                        catch (Exception e)
                        {
                            System.Windows.Forms.MessageBox.Show("An exception has occured! " + e);

                        }


                    }
                }


                //    if (Path.GetExtension(fileName) == ".png" || Path.GetExtension(fileName) == ".jpg" || Path.GetExtension(fileName) == ".jpeg" || Path.GetExtension(fileName) == ".gif") {

                else if (textExtensions.Contains(Path.GetExtension(fileName)))
                {
                    if (textCheckChecked)
                    {

                        //assigns the target path
                        targPath = Path.Combine(dirPath, "text_files");
                        //creates the source file location
                        string sourceFile = Path.Combine(dirPath, fileName);//implement this as showed on that blogspot website
                        //creates the destination
                        string destFile = Path.Combine(targPath, fileName);
                        //initiates the transfer
                        try
                        {
                            File.Move(sourceFile, destFile);
                        }
                        catch (Exception e)
                        {
                            //checks if a fuck-up happens
                            System.Windows.Forms.MessageBox.Show("An exception has occured! " + e);

                        }

                    }

                }
                else if (videoExtensions.Contains(Path.GetExtension(fileName)))
                {

                    if (vidCheckChecked)
                    {
                        targPath = Path.Combine(dirPath, "videos");

                        string sourceFile = Path.Combine(dirPath, fileName);

                        string destFile = Path.Combine(targPath, fileName);

                        try
                        {
                            File.Move(sourceFile, destFile);
                        }
                        catch (Exception e)
                        {
                            System.Windows.Forms.MessageBox.Show("An exception has occured! " + e);

                        }

                    }

                }
                else if (appExtensions.Contains(Path.GetExtension(fileName)))
                {
                    if (appCheckChecked)
                    {
                        targPath = Path.Combine(dirPath, "applications");

                        string sourceFile = Path.Combine(dirPath, fileName);

                        string destFile = Path.Combine(targPath, fileName);

                        try
                        {
                            File.Move(sourceFile, destFile);
                        }
                        catch (Exception e)
                        {
                            System.Windows.Forms.MessageBox.Show("An exception has occured! " + e);

                        }


                    }


                }

                else if (audioExtensions.Contains(Path.GetExtension(fileName)))
                {
                    if (audioCheckChecked)
                    {

                        targPath = Path.Combine(dirPath, "audio");

                        string sourceFile = Path.Combine(dirPath, fileName);

                        string destFile = Path.Combine(targPath, fileName);

                        try
                        {
                            File.Move(sourceFile, destFile);
                        }
                        catch (Exception e)
                        {
                            System.Windows.Forms.MessageBox.Show("An exception has occured! " + e);

                        }
                    }

                }

            }
        }



        
    }
}
