using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program4
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            int pointsInCircle = 0;
            int pointsInSquare = 100000;

            for(int i=0; i<pointsInSquare; i++)
            {
                int x = random.Next(-50, 51);
                int y = random.Next(-50, 51);

                if (x * x + y * y <= 2500)
                    pointsInCircle++;
            }

            double pi = 4 * (double)pointsInCircle / pointsInSquare;

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\pi.txt";
                Console.WriteLine(path);
                FileInfo fi = new FileInfo(path);
                
                StreamWriter sw = fi.CreateText();
                sw.WriteLine(pi.ToString());
                sw.Flush();
                sw.Close();
            }
            catch (SecurityException) { Console.WriteLine("Permission denied."); }
            catch (UnauthorizedAccessException) { Console.WriteLine("Permission denied."); }
            catch (DirectoryNotFoundException) { Console.WriteLine("The path is incorrect."); }
            catch (IOException) { Console.WriteLine("File from this path is used by another program or it's read-only."); }
            catch { Console.WriteLine("The path is incorrect."); }
        }
    }
}
