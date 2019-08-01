using System;
using System.IO;
using System.Net;

namespace WebServer
{
    public class Server
    {
        HttpListenerContext context;
        Stream output;
        HttpListener web;
        public  void Request(URL uRL)
        {
            web = new HttpListener();

            web.Prefixes.Add("http://"+uRL.UrlName+":"+(uRL.Port).ToString()+"/");

            Console.WriteLine("Listening..");

            web.Start();
            context = web.GetContext();
            

        }
        public void Response(byte[] bytes)
        {
            var response = context.Response;
            response.ContentLength64 = bytes.Length;

            output = response.OutputStream;

            output.Write(bytes, 0, bytes.Length);
            output.Close();
        }
        public HttpListenerContext GetListener()
        {
            return context;
        }
        public void StopHttp()
        {
            web.Close();
        }
    }
    }

