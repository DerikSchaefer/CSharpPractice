using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod9Demo1
{
    internal class Program
    {


        // We're doing it in this way to give the user the flexibility to do this with any file they want. we just make sure that it's a .txt
        // by doing this concatentation 

        // This is global variable practice 
        static string filename;
        const string path = "C:\\Files\\";




        static void Main(string[] args)
        {
            Console.WriteLine("Lets create a file to perform basic FILE io operations");
            Console.WriteLine("Please enter a file name:");
            filename = Console.ReadLine() + ".text";


            // This temp variable will be the entire filename
            string temp = path + filename;


            // This streamwriter method is able to write into a file
            StreamWriter streamWriter = null; // instance class 
                                              // File: static methods

            try
            {
                if (!File.Exists(temp))
                {
                    streamWriter = File.CreateText(temp);
                    streamWriter.WriteLine("This is a streamwriter line!");
                }
                else
                {
                    streamWriter = new StreamWriter(temp);
                    streamWriter.WriteLine($"new line written at {DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }

            }
            Console.WriteLine("these are the contents of the file:");
            using (StreamReader sr = new StreamReader(temp))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            {
                Console.ReadLine();
            }
        }

    }

}