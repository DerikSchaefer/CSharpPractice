using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod9Demo2
{
    internal class Program
    {

        const string Path = "C:\\Files\\log.text";
        static void Main(string[] args)
        {

            string username, password;
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();

            try
            {
                if (username == "Admin" && password == "password")
                {
                    Console.WriteLine("Successfull attempt!");
                }
                else
                    // this is the login exception that we created on the other .cs file. We are able to throw this because we inherited it from
                    // the base exception class
                    throw new LoginExceptions();
            }
            catch (LoginExceptions ex) // Temporary variable created when we catch this variable. We do not have to define this any other way

            {
                Console.Beep(50, 500);
                Console.WriteLine(ex.Message); // This 'Message' is a property of the LoginException class. 
                AppendLog(ex.Message);

            }
            Console.ReadLine();
            Console.WriteLine("Logs so far...");

        }

        static void ReadLogs()
        {

            StreamReader streamReader = new StreamReader(Path);
            string data = streamReader.ReadToEnd();
            Console.WriteLine(data);
            streamReader.Close();
        }

        static void AppendLog(string data)
        {
            File.AppendAllText(Path, data + "\n");

        }
    }
}