using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.Ioc.Configuration
{ 
    public class PizzaStoreCollection : ConfigurationElementCollection
    {
        public PizzaStoreElement this[string key]
        {
            get { return (PizzaStoreElement)this.BaseGet(key); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new PizzaStoreElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PizzaStoreElement)element).Key;
        }

    }
}
