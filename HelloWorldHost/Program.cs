using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Threading;

namespace HelloWorldHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(HelloWorldService.HelloWorldService), new Uri("http://localhost:55859/HelloWorldHost/HelloWorldService.svc"));
            host.Open();
            Console.WriteLine("HelloWorldService is now running. ");
            Console.WriteLine("Press any key to stop it...");


            while (true)
            {
                if (!HelloWorldService.HelloWorldService.elseReset.WaitOne(3000))
                {
                    Console.WriteLine("No ping for 3 seconds");
                }
            }

            //var ewh = new EventWaitHandle(false, EventResetMode.AutoReset, "elseReset");
            //int i = 0;
            //while (true)
            //{
            //    if(ewh.WaitOne(3000))
            //    {
            //        i++;
            //        if (i % 1000 == 0)
            //        {
            //            Console.WriteLine("Ping!!");
            //        }
                    
                    

            //    }
            //    else
            //    {
            //        Console.WriteLine("No ping for 3 seconds");
            //    }
            
            //}






            Console.ReadKey();
            host.Close();
        }
    }
}
