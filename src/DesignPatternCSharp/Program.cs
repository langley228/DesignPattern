using DesignPatternCSharp.Factorys.Ioc.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp
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
            //ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            //string path = string.Format(@"{0}\{1}.config", System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase, m_Filename);

        }
    }
}
