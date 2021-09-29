using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    //
    // Summary:
    //     Use this PropertyAttribute to add a header above some fields in the Inspector.
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class HeaderAttribute : System.Attribute
    {
        //
        // Summary:
        //     The header text.
        public readonly string header;

        //
        // Summary:
        //     Add a header above some fields in the Inspector.
        //
        // Parameters:
        //   header:
        //     The header text.
        public HeaderAttribute(string header) { this.header = header; }
    }
  
}
