using System;
using System.ServiceModel;

namespace HelloWorldHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(HelloWorldService.HelloWorldService)))
            {
                host.Open();
                Console.WriteLine("Service is running at port 8733...");
                Console.ReadLine();
            }
        }
    }
}
