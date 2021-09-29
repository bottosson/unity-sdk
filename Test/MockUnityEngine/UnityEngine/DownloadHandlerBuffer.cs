using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     A general-purpose DownloadHandler implementation which stores received data in
    //     a native byte buffer.
    public sealed class DownloadHandlerBuffer : DownloadHandler
    {
        //
        // Summary:
        //     Default constructor.
        public DownloadHandlerBuffer() {}

        //
        // Summary:
        //     Returns a copy of the contents of the native-memory data buffer as a byte array.
        //
        // Returns:
        //     A copy of the data which has been downloaded.
        protected override byte[] GetData() { throw new NotImplementedException(); }
    }
}