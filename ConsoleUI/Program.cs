using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
namespace ConsoleUI
{
    class Program
    {
        private static BL.BL bl;
        static void Main(string[] args)
        {
            bl = new BL.BL();
            Console.WriteLine(bl.BL_PrintTest());
            // Need to add more code.
        }
    }
}
