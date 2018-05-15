using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Commands
{

    public interface ICommand
    {

        void Execute();
    }

    public static class Pub
    {

        public static long TicksPerMillisecond = 10000;

    }
}
