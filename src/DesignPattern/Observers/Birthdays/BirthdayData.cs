using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Observers.Birthdays
{

    public class BirthdayData
    {
        private ICompany MyCompany;
        private List<SubjectData> NotifyList = new List<SubjectData>();
        public BirthdayData(ICompany company)
        {
            MyCompany = company;
            MyCompany.ResignEvent += MyCompany_ResignEvent;
        }

        private void MyCompany_ResignEvent(Employee emp)
        {
            NotifyList.RemoveAll(subject => subject.Support.Equals(emp) || subject.HowName == emp.Name);
        }

        public void DateChange()
        {
            NotifyObservers();

        }
        public void NotifyObservers()
        {
            NotifyList.ForEach(subject =>
            {
                Employee find = MyCompany.FindEmployee(subject.HowName);
                if (find != null && IsToday(find, subject.BeforehandDays))
                    subject.Support.Callme($"{subject.HowName} 生日快到了!");
            });
        }
        public bool IsToday(Employee emp, int BeforehandDays)
        {
            return DateTime.Today == emp.Birthday.Date.AddDays(BeforehandDays);
        }


        public void RegisterObserver(Employee observer, string howName, int beforehandDays)
        {
            if (MyCompany.IsMyEmployee(observer) && MyCompany.IsMyEmployee(howName))
                NotifyList.Add(new SubjectData
                {
                    Support = observer,
                    HowName = howName,
                    BeforehandDays = beforehandDays
                });
        }

        public void RemoveObserver(Employee observer, string howName)
        {
            NotifyList.RemoveAll(n => n.Support.Equals(observer) && n.HowName == howName);
        }

    }
}
