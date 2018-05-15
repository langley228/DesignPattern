using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Commands
{
    public class WakeupCommand : ICommand
    {
        static bool commandExecuted;

        public void Execute()
        {
            commandExecuted = true;
        }
    }
}
