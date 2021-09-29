using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Object
    {
        public Object()
        {
            s_objects[GetType()] = this;
        }
        public static T FindObjectOfType<T>() where T : Object
        {
            Object result;
            if (s_objects.TryGetValue(typeof(T), out result))
                return (T)result;
            else
                return null;
        }

        static Dictionary<Type, Object> s_objects = new Dictionary<Type, Object>();
    }
}
