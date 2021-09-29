using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    //
    // Summary:
    //     Helper class to generate form data to post to web servers using the UnityWebRequest
    //     or WWW classes.
    public class WWWForm
    {
        //
        // Summary:
        //     Creates an empty WWWForm object.
        public WWWForm() { }

        //
        // Summary:
        //     Add binary data to the form.
        //
        // Parameters:
        //   fieldName:
        //
        //   contents:
        //
        //   fileName:
        //
        //   mimeType:
        public void AddBinaryData(string fieldName, byte[] contents, string fileName) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Add a simple field to the form.
        //
        // Parameters:
        //   fieldName:
        //
        //   value:
        //
        //   e:
        public void AddField(string fieldName, string value) { throw new NotImplementedException(); }
    }
}
