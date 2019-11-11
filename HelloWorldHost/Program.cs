using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

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
            Console.ReadKey();
            host.Close();
        }
    }
}
