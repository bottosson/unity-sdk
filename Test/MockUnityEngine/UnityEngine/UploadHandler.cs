using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     Helper object for UnityWebRequests. Manages the buffering and transmission of
    //     body data during HTTP requests.
    public class UploadHandler
    {
        //
        // Summary:
        //     The raw data which will be transmitted to the remote server as body data. (Read
        //     Only)
        public byte[] data { get; }
        //
        // Summary:
        //     Determines the default Content-Type header which will be transmitted with the
        //     outbound HTTP request.
        public string contentType { get; set; }
    }
}
