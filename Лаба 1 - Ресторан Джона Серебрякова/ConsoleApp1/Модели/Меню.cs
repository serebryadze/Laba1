using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Модели
{
    class Меню
    {
        public List<Блюда> MyMenu = new List<Блюда>();
        
        public Меню()
        {
            Блюда vinegret = new Закуски("Винегрет", 30, 25, 100, 10);
            Блюда cesar = new Закуски("Цезарь", 45, 30, 90, 7);
            Блюда olivie = new Закуски("Оливье", 25, 20, 110, 12);
            Блюда craboviy = new Закуски("Крабовый", 50, 45, 65, 6);
            Блюда ice = new Десерты("Мороженое", 150, 90, 50, 1);
            Блюда tort = new Десерты("Торт", 300, 25, 200, 5);
            Блюда keks = new Десерты("Кекс", 45, 25, 50, 1);
            Блюда bulka = new Десерты("Булка", 45, 40, 50, 1);
            Блюда burger = new Детское_меню("Бургер", 31, 30, 150, 1);
            Блюда buter = new Детское_меню("Бутерброд", 41, 27, 50, 1);
            Блюда chips = new Детское_меню("Чипсы", 50, 25, 100, 0);
            Блюда freid = new Детское_меню("Картофель фри", 30, 25, 100, 3);
            Блюда voda = new Напитки("Вода", 10, 5, 100, 0);
            Блюда pivo = new Напитки("Пиво", 30, 28, 100, 0);
            Блюда vino = new Напитки("Вино", 100, 99, 100, 0);
            Блюда cola = new Напитки("Лимонад", 90, 70, 100, 0);
            Блюда borch = new Основные_блюда("Борщ", 130, 100, 100, 10);
            Блюда goroh = new Основные_блюда("Гороховый", 120, 110, 100, 10);
            Блюда uha = new Основные_блюда("Уха", 135, 125, 100, 10);
            Блюда dom = new Основные_блюда("Домашний", 100, 70, 100, 10);
            MyMenu.Add(vinegret);
            MyMenu.Add(cesar);
            MyMenu.Add(olivie);
            MyMenu.Add(craboviy);
            MyMenu.Add(ice);
            MyMenu.Add(tort);
            MyMenu.Add(keks);
            MyMenu.Add(bulka);
            MyMenu.Add(burger);
            MyMenu.Add(buter);
            MyMenu.Add(chips);
            MyMenu.Add(freid);
            MyMenu.Add(voda);
            MyMenu.Add(pivo);
            MyMenu.Add(vino);
            MyMenu.Add(cola);
            MyMenu.Add(borch);
            MyMenu.Add(goroh);
            MyMenu.Add(uha);
            MyMenu.Add(dom);
        }
    }
}
