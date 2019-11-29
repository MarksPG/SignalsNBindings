using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace HelloWorldClient
{
    class Program
    {
        //private static EventWaitHandle ewh;

        static void Main(string[] args)
        {
            //    Stopwatch sw = new Stopwatch();

            //    //using (var client = new HelloWorldServiceClient("ElsePipe"))
            //    //{
            //    //    client.Ping();
            //    //}



            //    sw.Start();
            //    //Console.WriteLine(client.GetMessage("Per Gustafsson"));
            //    //var client = new HelloWorldServiceClient("netTCPElseBinding");
            for (int i = 0; i < 30; i++)
            {

                var client = new HelloWorldServiceClient("ElseBasicHttp");

                Thread.Sleep(1000);
                client.Ping();
                Console.WriteLine("Pinged {0}", i);



            }
            //    sw.Stop();
            //    Console.WriteLine("Elapsed={0}", sw.Elapsed)

            //}

            //static void Main(string[] args)
            //{
            //    Stopwatch sw = new Stopwatch();

            //    ewh = new EventWaitHandle(false, EventResetMode.AutoReset, "elseReset");
            //    sw.Start();
            //    for (int i = 0; i < 100000; i++)
            //    {
            //        Thread.Sleep(1);
            //        ewh.Set();
            //    }
            //    sw.Stop();
            //    Console.WriteLine("Elapsed={0}", sw.Elapsed);


            //}
        }
    }
}
