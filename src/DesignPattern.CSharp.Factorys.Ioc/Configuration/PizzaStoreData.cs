﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.Ioc.Configuration
{
    public class PizzaStoreData : ConfigurationSection
    {
        [ConfigurationProperty("PizzaStores"), ConfigurationCollection(typeof(PizzaStoreElement), AddItemName = "PizzaStore")]
        public PizzaStoreCollection PizzaStores
        {
            get { return this["PizzaStores"] as PizzaStoreCollection; }
            set { this["PizzaStores"] = value; }
        }
    }
}
