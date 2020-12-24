using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Модели
{
    class Меню
    {
        public List<Блюда> MyMenu = new List<Блюда>();
        public Меню(int mode)
        {
            if (mode == 0)
            {
                Блюда lesnichiy = new Закуски("Лесничий", 58, 25, 100, 10);
                Блюда cesar = new Закуски("Цезарь", 47, 30, 90, 7);
                Блюда knyaz = new Закуски("Князь", 20, 20, 110, 12);
                Блюда craboviy = new Закуски("Крабовый", 80, 45, 65, 6);
                Блюда chapalah = new Закуски("Чапалах", 70, 41, 66, 5);
                Блюда richard = new Закуски("Ричард", 48, 25, 100, 11);
                Блюда vavuzella = new Закуски("Вавузелла индонезийская", 78, 40, 53, 9);
                Блюда tigr = new Закуски("Тигровый", 55, 31, 60, 7);
                MyMenu.Add(lesnichiy);
                MyMenu.Add(cesar);
                MyMenu.Add(knyaz);
                MyMenu.Add(craboviy);
                MyMenu.Add(chapalah);
                MyMenu.Add(richard);
                MyMenu.Add(vavuzella);
                MyMenu.Add(tigr);
            }

            if (mode == 1)
            {
                Блюда ice = new Десерты("Заволжское мороженое", 350, 90, 50, 1);
                Блюда tort = new Десерты("Торт пряничный", 500, 25, 200, 5);
                Блюда keks = new Десерты("Кекс творожный", 90, 25, 50, 1);
                Блюда bulka = new Десерты("Булка Соколов", 15, 40, 50, 1);
                Блюда corolla = new Десерты("Сладкая Королла", 200, 80, 50, 4);
                Блюда pirozhinoe = new Десерты("Анна Павловна", 300, 45, 100, 10);
                Блюда blinchik = new Десерты("Блинчики", 70, 15, 62, 5);
                Блюда sochen = new Десерты("Сочень", 30, 20, 20, 1);
                MyMenu.Add(ice);
                MyMenu.Add(tort);
                MyMenu.Add(keks);
                MyMenu.Add(bulka);
                MyMenu.Add(corolla);
                MyMenu.Add(pirozhinoe);
                MyMenu.Add(blinchik);
                MyMenu.Add(sochen);
            }

            if (mode == 2)
            {
                Блюда burger = new Детское_меню("Бургер Королевский Михайлов", 800, 30, 150, 1);
                Блюда buter = new Детское_меню("Бутерброд 3-х летней давности", 40, 27, 50, 1);
                Блюда chips = new Детское_меню("Чипсы маргариновые", 30, 25, 100, 0);
                Блюда freid = new Детское_меню("Картофель фри", 45, 25, 100, 3);
                Блюда nugets = new Детское_меню("Нагетсы", 70, 20, 50, 7);
                Блюда derevnia = new Детское_меню("Картофель по деревенски", 50, 37, 40, 3);
                Блюда palocki = new Детское_меню("Сырные палочки", 30, 15, 101, 2);
                MyMenu.Add(burger);
                MyMenu.Add(buter);
                MyMenu.Add(chips);
                MyMenu.Add(freid);
                MyMenu.Add(nugets);
                MyMenu.Add(derevnia);
                MyMenu.Add(palocki);
            }

            if (mode == 3)
            { 
                Блюда voda = new Напитки("Вода Баржуми", 65, 5, 100, 0);
                Блюда pivo = new Напитки("Пиво Немецкое", 157, 28, 100, 0);
                Блюда vino = new Напитки("Вино", 255, 99, 100, 0);
                Блюда cola = new Напитки("Кока-Кола", 75, 70, 100, 0);
                Блюда fanta = new Напитки("Фанта", 75, 70, 100, 0);
                Блюда sprite = new Напитки("Спрайт",75, 70, 100, 0);
                Блюда sevenup = new Напитки("7UP", 80, 70, 100, 0);
                Блюда pepsi = new Напитки("Пепси", 75, 70, 100, 0);
                Блюда kvas = new Напитки("Легендарный Квас Михайлова", 165, 70, 100, 0);
                Блюда vodka = new Напитки("Водка", 107, 70, 100, 0);
                MyMenu.Add(voda);
                MyMenu.Add(pivo);
                MyMenu.Add(vino);
                MyMenu.Add(cola);
                MyMenu.Add(fanta);
                MyMenu.Add(sprite);
                MyMenu.Add(sevenup);
                MyMenu.Add(pepsi);
                MyMenu.Add(kvas);
                MyMenu.Add(vodka);
            }

            if (mode == 4)
            {
                Блюда kudryash = new Основные_блюда("Кудряш", 105, 100, 100, 10);
                Блюда borch = new Основные_блюда("Борщ", 110, 100, 100, 10);
                Блюда goroh = new Основные_блюда("Гороховый шут", 100, 110, 100, 10);
                Блюда uha = new Основные_блюда("Уха по-Моревски", 187, 125, 100, 10);
                Блюда shi = new Основные_блюда("Щи", 95, 70, 100, 10);
                MyMenu.Add(kudryash);
                MyMenu.Add(borch);
                MyMenu.Add(goroh);
                MyMenu.Add(uha);
                MyMenu.Add(shi);
            }
        }
    }
}
