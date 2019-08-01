using System.Net.Sockets;
using System.Threading;

namespace WebServer
{

    public class Webserver
        {
            static void Main()
            {
            while (true)
            {
                var uRL = new URL();
                uRL.UrlName = "localhost";
                uRL.Port = 8080;
                Server server = new Server();
                server.Request(uRL);
                UrlParser urlParser = new UrlParser(server.GetListener());
                FileConversion fileConversion = new FileConversion();
                byte[] bytes = fileConversion.ConvertFileDataBytes(urlParser.GetFilenameFromUrl());
                if (bytes != null)
                {
                    server.Response(bytes);
                    server.StopHttp();
                }
                else
                {
                    server.StopHttp();
                }
            }

        }
        }
    }

