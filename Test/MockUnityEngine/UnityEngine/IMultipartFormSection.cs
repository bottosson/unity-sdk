using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.Networking
{
    public interface IMultipartFormSection
    {
        //
        // Summary:
        //     Returns the name of this section, if any.
        //
        // Returns:
        //     The section's name, or null.
        string sectionName { get; }
        //
        // Summary:
        //     Returns the raw binary data contained in this section. Must not return null or
        //     a zero-length array.
        //
        // Returns:
        //     The raw binary data contained in this section. Must not be null or empty.
        byte[] sectionData { get; }
        //
        // Summary:
        //     Returns a string denoting the desired filename of this section on the destination
        //     server.
        //
        // Returns:
        //     The desired file name of this section, or null if this is not a file section.
        string fileName { get; }
        //
        // Summary:
        //     Returns the value to use in the Content-Type header for this form section.
        //
        // Returns:
        //     The value to use in the Content-Type header, or null.
        string contentType { get; }
    }
}
