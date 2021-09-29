using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Net;
using System.IO;

namespace UnityEngine.Networking
{
    //
    // Summary:
    //     The UnityWebRequest object is used to communicate with web servers.
    public class UnityWebRequest : IDisposable
    {
        HttpWebRequest m_request = null;
        HttpWebResponse m_response = null;
        public void Dispose() {}

        //
        // Summary:
        //     The string "GET", commonly used as the verb for an HTTP GET request.
        public const string kHttpVerbGET = "GET";
        //
        // Summary:
        //     The string "HEAD", commonly used as the verb for an HTTP HEAD request.
        public const string kHttpVerbHEAD = "HEAD";
        //
        // Summary:
        //     The string "POST", commonly used as the verb for an HTTP POST request.
        public const string kHttpVerbPOST = "POST";
        //
        // Summary:
        //     The string "PUT", commonly used as the verb for an HTTP PUT request.
        public const string kHttpVerbPUT = "PUT";
        //
        // Summary:
        //     The string "CREATE", commonly used as the verb for an HTTP CREATE request.
        public const string kHttpVerbCREATE = "CREATE";
        //
        // Summary:
        //     The string "DELETE", commonly used as the verb for an HTTP DELETE request.
        public const string kHttpVerbDELETE = "DELETE";

        //
        // Summary:
        //     Defines the HTTP verb used by this UnityWebRequest, such as GET or POST.
        public string method 
        { 
            get
            {
                return m_request.Method;
            }
            set 
            {
                m_request.Method = value;
            }
        }
        //
        // Summary:
        //     Returns true after this UnityWebRequest receives an HTTP response code indicating
        //     an error. (Read Only)
        [Obsolete("UnityWebRequest.isHttpError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ProtocolError) instead.", false)]
        public bool isHttpError { get; }
        //
        // Summary:
        //     The numeric HTTP response code returned by the server, such as 200, 404 or 500.
        //     (Read Only)
        public long responseCode { get; }
        //
        // Summary:
        //     Defines the target URI for the UnityWebRequest to communicate with.
        public Uri uri { get; set; }

        //
        // Summary:
        //     Determines whether this UnityWebRequest will include Expect: 100-Continue in
        //     its outgoing request headers. (Default: true).
        public bool useHttpContinue { get; set; }
        //
        // Summary:
        //     A human-readable string describing any system errors encountered by this UnityWebRequest
        //     object while handling HTTP requests or responses. (Read Only)
        public string error { get; }
        //
        // Summary:
        //     Returns true after this UnityWebRequest encounters a system error. (Read Only)
        [Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", false)]
        public bool isNetworkError { get; }

        //
        // Summary:
        //     Holds a reference to a DownloadHandler object, which manages body data received
        //     from the remote server by this UnityWebRequest.
        public DownloadHandler downloadHandler { get; set; }
        //
        // Summary:
        //     Holds a reference to the UploadHandler object which manages body data to be uploaded
        //     to the remote server.
        public UploadHandler uploadHandler { get; set; }
        
        //
        // Summary:
        //     Returns true after the UnityWebRequest has finished communicating with the remote
        //     server. (Read Only)
        public bool isDone { get { return m_response != null; } }
        //
        // Summary:
        //     Creates a UnityWebRequest configured for HTTP DELETE.
        //
        // Parameters:
        //   uri:
        //     The URI to which a DELETE request should be sent.
        //
        // Returns:
        //     A UnityWebRequest configured to send an HTTP DELETE request.
        public static UnityWebRequest Delete(string uri) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Generate a random 40-byte array for use as a multipart form boundary.
        //
        // Returns:
        //     40 random bytes, guaranteed to contain only printable ASCII values.
        public static byte[] GenerateBoundary() { throw new NotImplementedException(); }

        //
        // Summary:
        //     Create a UnityWebRequest for HTTP GET.
        //
        // Parameters:
        //   uri:
        //     The URI of the resource to retrieve via HTTP GET.
        //
        // Returns:
        //     An object that retrieves data from the uri.
        public static UnityWebRequest Get(string uri) { throw new NotImplementedException(); }
        
        //
        // Summary:
        //     Create a UnityWebRequest configured to send form data to a server via HTTP POST.
        //
        // Parameters:
        //   uri:
        //     The target URI to which form data will be transmitted.
        //
        //   formData:
        //     Form fields or files encapsulated in a WWWForm object, for formatting and transmission
        //     to the remote server.
        //
        // Returns:
        //     A UnityWebRequest configured to send form data to uri via POST.
        public static UnityWebRequest Post(string uri, WWWForm formData) { throw new NotImplementedException(); }

        //
        // Summary:
        //     Creates a UnityWebRequest configured to upload raw data to a remote server via
        //     HTTP PUT.
        //
        // Parameters:
        //   uri:
        //     The URI to which the data will be sent.
        //
        //   bodyData:
        //     The data to transmit to the remote server. If a string, the string will be converted
        //     to raw bytes via <a href="https:msdn.microsoft.comen-uslibrarysystem.text.encoding.utf8">System.Text.Encoding.UTF8<a>.
        //
        // Returns:
        //     A UnityWebRequest configured to transmit bodyData to uri via HTTP PUT.
        public static UnityWebRequest Put(string uri, byte[] bodyData) 
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.ContentType = "application/xml";
            if (bodyData != null)
            {
                request.ContentLength = bodyData.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(bodyData);
                dataStream.Close();
            }

            return new UnityWebRequest { m_request = request };
        }
        
        public static byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, byte[] boundary) { throw new NotImplementedException(); }
        
        //
        // Summary:
        //     Begin communicating with the remote server.
        public UnityWebRequestAsyncOperation SendWebRequest()
        {
            // Todo: consider doing this async instead, with GetResponseAsync
            // Todo: none of the SDK error handling is used, since this will throw an uncaught exception on error
            m_response = (HttpWebResponse)m_request.GetResponse();
            using (var reader = new StreamReader(m_response.GetResponseStream()))
            {
                downloadHandler.text = reader.ReadToEnd();
            }
            return new UnityWebRequestAsyncOperation();
        }
        //
        // Summary:
        //     Set a HTTP request header to a custom value.
        //
        // Parameters:
        //   name:
        //     The key of the header to be set. Case-sensitive.
        //
        //   value:
        //     The header's intended value.
        public void SetRequestHeader(string name, string value)
        {
            m_request.Headers[name] = value;
        }

        //
        // Summary:
        //     Defines codes describing the possible outcomes of a UnityWebRequest.
        public enum Result
        {
            //
            // Summary:
            //     The request hasn't finished yet.
            InProgress = 0,
            //
            // Summary:
            //     The request succeeded.
            Success = 1,
            //
            // Summary:
            //     Failed to communicate with the server. For example, the request couldn't connect
            //     or it could not establish a secure channel.
            ConnectionError = 2,
            //
            // Summary:
            //     The server returned an error response. The request succeeded in communicating
            //     with the server, but received an error as defined by the connection protocol.
            ProtocolError = 3,
            //
            // Summary:
            //     Error processing data. The request succeeded in communicating with the server,
            //     but encountered an error when processing the received data. For example, the
            //     data was corrupted or not in the correct format.
            DataProcessingError = 4
        }
    }
}
