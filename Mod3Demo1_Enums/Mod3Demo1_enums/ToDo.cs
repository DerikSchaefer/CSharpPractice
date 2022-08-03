using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo1_enums
{
    enum Status
    {
        NotStarted = 1,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }

   
      

        internal class ToDo
    {

        public int TaskId { get; set; }

        public string Description { get; set; }

        public int EstimatedHours { get; set; }


        // Enum is a type here. The type is 'Status'
        public Status Status { get; set; }
    }
}
