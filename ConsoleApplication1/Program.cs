using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace ConsoleApplication1
{
    class Program
    {
        static void Lookup()
        {

            Console.WriteLine("Nhap ten mien hoac dia chi IP: ");
            string s = Console.ReadLine();
            IPHostEntry iphost = Dns.Resolve(s);
            Console.WriteLine("hostname : " + iphost.HostName);
            Console.WriteLine("ip: " + iphost.AddressList[0]);
        }
        static void Main(string[] args)
        {
            // Bai 1
            //String s = Dns.GetHostName();
            //Console.WriteLine("Host Name: " + s);

            //IPHostEntry iphost = Dns.GetHostByName(s);

            //int i = 0;
            //foreach (IPAddress ipadd in iphost.AddressList)
            //{
            //    Console.WriteLine("Ip #" + ++i + ": " +ipaddress.ToString());
            //}
            //Console.ReadLine();

            //bai 2
            Lookup();
            Console.ReadLine();
            
        }
    }
}
