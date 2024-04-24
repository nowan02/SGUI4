using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI4.Model
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime Deadline { get; set; } 
        public bool IsImportant { get; set; }
        public string Description { get; set; }

        public Task(string name, DateTime deadline, bool isImportant, string descrition)
        {
            Name = name;
            Deadline = deadline;
            IsImportant = isImportant;
            Description = descrition;
        }

    }
}
