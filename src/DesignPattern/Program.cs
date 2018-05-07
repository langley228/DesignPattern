using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategys.Oop.Program.Sample();
            Strategys.OopAndFp.Program.Sample();
            Decorates.Beverages.Program.Sample();
            Observers.Birthdays.Program.Sample();
            Factorys.SimpleFactorys.Beverages.Program.Sample();
            Commands.Program.Sample();
        }
    }
}
