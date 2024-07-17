using MultipleInheritance.Models;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(false,1000,21,"Nimith");

            Console.WriteLine(employee.Greet());   // Manager (Parent class) function
            Console.WriteLine(employee.Greetings()); // function of employee class (child)
            Console.WriteLine(employee); // function of Stakeholder class
        }
    }
}
