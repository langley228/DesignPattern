using DesignPattern.CSharp.Factorys.Ioc.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorys.Ioc.Program.Sample();
            Factorys.AbstractFactories.Program.Sample();
            Strategys.Oop.Program.Sample();
            Strategys.OopAndFp.Program.Sample();
            Decorates.Beverages.Program.Sample();
            Observers.Weathers.Oop.Program.Sample();
            Observers.Weathers.OopAndFp.Program.Sample();
            Observers.Birthdays.Program.Sample();
            Factorys.SimpleFactories.Beverages.Program.Sample();
            Commands.Program.Sample();
            Console.ReadLine();
        }
    }
}
