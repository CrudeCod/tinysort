using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinysort
{


    public class Variables
    {
        //initializes the directory path and the target path
       public static string dirPath;
       public static string targPath;
        //creates the possible extensions
       public static string[] textExtensions = { ".txt", ".rtf", ".pdf", ".doc", ".docx"};
       public static string[] imageExtensions = { ".png", ".jpg", ".jpeg", ".gif", ".PNG", ".JPG" };
       public static string[] videoExtensions = { ".mp4", ".m4a", ".mov", ".webm", ".wmv", ".avi", ".flv", ".mkv"};
       public static string[] appExtensions = { ".exe", ".url", ".lnk" };
       public static string[] audioExtensions = { ".ogg", ".mp3", ".wav" };


       public static System.Collections.ArrayList fileNames = new System.Collections.ArrayList();

    }
}
