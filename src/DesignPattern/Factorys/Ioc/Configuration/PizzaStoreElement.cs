﻿using DesignPatternCSharp.Factorys.Ioc.PizzaFactories;
using DesignPatternCSharp.Factorys.Ioc.Pizzas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc.Configuration
{
    public class PizzaStoreElement : ConfigurationElement
    {
        [ConfigurationProperty("Key", DefaultValue = "PizzaStore", IsRequired = true)]
        public string Key
        {
            get { return (string)this["Key"]; }
            set { this["Key"] = value; }
        }
        [ConfigurationProperty("DisplayName", DefaultValue = "Pizza", IsRequired = true)]
        public string DisplayName
        {
            get { return (string)this["DisplayName"]; }
            set { this["DisplayName"] = value; }
        }
        [ConfigurationProperty("Pizzas"), ConfigurationCollection(typeof(PizzaCollection))]
        public PizzaCollection Pizzas
        {
            get { return this["Pizzas"] as PizzaCollection; }
            set { this["Pizzas"] = value; }
        }
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagnol slices");
        }

        public void Box()
        {
            Console.WriteLine("Placing pizza in official PizzaStore box......");
        }
        protected Pizza CreatePizza(string type)
        {
            Pizza pizza = new Pizza(this.Pizzas[type]);
            return pizza;
        }
    }
}