using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBatchDemo
{
    public class Employee
    {
        //Variable
        int idNo;
        string name;
        //Property
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee() // //Default constructor
        {
            Console.WriteLine("Default constructor");
            
        }
        public Employee(int Id) //Parametric constructor
        {
            this.Id =Id;
        }
        //Method
        public void Method1()
        {
            Console.WriteLine("id "+idNo);
            Console.WriteLine("Name "+name);
        }
        public int Method2()
        {
            int a = 80;
            return a;
        }
        public string Method3(string deperatment)
        {
            return deperatment;
        }
    }
}
