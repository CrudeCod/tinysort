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
using static tinysort.Variables;
using static tinysort.Sorter;
namespace tinysort
{
    public partial class Form1 : Form
    {
        public static bool textCheckChecked = false;
        public static bool imgCheckChecked = false;
        public static bool appCheckChecked = false;
        public static bool vidCheckChecked = false;
        public static bool audioCheckChecked = false;

        public Form1()
        {
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Size = new System.Drawing.Size(500, 350);
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void directoryButton_Click(object sender, EventArgs e) {
            //makes a folder browse dialog
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            //sets the dirPath variable to the directory choice of the user
            if (openDir.ShowDialog() == DialogResult.OK)
            {
                dirPath = openDir.SelectedPath;


            }
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            //activates the sorting algorithm
            
            Sorter.sortMethod(); 

        }

        private void textCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (textCheck.Checked)
            {
                textCheckChecked = true;
            }
            else {
                textCheckChecked = false;
            }
        }

        private void imgCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (imgCheck.Checked)
            {
                imgCheckChecked = true;
            }
            else
            {
                imgCheckChecked = false;
            }
        }

        private void appCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (appCheck.Checked)
            {
                appCheckChecked = true;
            }
            else
            {
                appCheckChecked = false;
            }
        }

        private void vidCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (vidCheck.Checked)
            {
               vidCheckChecked = true;
            }
            else
            {
                vidCheckChecked = false;
            }
        }

        private void audioCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (audioCheck.Checked)
            {
                audioCheckChecked = true;
            }
            else
            {
                audioCheckChecked = false;
            }
        }
    }
}
