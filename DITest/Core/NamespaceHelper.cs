using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Core
{
	public class NamespaceHelper
	{
        public static List<Type> FindTypesOfObject(object instance)
        {
            string type = instance.GetType().Name;
            var result = instance.GetType()
                .Assembly.GetTypes()
                .Where(v => v.BaseType != null && v.BaseType.Name.Equals(type))
                .ToList();
            return result;
        }

        public static List<T> InstantiateTypesOfObject<T>(object instance)
        {
            List<T> instances = new List<T>();

            foreach (Type t in FindTypesOfObject(instance))
            {
                if (t.IsSubclassOf(typeof(T)))
                {
                    T i = (T)Activator.CreateInstance(t);
                    instances.Add(i);
                }
            }

            return instances;
        }
    }
}
