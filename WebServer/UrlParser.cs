using System.Net;

namespace WebServer
{
    public class UrlParser
    {
        HttpListenerContext context;
        public UrlParser(HttpListenerContext context)
        {
            this.context = context;
        }
        public string GetFilenameFromUrl()
        {
            string filename = context.Request.RawUrl;
            return filename.Remove(0, 1);
        }
    }
    }

