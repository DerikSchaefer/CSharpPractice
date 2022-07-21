using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*1.Write a console application to create a text file and save your basic details like name, age, 
    address ( use dummy data). Read the details from same file and print on console.*/
namespace Assignment2._2
{
    internal class Program
    {

        // Create a variable to store our filename

        // const for the path

        // We declare these two variables in the class / outside the main method because this way we can 
        //use these variables outside the main if needed. 6
        static string filename;
        const string path = "C:\\Files\\";
        static void Main(string[] args)
        {

        //Ask the user for their name, this will be what we name the file 
            Console.WriteLine("Please enter your name");

        //Store the input from the user in a variable
            string name = Console.ReadLine();

        //Combine the input from the user + ".text"
            filename = name + ".text";

        //Combine this all into a full file name
            string temp = path + filename;

        //Create an instance of the streamWriter object, this is from the System.IO class
            StreamWriter streamWriter = null;


        //Create a try block
            try
            {

        // We're going to check if the file already exists, if it does not we will create it
                if (!File.Exists(temp))
                {
                    streamWriter = File.CreateText(temp);
                }

        //If it does already exist we're going to delete the old one and recreate a new one
                else
                {
                    streamWriter = new StreamWriter(temp);
                }

        //We will use the value stored in the name variable from earlier to write the user's name to the
        //file we created
                streamWriter.WriteLine(name);

        //Ask for the user's age and address, store these in variables and then write these to the file
        //using the WriteLine method
                Console.WriteLine("What is your age");
                string age = Console.ReadLine();
                streamWriter.WriteLine(age);
                Console.WriteLine("What is your address");
                string address = Console.ReadLine();
                streamWriter.WriteLine(address);
            }
        //Catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        //Finally block, since streamWriter will not be null this will close out this block
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        //Ask the user if they would like to see their data
            Console.WriteLine("Would you like to see your data? Y/N");

        //Store this in a temp variable and use an if statement to check their answer
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
        //If they answered yes we will use a while loop to iterate through every line of the file and 
        //return those back to the user via the console.
                using (StreamReader sr = new StreamReader(temp))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
        //Console ReadLine to pause everything
                Console.ReadLine();
            }
        }
    }
}