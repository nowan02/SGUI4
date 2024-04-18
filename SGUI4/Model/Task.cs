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
        public int Deadline { get; set; } //num of days left
        public string Type { get; set; } //Important / Not Important
        public string Description { get; set; } //extra thing

        public Task(string name, int deadline, string type, string descrition)
        {
            Name = name;
            Deadline = deadline;
            Type = type;
            Description = descrition;
        }

    }
}
