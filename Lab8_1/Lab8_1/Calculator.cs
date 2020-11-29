using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    class Calculator
    {
        public string Name { get; set; }
        public string TaskType { get; set; }
        public Calculator()
        {

        }
        public Calculator(string name, string taskType)
        {
            this.Name = name;
            this.TaskType = taskType;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Task Type :" + TaskType);
            Console.WriteLine("---------------------");
        }
    }
}
