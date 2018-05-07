using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.OopAndFp
{
    public static class QuackFactory
    {
        /// <summary>
        /// 沒有叫聲的行為
        /// </summary>
        public static void MuteQuack()
        {
            Console.WriteLine("I say ...(Silence)");
        }
        /// <summary>
        /// 呱呱叫的行為
        /// </summary>
        public static void Quack()
        {
            Console.WriteLine("I say Quack");
        }
        /// <summary>
        /// 吱吱叫的行為
        /// </summary>
        public static void Squeak()
        {
            Console.WriteLine("I say Squeak");
        }
    }
}
