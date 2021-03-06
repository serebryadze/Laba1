﻿using ConsoleApp1.Модели;
using ConsoleApp1.Контроллер;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Меню todayMenu;
        Orders todayOrders;
        int Mode;
        public MainWindow()
        {
            Mode = 0;
            todayMenu = new Меню(Mode);
            todayOrders = new Orders();
            todayOrders.FinalOrders = new List<Order>();

            InitializeComponent();

            this.DataContext = todayMenu;
            tMenuView.ItemsSource = todayMenu.MyMenu; //Data Binding - специально для ListView
            tOrderView.ItemsSource = todayOrders.FinalOrders; //Data Binding - специально для ListView
        }

        private void ChangeMenuClick(object sender, RoutedEventArgs e)
        {
            tMenuView.ItemsSource = todayMenu.MyMenu;
            switch (Mode)
            {
                case 0:
                    {
                        Mode = 1;
                        todayMenu = new Меню(Mode);
                        tMenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }

                case 1:
                    {
                        Mode = 2;
                        todayMenu = new Меню(Mode);
                        tMenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
                case 2:
                    {
                        Mode = 3;
                        todayMenu = new Меню(Mode);
                        tMenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
                case 3:
                    {
                        Mode = 4;
                        todayMenu = new Меню(Mode);
                        tMenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
                case 4:
                    {
                        Mode = 0;
                        todayMenu = new Меню(Mode);
                        tMenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
            }
        }

        private void tMenuView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*OName.Text = todayMenu.MyMenu[tMenuView.SelectedIndex].name;
            OPrice.Text = todayMenu.MyMenu[tMenuView.SelectedIndex].price.ToString();*/
        }

        private void ClearOrderClick(object sender, RoutedEventArgs e)
        {
            todayOrders.FinalOrders.Clear();
            tOrderView.ItemsSource = null;
            tOrderView.ItemsSource = todayOrders.FinalOrders;
            totalP = totalT = totalM = 0;
            TotalP.Text = OName.Text= OTime.Text= Osebestoim.Text = OPrice.Text = "";
        }

        int totalP = 0, totalT = 0, totalM = 0;

        private void AddtoOrderClick(object sender, RoutedEventArgs e)
        {
            Order tempOrder = new Order();
            try
            {
                tempOrder.Quantity = Math.Abs(Convert.ToInt32(OAmount.Text));
                tempOrder.Name = OName.Text;
                tempOrder.Price = Convert.ToInt32(OPrice.Text);
                tempOrder.Time = Convert.ToInt32(OTime.Text);
                tempOrder.Sebestoim = Convert.ToInt32(Osebestoim.Text);
                todayOrders.FinalOrders.Add(tempOrder);
                tOrderView.Items.Refresh();
                totalP += Convert.ToInt32(tempOrder.Price) * tempOrder.Quantity;
                TotalP.Text = Convert.ToString(totalP) + " р";
                if (tempOrder.Time > totalT) totalT = tempOrder.Time;
                totalM += (tempOrder.Price - tempOrder.Sebestoim) * tempOrder.Quantity;
            }
            catch (Exception)
            { 
                MessageBox.Show("Введите корректно количество блюд");
                OAmount.Text = "1";
            }
            
        }

        public struct Order
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public int Time { get; set; }
            public int Quantity { get; set; }
            public int Sebestoim { get; set; }
        }

        public struct Orders
        {
            public List<Order> FinalOrders;
            public int FinalPrice;
            public int FinalTime;
        }

        public void FinishOrderClick(object sender, RoutedEventArgs e)
        {
            if (todayOrders.FinalOrders.Count == 0) { }
            else
            {

                FileStream file = new FileStream("D:/Заказ.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                FileStream file1 = new FileStream("D:/Все заказы.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer1 = new StreamWriter(file1);
                foreach (Order Заказ in todayOrders.FinalOrders)
                {
                    writer.WriteLine(Заказ.Name + " " + "х" + Заказ.Quantity + " " + Заказ.Price + "р");
                    writer1.WriteLine(Заказ.Name + " " + "х" + Заказ.Quantity + " " + Заказ.Price + "р");
                }
                writer.WriteLine("Итого: " + Convert.ToString(totalP) + "р");
                writer1.WriteLine("Итого: " + Convert.ToString(totalP) + "р");
                writer.WriteLine("Время ожидания: " + Convert.ToString(totalT) + "мин");
                writer1.WriteLine("Время ожидания: " + Convert.ToString(totalT) + "мин");
                writer.WriteLine("Итоговая прибыль: " + Convert.ToString(totalM) + "р");
                writer1.WriteLine("Итоговая прибыль: " + Convert.ToString(totalM) + "р");
                writer1.WriteLine();
                writer.Close();
                file.Close();
                writer1.Close();
                file1.Close();
                MessageBox.Show("Спасибо за заказ");
                todayOrders.FinalOrders.Clear();
                tOrderView.ItemsSource = null;
                tOrderView.ItemsSource = todayOrders.FinalOrders;
                totalP = totalT = totalM = 0;
                TotalP.Text = OName.Text = OTime.Text = Osebestoim.Text = OPrice.Text = "";
            }
        }
    }
}
