using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Ibai"+i);
                System.Threading.Thread.Sleep(1000);
            }
            System.Console.WriteLine("Pulse cualquier botón para finalizar");
            System.Console.ReadLine();
        }
    }
}
