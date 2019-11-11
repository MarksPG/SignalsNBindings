using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            //using (var client = new HelloWorldServiceClient("ElsePipe"))
            //{
            //    client.Ping();
            //}



            sw.Start();
            //Console.WriteLine(client.GetMessage("Per Gustafsson"));
            //var client = new HelloWorldServiceClient("netTCPElseBinding");
            for (int i = 0; i < 1; i++)
            {

                var client = new HelloWorldServiceClient("ElseBasicHttp");
                client.Ping();
                



            }
            sw.Stop();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

        }
    }
}
