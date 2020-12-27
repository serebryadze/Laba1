using ConsoleApp1.Модели;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Меню _Mymenu = new Меню();
            foreach (Блюда Меню in _Mymenu.MyMenu)
                Console.WriteLine(Меню.name + " " + Меню.price + "р");
            Console.ReadKey();

        }
    }
}
