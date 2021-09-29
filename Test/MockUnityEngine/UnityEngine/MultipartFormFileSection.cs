using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     A helper object for adding file uploads to multipart forms via the [IMultipartFormSection]
    //     API.
    public class MultipartFormFileSection : IMultipartFormSection
    {
        //
        // Summary:
        //     Contains a named file section based on the raw bytes from data, with a custom
        //     Content-Type and file name.
        //
        // Parameters:
        //   name:
        //     Name of this form section.
        //
        //   data:
        //     Raw contents of the file to upload.
        //
        //   fileName:
        //     Name of the file uploaded by this form section.
        //
        //   contentType:
        //     The value for this section's Content-Type header.
        public MultipartFormFileSection(string name, byte[] data, string fileName, string contentType) { throw new NotImplementedException(); }

        //
        // Summary:
        //     Returns the name of this section, if any.
        //
        // Returns:
        //     The section's name, or null.
        public string sectionName { get; }
        //
        // Summary:
        //     Returns the raw binary data contained in this section. Will not return null or
        //     a zero-length array.
        //
        // Returns:
        //     The raw binary data contained in this section. Will not be null or empty.
        public byte[] sectionData { get; }
        //
        // Summary:
        //     Returns a string denoting the desired filename of this section on the destination
        //     server.
        //
        // Returns:
        //     The desired file name of this section, or null if this is not a file section.
        public string fileName { get; }
        //
        // Summary:
        //     Returns the value of the section's Content-Type header.
        //
        // Returns:
        //     The Content-Type header for this section, or null.
        public string contentType { get; }
    }
}
