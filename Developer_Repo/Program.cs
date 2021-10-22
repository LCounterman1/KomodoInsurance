using KomodoInsurance_Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInusrance_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI komodoApp = new ProgramUI();
            komodoApp.Run();
            Console.ReadKey();
        }
    }
}

