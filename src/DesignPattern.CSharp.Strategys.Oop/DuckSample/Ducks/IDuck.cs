using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Strategys.Oop.DuckSample
{
    public interface IDuck
    {
        /// <summary>
        /// 鴨子的游泳行為
        /// </summary>
        void Swim();
        /// <summary>
        /// 鴨子的飛行行為
        /// </summary>
        IFly Fly { get; }
        /// <summary>
        /// 鴨子的叫聲行為
        /// </summary>
        IQuack Quack { get;}

        /// <summary>
        /// 鴨子的外觀
        /// </summary>
        void Display();
        
    }
}
