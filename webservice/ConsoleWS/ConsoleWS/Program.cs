using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWS.ServiceReference1;

namespace ConsoleWS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo proxy cho Web Service
            WebService1SoapClient ws = new WebService1SoapClient();

            Console.WriteLine("Nhap so a: ");
            int a=int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap so b: ");
            //int b = int.Parse(Console.ReadLine());
            Console.WriteLine(ws.KTchanle(a));
            Console.ReadLine();
        }
    }
}