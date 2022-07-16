using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{




			/*int i = 8; // value type (stack)*/
			object obj = new object(); // instantiate the variable obj // ref type
			obj = null; // storing anything
			obj = 9; // storing value type // boxing: storing value into ref type

			/*	int j = obj(would not work, we need to convert this explicity(unbox it))
				int j = int(obj); // unboxing // converting ref into value back*/



			/*	Syntax for declaring an array*/
			//datatype [] name = new datatype[size]

			//you can also do it like this

			//string[] names;
			// names = new string[10]

			Console.WriteLine("Please enter array size");
			int size = Int32.Parse(Console.ReadLine());	



			int[] grades = new int[size]; // automatically derives from System.Array

			for (int i = 0; i < grades.Length; i++)
			{
				Console.Write($"Element {i}:");
				grades[i] = Int32.Parse(Console.ReadLine());
			}
			Array.Sort(grades);
			Array.Reverse(grades);	
			Console.WriteLine("Grades are:");
			for (int i = 0; i < grades.Length; i++)
			{
				Console.WriteLine(grades[i]);
			}
			Console.ReadLine();
			Environment.Exit(0);
		//grades = new int[100]


		}


		//animal ... base
		//animal --> carnivore
		//animal --> herbivore
	}
}
