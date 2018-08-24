using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground2.SimpleFactory
{
    public class HttpRequestFactory
    {
        public static IHttpRequest CreateRequest(string method, string url, string[] customHeaders,
            string mimeType = "*/*", string body = null)
        {
            if (new string[] { "get", "options", "head" }.Contains(method))
            {
                return new HttpRequest(method, url, customHeaders);
            }

            return new HttpRequestWithBody(method, url, customHeaders,
            mimeType, body);
        }
    }

    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string method, string url, string[] customHeaders)
        {
            this.Method = method;
            this.Url = url;
            this.Headers = new Dictionary<string, string>();


            for (int i = 0; i < customHeaders.Length; i++)
            {
                this.Headers.Add(customHeaders[i],
                    customHeaders[i + 1]);
            }
        }

        public string Method
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Url
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public IDictionary<string, string> Headers
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }

    public class HttpRequestWithBody : HttpRequest, IHttpRequest, IHttpRequestWithBody
    {
        public HttpRequestWithBody(string method, string url, string[] customHeaders,
            string mimeType, string body)
            : base(method, url, customHeaders)
        {
            this.Body = body;
            this.MimeType = mimeType;
        }

        public string Body
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string MimeType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }


    public interface IHttpRequest
    {
        string Method { get; set; }

        string Url { get; set; }

        IDictionary<string, string> Headers { get; set; }
    }

    public interface IHttpRequestWithBody : IHttpRequest
    {
        string Body { get; set; }

        string MimeType { get; set; }
    }
}
