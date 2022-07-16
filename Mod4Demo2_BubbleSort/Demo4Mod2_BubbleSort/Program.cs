using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Mod2_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 100, 23, 150, 2, 12 };
            BubbleSort(numbers);
            Console.WriteLine("Sorted list is:");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static void BubbleSort(int []data)
        {
            int temp;
            for (int i = 0; i < data.Length; i++)  // This outer for loop is what makes sure that the array iterates over itself again
                //after the first full iteration. In this example 150 would bubble up to the top but it's not completely sorted so it needs
                // to restart. 
          
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
             
            Console.ReadLine();
            }
       



        }
    }
}
