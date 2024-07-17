using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MultipleInheritance.Models
{
    class Stakeholder
    {
        public int Age { get; set; }

        public string Name { get; set; }


        public Stakeholder(int age , string name) { 
            Age = age;
            Name = name;
        }
        public override string ToString()
        {
            return $"Age = {Age}\n" +
                $"Name = {Name}";
        }
    }

    

}
