using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Observers.Birthdays
{

    public class Program
    {
        public static void Sample()
        {
            ICompany lustertech = new Company { Name = "達輝" };
            BirthdayData 達輝壽星快報 = new BirthdayData(lustertech);
            lustertech.Join(new Employee { Name = "昱良", Birthday = DateTime.Today });
            Employee Me = new Employee { Name = "Me" };
            lustertech.Join(Me);
            //訂閱達輝壽星快報 當日通知
            達輝壽星快報.RegisterObserver(Me, "昱良", 0);
            //觸發當日要發送的通知
            達輝壽星快報.DateChange();
        }
    }
}
