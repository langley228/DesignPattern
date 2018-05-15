using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Observers.Birthdays
{

    public interface ICompany
    {
        void Join(Employee emp);
        void Resign(Employee emp);
        bool IsMyEmployee(Employee emp);
        bool IsMyEmployee(string name);
        Employee FindEmployee(string name);
        event Action<Employee> ResignEvent;
    }
}
