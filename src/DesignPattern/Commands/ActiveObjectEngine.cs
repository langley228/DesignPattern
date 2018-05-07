using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Commands
{

    public class ActiveObjectEngine
    {
        Queue<ICommand> itsCommands = new Queue<ICommand>();
        public void AddCommand(ICommand c)
        {
            itsCommands.Enqueue(c);
        }

        public void Run()
        {

            while (itsCommands.Count > 0) itsCommands.Dequeue().Execute();
        }

    }
}
