using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Commands
{

    public class SleepCommand : ICommand
    {

        ICommand wakeupCommand;

        ActiveObjectEngine engine;

        long sleepTime;

        long startTime;

        bool started;

        public SleepCommand(long milliseconds, ActiveObjectEngine e, ICommand wakeupCommand)
        {

            sleepTime = milliseconds;

            engine = e;

            this.wakeupCommand = wakeupCommand;

        }

        public void Execute()
        {

            long currentTime = DateTime.Now.Ticks / Pub.TicksPerMillisecond;

            if (!started)
            {

                started = true;

                startTime = currentTime;

                engine.AddCommand(this);

            }

            else if ((currentTime - startTime) < sleepTime)
            {

                this.Execute();
            }

            else
            {

                engine.AddCommand(wakeupCommand);

            }

        }

    }
}
