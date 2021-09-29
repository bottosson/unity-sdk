using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     A general-purpose UploadHandler subclass, using a native-code memory buffer.
    public sealed class UploadHandlerRaw : UploadHandler
    {
        //
        // Summary:
        //     General constructor. Contents of the input argument are copied into a native
        //     buffer.
        //
        // Parameters:
        //   data:
        //     Raw data to transmit to the remote server.
        public UploadHandlerRaw(byte[] data) { throw new NotImplementedException(); }
    }
}
