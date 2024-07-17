using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Models
{
    internal class Employee : Manager
    {
        public bool IsMarried { get; set; }
        public Employee(bool isMarried, int id, int age, string name) : base(id, age, name)
        {
            IsMarried = isMarried;
        }

        public string Greetings()
        {
            return "Hello sir how are you?";
        }
    }
}

