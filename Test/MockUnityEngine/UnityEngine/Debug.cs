using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Debug
    {
        public static void Log(object message) 
        { 
            Console.WriteLine(message); 
        }
        public static void LogError(object message) 
        {
            Console.Write("ERROR: ");
            Console.WriteLine(message); 
        }
    }
}
