using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Observers.Birthdays
{

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public void Callme(string msg)
        {
            Console.WriteLine($"{Name} 你好, {msg}");
        }
    }


}
