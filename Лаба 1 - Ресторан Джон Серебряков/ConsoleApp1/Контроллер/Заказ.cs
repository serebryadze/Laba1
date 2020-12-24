using ConsoleApp1.Модели;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Контроллер
{
    class Заказ
    {
        public Заказ() { Меню Eda = new Меню(); Order = Eda.MyMenu; }
        List<Блюда> Order;
        List<dishes> Меню;
        OrderInformation info;
        List<Блюда> ShowMenu(List<Блюда> F) { return F; }
        bool ChoseItem(List<dishes> W, Блюда S, int D)
        {
            bool K = false;
            dishes N;
            N.amount = D;
            N.T = S;
            W.Add(N);
            return K;
        }
        void FinishOrder(bool Cheque = false)
        {
            OrderInformation R = new OrderInformation();
            foreach (dishes lemon in Меню)
            {
                R.price = R.price + lemon.T.price * lemon.amount;
                Console.WriteLine("Стоимость");
                R.weight = R.weight * lemon.T.price;
                Console.WriteLine("Вес");
            }
        }
            struct OrderInformation { public double price; public double time; public double weight; public int id; }
            struct dishes { public int amount; public Блюда T; }
        
    } 
}
