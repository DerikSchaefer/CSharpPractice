using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{
    internal class Student : Person
    {

        public string Subject
        {
            get;
            set;
        }

        public char Grade
        {
            get;
            set;
        }

        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("I am learning C#");
        }

        public override void FollowSchedule()
        {

            Console.WriteLine("I study from 10 to 8");
        }

    }
}