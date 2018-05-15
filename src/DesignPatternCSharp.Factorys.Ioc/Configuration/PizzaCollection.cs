using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc.Configuration
{
    public class PizzaCollection : ConfigurationElementCollection
    {
        public PizzaElement this[string key]
        {
            get { return (PizzaElement)this.BaseGet(key); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new PizzaElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PizzaElement)element).Key;
        }
    }
}
