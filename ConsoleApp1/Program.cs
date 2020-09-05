using Microsoft.VisualBasic;
using System;

namespace ProjectOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Задача 1
            Console.WriteLine("Задача 1");
            int res = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 != 0 || i % 5 != 0)
                    res += i;
            }
            Console.WriteLine("Сумма всех чисел от 0 до 1000 кратных 3 или 5 равна: " +res);

            
            //Задача 2
            Console.WriteLine("Задача 2");
            int min;
            int[,] numbers = {
            {20, 34, 2},
            {9, 12, 18},
            {3, 4, 5}
            };
            min = numbers[0,0];
            foreach(int j in numbers)
            {
                
                if (min > j)
                    min = j;

            }

            Console.WriteLine("Минимальное значение массива: " + min);
            Console.Read();

            //Дополнительная задача 3
            int days = 2642;
            int years = days / 365;
            int weeks = (days % 365)/7;
            int daysleft = days % 7;
            Console.WriteLine($"Лет: {years}, Недель {weeks}, Дней {daysleft} ");
            Console.Read();

            //Дополнительная задача 4
            
            string outCar;
            char fin;
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("У вас есть машина? да/нет");
            if (Console.ReadLine() == "да")
            {
                outCar = "есть"; fin = 'а';
            }
            else
            {
                outCar = "нет"; fin = 'ы';
            }
            Console.WriteLine($" Вас зовут {name}, Ваш возраст {age} и у вас {outCar} машин{fin}");
            Console.Read();
            
            

        }
    }
}