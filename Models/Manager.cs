using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Models
{
    internal class Manager:Stakeholder
    {
        

        
            public int Id { get; set; }
            public Manager(int id, int age, string name) : base(age, name)
            {
                Id = id;
            }

            public string Greet()
            {
                return "Hello!! Greetings from the Manager";
            }


        }

        
    }

