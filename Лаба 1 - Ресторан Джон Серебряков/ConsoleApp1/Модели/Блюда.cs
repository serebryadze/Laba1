using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Модели
{
    interface Блюда
    {
        string name { get; set; }
        double price { get; set; }
        double sebestoim { get; set; }
        int ves { get; set; }
        int time { get; set; }
    }
}
