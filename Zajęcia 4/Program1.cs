using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program1
    {
        private static string getPath()
        {
            Console.Write("Write down path to create file: ");
            string path = Console.ReadLine();

            if (path == "q")
                Environment.Exit(0);

            return path;
        }

        private static void quickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];
            
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if(i<=j)
                {
                    int temp = array[i];
                    array[i++] = array[j];
                    array[j--] = temp;
                }
            }
            if (left < j) quickSort(array, left, j);
            if (i < right) quickSort(array, i, right);
        }

        private static void saveData(String path, int[] tab)
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                StreamWriter sw;
                if (!fi.Exists)
                {
                    Directory.CreateDirectory(fi.DirectoryName);
                }

                sw = fi.AppendText();
                foreach(int number in tab)
                    sw.WriteLine(number.ToString());
                sw.Flush();
                sw.Close();
            }
            catch (SecurityException) { Console.WriteLine("Permission denied."); }
            catch (UnauthorizedAccessException) { Console.WriteLine("Permission denied."); }
            catch (DirectoryNotFoundException) { Console.WriteLine("The path is incorrect."); }
            catch (IOException) { Console.WriteLine("File from this path is used by another program or it's read-only."); }
            catch { Console.WriteLine("The path is incorrect."); }
        }

        private static void readData(String path)
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    using (StreamReader sr = fi.OpenText())
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
            }
            catch (SecurityException) { Console.WriteLine("Permission denied."); }
            catch (FileNotFoundException) { Console.WriteLine("File not found.");  }
            catch (UnauthorizedAccessException) { Console.WriteLine("Permission denied."); }
            catch (DirectoryNotFoundException) { Console.WriteLine("The path is incorrect."); }
        }

        static void Main(string[] args)
        {
            string path = getPath();
            while (path == "-1")
            {
                Console.WriteLine("Incorrect path. Try again");
                path = getPath();
            }

            int[] numbers = Array.ConvertAll(args, s => int.Parse(s));
            quickSort(numbers, 0, numbers.Length-1);

            saveData(path, numbers);
            readData(path);
        }
    }
}
