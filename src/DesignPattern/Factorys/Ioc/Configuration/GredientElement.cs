using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc.Configuration
{
    public abstract class GredientElement : ConfigurationElement,IGredient
    {
        private IGredient pri ;
        private readonly string _createNamespace = "DesignPatternCSharp.Factorys.Ioc";
        [ConfigurationProperty("className", DefaultValue = "Dough", IsRequired = true)]
        public string className
        {
            get { return (string)this["className"]; }
            set { this["className"] = value; }
        }

        public abstract string Name { get; }
        private object Create(string namespaceType, string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;
            else
                return Create($"{_createNamespace}.{namespaceType}.{name}");

        }
        private static object Create(string className, object[] args = null)
        {
            Assembly asmb = typeof(DoughElement).Assembly;
            return asmb.CreateInstance(className, true, BindingFlags.CreateInstance, null, args, null, null);
        }
    }
}
