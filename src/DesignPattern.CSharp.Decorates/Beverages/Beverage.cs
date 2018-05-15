using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Decorates.Beverages
{

    public class Beverage
    {
        protected Beverage beverage;
        public Beverage()
        {

        }
        protected Beverage(Beverage beverage, params Beverage[] beverages)
        {
            this.beverage = beverage;
            this.Description = $"{beverage.Description}, {string.Join(", ", beverages.Select(m => m.Description))}";
            this.Cost = beverage.Cost + beverages.Sum(m => m.Cost);
        }
        public string Description { get; protected set; } = "Unknown Beverage";
        public double Cost { get; protected set; } = 0;

        public Beverage Append(params Beverage[] adds)
        {
            return new Beverage(this, adds);
        }
        public Beverage Rollback()
        {
            return this.beverage;
        }
    }
}
