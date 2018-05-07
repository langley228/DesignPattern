using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop
{
    /// <summary>
    /// 鴨子抽象類別
    /// </summary>
    public abstract class Duck : IDuck
    {
        public Duck(IFly fly, IQuack quack)
        {
            Fly = fly;
            Quack = quack;
        }
        /// <summary>
        /// 鴨子的飛行行為
        /// </summary>
        public IFly Fly { get; protected set; }
        /// <summary>
        /// 鴨子的叫聲行為
        /// </summary>
        public IQuack Quack { get; protected set; }
        /// <summary>
        /// 鴨子的游泳行為
        /// </summary>
        /// <remarks>所有的鴨子都用相同的方式游泳，所以由超類別負責處理這部份的程式</remarks>
        public void Swim()
        {
            Console.WriteLine("All duck s float, even decoys");
        }
        

        /// <summary>
        /// 鴨子的外觀
        /// </summary>
        /// <remarks>因為每隻鴨子的外觀不同，所以display()方法是抽象的</remarks>
        public abstract void Display();

        
    }
}
