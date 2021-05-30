using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
       private static string getPath()
        {
            Console.Write("Enter directory: ");
            string path = Console.ReadLine();
            
            if(path=="q")
                Environment.Exit(0);

            if (!Directory.Exists(path))
            {
                Console.WriteLine("No directory found. Try again.");
                path = getPath();
            }

            return path;
        }
        private static long getDirectorySize(string path)
        {
            long length = 0;
            DirectoryInfo di = new DirectoryInfo(".");

            try
            {
                di = new DirectoryInfo(path);

                FileInfo[] files = di.GetFiles("*", SearchOption.AllDirectories);
                foreach (FileInfo file in files)
                    length += file.Length;
            }
            catch (SecurityException)
            {
                Console.WriteLine("Permission denied.");
            }
            catch
            {
                Console.WriteLine("Error");
            }

            return length;
        }
        static void Main(string[] args)
        {
            string path = getPath();
            long size = getDirectorySize(path);

            Console.WriteLine("Size of this directory and subdirectories is {0:n0} bytes", size);

        }
    }
}
