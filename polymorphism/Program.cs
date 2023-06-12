using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer PrinterWindows;

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                PrinterWindows = new Epson();
            else if (nomorPrinter == 2)
                PrinterWindows = new Canon();
            else
                PrinterWindows = new LaserJet();

            PrinterWindows.show();
            PrinterWindows.print();

            Console.ReadKey();
        }
    }
}
