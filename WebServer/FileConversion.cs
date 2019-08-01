using System;
using System.IO;

namespace WebServer
{
    public class FileConversion
    {
       
        public byte[] ConvertFileDataBytes(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                byte[] bytes = System.IO.File.ReadAllBytes(filename);

                fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                return bytes;
            }
            catch(Exception e)
            {
                Console.WriteLine("FileNotFound");
                byte[] bytes = null;
                return bytes;
            }
        }
    }
    }

