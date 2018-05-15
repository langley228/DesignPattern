using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Observers.Birthdays
{

    public class Company : ICompany
    {
        private List<Employee> MyEmployee = new List<Employee>();
        public event Action<Employee> ResignEvent;
        public string Name { get; set; }
        public void Join(Employee emp)
        {
            MyEmployee.Add(emp);
        }
        public void Resign(Employee emp)
        {
            MyEmployee.Remove(emp);
            ResignEvent(emp);
        }
        public bool IsMyEmployee(Employee emp)
        {
            return MyEmployee.Any(myEmp => myEmp.Equals(emp));
        }
        public bool IsMyEmployee(string name)
        {
            return MyEmployee.Any(myEmp => myEmp.Name == name);
        }
        public Employee FindEmployee(string name)
        {
            return MyEmployee.FirstOrDefault(myEmp => myEmp.Name == name);
        }
    }
}
