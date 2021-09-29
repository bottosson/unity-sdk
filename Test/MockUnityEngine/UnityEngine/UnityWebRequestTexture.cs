using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     Helpers for downloading image files into Textures using UnityWebRequest.
    public static class UnityWebRequestTexture
    {
        //
        // Summary:
        //     Create a UnityWebRequest intended to download an image via HTTP GET and create
        //     a Texture based on the retrieved data.
        //
        // Parameters:
        //   uri:
        //     The URI of the image to download.
        //
        //   nonReadable:
        //     If true, the texture's raw data will not be accessible to script. This can conserve
        //     memory. Default: false.
        //
        // Returns:
        //     A UnityWebRequest properly configured to download an image and convert it to
        //     a Texture.
        public static UnityWebRequest GetTexture(string uri) { throw new NotImplementedException(); }
    }
}
