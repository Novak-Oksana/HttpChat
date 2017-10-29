using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    class Program
    {

        static void Main(string[] args)
        {
            HttpServer server = new HttpServer("http://localhost:8888/");
            //  HttpServer server = new HttpServer("192.168.0.118", 9050);
            server.Start();
        }
    }

}
