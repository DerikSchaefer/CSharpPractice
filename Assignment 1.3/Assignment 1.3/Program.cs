using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._3
{
    internal class Program
    {


        static void AreaOfTriangle()
        {
            Console.WriteLine("What is the height of the triangle?");
            float height, baseOf;
            height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the base of the triangle?");
            baseOf = Int32.Parse(Console.ReadLine());
            float result = (baseOf / 2) * height;
            Console.WriteLine("result is " + result);
            Console.ReadLine();

        }
        static void AreaOfSquare()
        {
            Console.WriteLine("What is the length of one of the sides of the square?");
            int num1;
            num1 = Int32.Parse(Console.ReadLine());
            int result = num1 * num1;
            Console.WriteLine("result is " + result);
            Console.ReadLine();
        }

        static void AreaOfRectangle()
        {
            Console.WriteLine("what is the length of the rectangle");
            float length, width;
            length = float.Parse(Console.ReadLine());
            Console.WriteLine("what is the width of the rectangle");
            width = float.Parse(Console.ReadLine());
            float result = length * width;
            Console.WriteLine("result is " + result);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Which of these tasks do you want to do?\n1. Calculate the area of shapes\n2. Sort an array in reverse order" +
            "\n3. Bubble sort an array in acending order\n4. Bubble sort an array in descending order");

            int choiceOne = Int32.Parse(Console.ReadLine());

            switch (choiceOne)
            {
                    case 1:
                    CallMenu();
                    break;

                    case 2:
                    ReverseArray();
                    break;

                    case 3:
                    Console.WriteLine("How big do you want your array to be?");
                    int size = Int32.Parse(Console.ReadLine());

                    int[] bSortArray = new int[size];

                    for (int i = 0; i < bSortArray.Length; i++)
                    {
                        Console.Write($"Enter an element for your array {i}:\n");
                        bSortArray[i] = Int32.Parse(Console.ReadLine());
                    }
                    BubbleSort(bSortArray);
                    Console.WriteLine("Sorted list is:");
                    foreach (int i in bSortArray)
                    {
                    Console.Write(i);
                    }
                    Console.ReadLine();
                    break;

                    case 4:
                    Console.WriteLine("How big do you want your array to be?");
                    int sizeDesc = Int32.Parse(Console.ReadLine());

                    int[] bSortArrayDesc = new int[sizeDesc];

                    for (int i = 0; i < bSortArrayDesc.Length; i++)
                    {
                        Console.Write($"Enter an element for your array {i}:\n");

                        bSortArrayDesc[i] = Int32.Parse(Console.ReadLine());
                    }
                    BubbleSortDescending(bSortArrayDesc);

                    Console.WriteLine("Sorted list is:");
                    foreach (int i in bSortArrayDesc)
                    {
                        Console.Write(i);
                    }
                    Console.ReadLine();
                    break;
            }
        }
    
        //1.Write a program in C# to calculate area of triangle, square and rectangle. Write 3 different functions for each shape
        //to take dimensions of figure and display the area. You may create menus.

        static void CallMenu()
        {
        
        Console.WriteLine("Which of these shapes do you want to calculate the area of?\n 1. A triangle\n 2. A square" +
                " \n 3. A rectangle");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AreaOfTriangle();
                    break;

                case 2:
                    AreaOfSquare();
                    break;

                case 3:
                    AreaOfRectangle();
                    break;
            }
        }

        /*2.Write a program in C# to read n number of values in an array and display it in reverse order.
        Test Data :
        Input the number of elements to store in the array :3
        Input 3 number of elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 7
        Expected Output:
        The values store into the array are:
        2 5 7
        The values store into the array in reverse are :
        7 5 2*/

        static void ReverseArray()
        {
            Console.WriteLine("How big do you want your array to be?");
            int size = Int32.Parse(Console.ReadLine());

            int[] arrayToSort = new int[size];

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write($"Enter an element for your array {i}:\n");

                arrayToSort[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(arrayToSort);
            Console.WriteLine("Here is your sorted array:\n");

            for (int j = 0; j < arrayToSort.Length; j++)
            {
                Console.Write(arrayToSort[j]);

            }
            Console.ReadLine();
        }

        //3. Write a program to sort an integer array in ascending and descending order. Array can be created with hard coded values.
        //Use Bubble Sort.



            static void BubbleSort(int[] data)
            { 
                int temp;
                    for (int i = 0; i < data.Length; i++)
                        {
                            for (int j = 0; j < data.Length - 1; j++)
                                {
                                    if (data[j + 1] < data[j])
                                        {
                                            temp = data[j];
                                                data[j] = data[j + 1];
                                                    data[j + 1] = temp;
                                                }
                    
                                            }             
                                    }
                            }

            static void BubbleSortDescending(int[] data)
            {
                int temp;
                    for (int i = 0; i < data.Length; i++)
                        {
                            for (int j = 0; j < data.Length - 1; j++)
                                {
                                    if (data[j] < data[j + 1])
                                        {
                                            temp = data[j];
                                                data[j] = data[j + 1];
                                                    data[j + 1] = temp;
                                                }
                                            }
                                    }


            }

    }
}
