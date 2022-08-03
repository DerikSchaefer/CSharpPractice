using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mod3Demo1_enums
{

    enum Days
    {
        Monday=40,
        Tuesday=40,
        Wednesday=50,  
        Thursday,   
        Friday,
        Saturday,
        Sunday,
    }

    
   

    internal class Program
    {





        static void Main(string[] args)
        {

            ArrayList todoList = new ArrayList()
            {
                new ToDo{TaskId = 1, Description = "Do assignment 4.4", EstimatedHours = 2,  Status = Status.NotStarted },
                 new ToDo{TaskId = 2, Description = "Do assignment 4.5", EstimatedHours = 2,Status = Status.Completed },
                 new ToDo{TaskId = 3, Description = "Do assignment 4.6", EstimatedHours = 2,Status = Status.Deleted },
                 new ToDo{TaskId = 4, Description = "Do assignment 4.7", EstimatedHours = 2,Status = Status.OnHold },
                  new ToDo{TaskId = 5, Description = "Do assignment 4.8", EstimatedHours = 2, Status = Status.InProgress }
            };

           todoList.Add(new ToDo() { TaskId = 6, Description = "Do assignment 4.9", EstimatedHours = 2, Status = Status.InProgress });
            PrintTodos(todoList);
            Console.ReadLine();
        }

        static void PrintTodos(ArrayList todos)
        {
            foreach (var todo in todos)
            {
                ToDo task = (ToDo) todo;
            

                switch(task.Status)
                {
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
                Console.WriteLine(task.Description + " " + task.EstimatedHours);
            }
        }
    }
}
