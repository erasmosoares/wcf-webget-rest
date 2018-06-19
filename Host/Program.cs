using CoffeemanagerService;
using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CoffeeService)))
            {
                foreach (Uri uri in host.BaseAddresses)
                    Console.WriteLine(uri.AbsoluteUri);

                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate Host");
                Console.ReadLine();

            }
        }
    }
}
 