using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSCADA_SharedResources
{
    public class AbsoluteDbPath
    {

        /*
         PLEASE CREATE A TXT FILE "dbname.txt" with the name of your database, so that we can create the 
                                               absolute path to your local database
         */

        public static string PathGeneration()
        {
            
            string working_directory = System.IO.Directory.GetCurrentDirectory();

            List<string> directories = working_directory.Split("\\").ToList();
            directories.RemoveRange(directories.Count - 4, 4);

            string absolute_path = "";
            foreach (string directory in directories) absolute_path += directory + $"\\";
            absolute_path += "SimpleSCADA_SharedResources\\Databases\\";
            if (1 == 0 && Environment.MachineName == "DESKTOP-PEDPORV")
            {
                absolute_path = "Databases/max.db";
            }
            else
            {
                absolute_path += File.ReadAllText(absolute_path + "dbname.txt") + ".db";
               
            }
            return absolute_path;
        }
    }
}
