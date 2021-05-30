using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        private static string getPath()
        {
            Console.Write("Write down path to remove: ");
            string path = Console.ReadLine();

            if (path == "q")
                Environment.Exit(0);

            if (!File.Exists(path) && !Directory.Exists(path))
                path = "-1";

            return path;
        }

        private static string getPathType(string path)
        {
            string type="";

            try
            {
                FileAttributes attr = File.GetAttributes(path);
                if (attr.HasFlag(FileAttributes.Directory))
                    type = "directory";
                else
                    type = "file";
            }
            catch
            {
                Console.WriteLine("Error");
            }

            return type;
        }
        
        private static bool confirmRemoval(string path)
        {
            bool confirmed;
            string type = getPathType(path);

            if (type == "directory")
                Console.Write("Are you sure to delete the directory, subdirectories and files in one? [y/n]: ");
            else if (type == "file")
                Console.Write("Are you sure to delete this file? [y/n]: ");

            string response = Console.ReadLine();
            if (response == "y" || response == "Y")
                confirmed = true;
            else if (response == "n" || response == "N")
                confirmed = false;
            else
                return confirmRemoval(path);

            return confirmed;
        }

        private static bool removeFiles(string path)
        {
            bool deleted = false;
            try
            {
                string type = getPathType(path);
                if (type=="directory")
                {
                    Directory.Delete(path, true);
                    deleted = !Directory.Exists(path);
                }
                else if(type=="file")
                {
                    File.Delete(path);
                    deleted = !File.Exists(path);
                }
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Permission denied.");
            }
            catch (IOException)
            {
                Console.WriteLine("File from this path is used by another program or it's read-only");
            }
            catch
            {
                Console.WriteLine("Error");
            }

            return deleted;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string path = getPath();
                if (path == "-1")
                    Console.WriteLine("Wrong path.");
                else
                {
                    bool confirmation = confirmRemoval(path);
                    bool deleted = false;

                    if (confirmation)
                        deleted = removeFiles(path);

                    if (deleted)
                        Console.WriteLine("Files from path {0} deleted", path);
                }
            }
        }
    }
}
