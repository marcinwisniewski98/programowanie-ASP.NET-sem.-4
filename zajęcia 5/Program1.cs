using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia5
{
    class Palindrome
    {
        private string word;
        private string path;

        public Palindrome(string path)
        {
            this.path = path;
            Console.WriteLine(path);
        }

        public void readData()
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                using (StreamReader sr = fi.OpenText())
                    {
                        word = "";
                        while ((word = sr.ReadLine()) != null)
                        {
                            if(checkPalindrome())
                                Console.WriteLine(word);
                        }
                    }
            }
            catch (SecurityException) { Console.WriteLine("Permission denied."); }
            catch (FileNotFoundException) { Console.WriteLine("File not found."); }
            catch (UnauthorizedAccessException) { Console.WriteLine("Permission denied."); }
            catch (DirectoryNotFoundException) { Console.WriteLine("The path is incorrect."); }
        }
        private bool checkPalindrome()
        {
            for (int i = 0; i < word.Length / 2; i++)
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            return true;
        }
    }
    class Program1
    {


        static void Main(string[] args)
        {
            Palindrome palindrome = new Palindrome(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\words.txt");
            palindrome.readData();
        }
    }
}
