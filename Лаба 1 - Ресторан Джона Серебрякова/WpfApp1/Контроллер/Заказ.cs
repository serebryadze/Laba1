using ConsoleApp1.Модели;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Контроллер
{
    class Заказ
    {
        public Заказ(int mode) { Меню Blydo = new Меню(mode); Order = Blydo.MyMenu; }
        List<Блюда> Order;
        List<dishes> Меню;
        OrderInfo info;
        List<Блюда> Show(List<Блюда> F) { return F; }
        bool Chosen(List<dishes> W, Блюда S, int D)
        {
            bool K = false;
            dishes N;
            N.amount = D;
            N.T = S;
            W.Add(N);
            return K;
        }
        void Finish(bool Cheque = false)
        {
            OrderInfo R = new OrderInfo();
            foreach (dishes lemon in Меню)
            {
                R.price = R.price + lemon.T.price * lemon.amount;
                Console.WriteLine("Стоимость: " + R.price);
                R.weight = R.weight * lemon.T.price;
                Console.WriteLine("Вес:" + R.weight);
            }
        }
        struct OrderInfo { public double price; public double time; public double weight; public int id; }
        struct dishes { public int amount; public Блюда T; }
        
    } 
}
