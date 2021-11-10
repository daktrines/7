﻿using System;
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

namespace _5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калион Екатерина Максимовна. 7 пр. Использовать класс Саr (машина), характеризуемый торговой маркой (строка), " +
                "числом цилиндров, мощностью. Создать производный класс Lorry(грузовик), " +
                "характеризуемый также грузоподъемностью кузова.Определить функции переназначения марки и изменения грузоподъемности.");
        }

        //Выход из программы
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
     
       
        Car car = new Car(); //Создаем обьект типа Car
        Lorry lorry = new Lorry();
        Car onecar; //описываем переменную 1 авто
        Car twocar; //описываем переменную 2 авто

        //покупка первого авто
        private void Купить_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int, выходной параметр cilindr / moshonst, "переменная" > 0
            if (int.TryParse(Cilindr.Text, out int cilindr) && int.TryParse(Moshnost.Text, out int moshnost) && cilindr > 0 && moshnost > 0)
            {
                car.SetParams(cilindr, moshnost); // использууем перегруженный метод
                car1.Text = car.Show(); //используем метод
                onecar = new Car(car.Marka, car.Moshnost, car.Culindr);// создаем экземпляр обьекта с параметрами
            }
            else MessageBox.Show("Введите данные!", "Ошибка");
        }

        //Радиокнопка бмв
        private void BMW_Checked(object sender, RoutedEventArgs e)
        {
            car.SetParams(Convert.ToString(BMW.Content));// испоьзуем метод для марки
            Cilindr.Text = "6";
            Moshnost.Text = "297";
            car.SetParams(6, 297);
            
        }

        //радиокнопка ауди
        private void Audi_Checked(object sender, RoutedEventArgs e)
        {
            car.SetParams(Convert.ToString(Audi.Content));// используем метод
            Cilindr.Text = "4";
            Moshnost.Text = "176";
            car.SetParams(4, 176);
            
        }

        //кнопка увеличения на 1
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int, выходной параметр moshonst, "переменная" > 0
            if ( int.TryParse(Moshnost.Text, out int moshnost) &&  moshnost > 0)
            {
                //используем метод +1 
                car++;
                Moshnost.Text = Convert.ToString(car.Moshnost) ;
            }
            else MessageBox.Show("Введите данные!", "Ошибка");
        }

        //покупка второго авто
        private void Купить1_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int, выходной параметр cilindr / moshonst, "переменная" > 0
            if (int.TryParse(Cilindr.Text, out int cilindr) && int.TryParse(Moshnost.Text, out int moshnost) && cilindr > 0 && moshnost > 0)
            {
                car.SetParams(cilindr, moshnost); // использууем перегруженный метод
                car2.Text = car.Show(); //используем метод
                twocar = new Car(car.Marka, car.Moshnost, car.Culindr );// создаем экземпляр обьекта с параметрами
            }
            else MessageBox.Show("Введите данные!", "Ошибка");
        }

        //сравниваем 2 авто
        private void Сравнить_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int, выходной параметр cilindr / moshonst, "переменная" > 0
            if (int.TryParse(Cilindr.Text, out int cilindr) && int.TryParse(Moshnost.Text, out int moshnost) && cilindr > 0 && moshnost > 0)
            {
                if (onecar == twocar) srav.Text = "Оба авто крутые";
                else if (onecar >= twocar) srav.Text = "BMW круче";
                else srav.Text = "Audi круче";
            }
            else MessageBox.Show("Введите данные!", "Ошибка");
        }

        //Очищаем все
        private void Очистить_Click(object sender, RoutedEventArgs e)
        {
            
            Cilindr.Clear();
            Moshnost.Clear();
            car1.Clear();
            car2.Clear();
            srav.Clear();
            Gruz.Clear();
            Lorry.Clear();

        }

        //радиокнопка волва
        private void Volvo_Checked(object sender, RoutedEventArgs e)
        {
            lorry.SetParams(Convert.ToString(Volvo.Content));// используем метод
            Gruz.Text = "60";
            Lorry.Clear();
        }

        //радиокнопка хино
        private void HINO_Checked(object sender, RoutedEventArgs e)
        {
            lorry.SetParams(Convert.ToString(HINO.Content));// используем метод
            Gruz.Text = "26";
            Lorry.Clear();
        }

        //кнопка купить
        private void КупитьГрузовик_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int, выходной параметр gruz, "переменная" > 0
            if (int.TryParse(Gruz.Text, out int gruz) && gruz > 0)
            {
                lorry.Izmenenie(gruz); // использууем функцию
                Lorry.Text = lorry.Show(); //используем метод
            }
            else MessageBox.Show("Введите данные!", "Ошибка");
        }
    }
}
       
    

