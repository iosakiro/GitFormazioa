﻿using System;
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
            for (int i = 10; i > 0; i--)
            {
                System.Console.WriteLine("beñat y Ibai"+i);
                System.Threading.Thread.Sleep(1000);
            }
            System.Console.WriteLine("Pulse enter para finalizar");
            System.Console.ReadLine();
        }
    }
}
