using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc.Configuration
{
    public class PizzaStoreData : ConfigurationSection
    {
        [ConfigurationProperty("PizzaStores"), ConfigurationCollection(typeof(PizzaStoreElement))]
        public PizzaStoreCollection PizzaStores
        {
            get { return this["PizzaStores"] as PizzaStoreCollection; }
            set { this["PizzaStores"] = value; }
        }
    }
}
