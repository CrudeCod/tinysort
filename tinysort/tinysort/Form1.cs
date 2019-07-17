using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinysort
{
    public partial class Form1 : Form
    {
        //initializes the directory path and the target path
        string dirPath;
        string targPath;
        //initializes the possible extensions
        string[] textExtensions = { ".txt", ".rtf", ".pdf", ".doc", ".docx" };
        string[] imageExtensions = { ".png", ".jpg", ".jpeg", ".gif" };
        string[] videoExtensions = { ".mp4", ".m4a", ".mov", ".ogg", ".webm", ".wmv", ".avi", ".flv" };
        string[] appExtensions = { ".exe",".url" };


        System.Collections.ArrayList fileNames = new System.Collections.ArrayList();

        

        public Form1()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            //activates the sorting algorithm
            sortMethod(); 

        }

        private void sortMethod() {
            // collects names of files in a given directory and lumps them in an array
            string[] sFileNames = Directory.GetFiles(dirPath, "*");

            foreach (string element in sFileNames)
            {
                //converts the full paths to the files to just their actual names and adds them into an ArrayList
                fileNames.Add(Path.GetFileName(element)); 
            }
            //checks if directory doesn't already exist, then creates it
            if (!Directory.Exists(Path.Combine(dirPath, "images"))) {
                Directory.CreateDirectory(Path.Combine(dirPath, "images"));
            }
            if (!Directory.Exists(Path.Combine(dirPath, "text_files"))) {
                Directory.CreateDirectory(Path.Combine(dirPath, "text_files"));
            }

            if (!Directory.Exists(Path.Combine(dirPath, "videos"))) {
                Directory.CreateDirectory(Path.Combine(dirPath, "videos"));
            }

            if (!Directory.Exists(Path.Combine(dirPath, "applications"))) {
                Directory.CreateDirectory(Path.Combine(dirPath, "applications"));
            }
                

            
            foreach (string fileName in fileNames) {
                //extension check

                if (imageExtensions.Contains(Path.GetExtension(fileName))) {
                    if (imgCheck.Checked)
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
                    if (textCheck.Checked) {

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

                    if (vidCheck.Checked) {
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
                    if (appCheck.Checked) {
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
              
            }
        }

        

        private void directoryButton_Click(object sender, EventArgs e)
        {
            //makes a folder browse dialog
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            //sets the dirPath variable to the directory choice of the user
            if (openDir.ShowDialog() == DialogResult.OK) {
                 dirPath = openDir.SelectedPath;
     

            }
        }
    }
}
