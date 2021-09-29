using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     Manage and process HTTP response body data received from a remote server.
    public class DownloadHandler
    {
        //
        // Summary:
        //     Convenience property. Returns the bytes from data interpreted as a UTF8 string.
        //     (Read Only)
        public string text { get; internal set; }
        //
        // Summary:
        //     Callback, invoked when the data property is accessed.
        //
        // Returns:
        //     Byte array to return as the value of the data property.
        protected virtual byte[] GetData() { throw new NotImplementedException(); }
    }
}
