using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     A DownloadHandler subclass specialized for downloading images for use as Texture
    //     objects.
    public sealed class DownloadHandlerTexture : DownloadHandler
    {
        //
        // Summary:
        //     Returns the downloaded Texture, or null.
        //
        // Parameters:
        //   www:
        //     A finished UnityWebRequest object with DownloadHandlerTexture attached.
        //
        // Returns:
        //     The same as DownloadHandlerTexture.texture
        public static Texture2D GetContent(UnityWebRequest www) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Called by DownloadHandler.data. Returns a copy of the downloaded image data as
        //     raw bytes.
        //
        // Returns:
        //     A copy of the downloaded data.
        protected override byte[] GetData() { throw new NotImplementedException(); }
    }
}