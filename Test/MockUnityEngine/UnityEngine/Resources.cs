using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public sealed class Resources
    {
        public static T Load<T>(string path) where T : Object, new() { return new T(); }
    }
}
