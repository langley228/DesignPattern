using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Commands
{

    public class Program
    {
        public static void Sample()
        {
            ICommand wakeup = new WakeupCommand();

            ActiveObjectEngine e = new ActiveObjectEngine();

            SleepCommand c = new SleepCommand(1000, e, wakeup);



            e.AddCommand(c);

            long start = DateTime.Now.Ticks / Pub.TicksPerMillisecond;

            e.Run();

        }

    }
}
