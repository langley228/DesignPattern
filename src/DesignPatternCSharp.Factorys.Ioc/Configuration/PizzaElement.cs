using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc.Configuration
{

    public class PizzaElement : ConfigurationElement
    {
        [ConfigurationProperty("Key", DefaultValue = "Pizza", IsRequired = true)]
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
        [ConfigurationProperty("Dough", DefaultValue = "Dough", IsRequired = true)]
        public string Dough
        {
            get { return (string)this["Dough"]; }
            set { this["Dough"] = value; }
        }
        [ConfigurationProperty("Sauce", DefaultValue = "Sauce", IsRequired = true)]
        public string Sauce
        {
            get { return (string)this["Sauce"]; }
            set { this["Sauce"] = value; }
        }
        [ConfigurationProperty("Cheese", DefaultValue = "Cheese", IsRequired = true)]
        public string Cheese
        {
            get { return (string)this["Cheese"]; }
            set { this["Cheese"] = value; }
        }
        [ConfigurationProperty("Clams", DefaultValue = "Clams", IsRequired = true)]
        public string Clams
        {
            get { return (string)this["Clams"]; }
            set { this["Clams"] = value; }
        }

    }
}
