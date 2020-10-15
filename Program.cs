using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10102020dz2
{
    public static class RandomExtensions // перегрузка для NextDouble
    {
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    class Program
    {
        static void task1_1()
        {
            /*
            Завдання. З клавіатури вводиться число n – кількість елементів масиву. 
            Потрібно  створити масив типу double та заповнити його псевдовипадковими числами (діапазон  вказано у варіанті). 
            Виконати вказані у варіанті дії та після кожної з них вивести  результат. 
            При виведенні результатів використовуйте інтерпольовані рядки мови C#. 
            Задание 1.1 Знайти сумму елементів з індексами, які діляться на 3.
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість елементів масиву: ");
            int n = int.Parse(Console.ReadLine());
            double[] mas = new double[n];
            Random random = new Random();
            double rand;
            for (int i = 0; i < n; i++)
            {
                rand = Math.Round((random.NextDouble(-10.51, 10.53)), 2);
                mas[i] = rand;
            }

            foreach (var number in mas)
                Console.Write($"{number}\t");
            Console.WriteLine();
            double temp = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 3 == 0)
                    temp = mas[i] + temp;
            }
            //Console.WriteLine("Сумма елементів, з індексами, які діляться на 3 = " + temp);
            Console.WriteLine($"Сумма елементів, з індексами, які діляться на 3 = {temp}");
            Console.ReadKey(); // затримка консолі
        }

        static void task1_2()
        {
            /*
            Задание 1.2 Впорядкувати першу половину масиву за зростанням значень елементів.
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість елементів масиву: ");
            int n = int.Parse(Console.ReadLine());
            double[] mas = new double[n];
            Random random = new Random();
            double rand;
            for (int i = 0; i < n; i++)
            {
                rand = Math.Round((random.NextDouble(-10.51, 10.53)), 2);
                mas[i] = rand;
            }
            foreach (var number in mas)
                Console.Write($"{number}\t");
            Console.WriteLine();
            int size = mas.Length / 2;
            for (int i = 0; i < mas.Length / 2; i++)
            {
                Array.Sort(mas, 0, (mas.Length / 2));
            }
            foreach (var number in mas)
                Console.Write($"{number}\t");
            Console.WriteLine();
            Console.ReadKey(); // затримка консолі
        }

        static void task2_1()
        {
            /*
            Завдання. З клавіатури вводяться числа n – кількість рядків матриці, m – кількість  стовпців матриці. 
            Потрібно створити матрицю типу double та заповнити її псевдовипадковими числами (діапазон вказано у варіанті). 
            Виконати вказані у варіанті дії  та після кожної з них вивести результат. 
            При виведенні результатів використовуйте  інтерпольовані рядки мови C#. 
                Задание 2.1 Знайти окремо суму елементів кожного рядка. 
                Серед них визначити найбільшу.
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість рядків матриці: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців матриці: ");
            int m = int.Parse(Console.ReadLine());
            double[,] arr2d = new double[n, m];
            Random random = new Random();
            double rand;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rand = Math.Round((random.NextDouble(-110.34, 110.35)), 2);
                    arr2d[i, j] = rand;
                }
            }
            //вывод матриц
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int k = 0; k < arr2d.GetLength(1); k++)
                {
                    Console.Write(arr2d[i, k]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сума елементів кожного рядка: ");
            double sum_row = 0;
            double max_sum_row = 0;
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum_row = sum_row + arr2d[i, j];
                }
                Console.WriteLine($"Рядок № {i} має суму {sum_row}");
                if (sum_row > max_sum_row)
                {
                    max_sum_row = sum_row;
                    p = i;
                }
                sum_row = 0;
            }
            Console.WriteLine($"Рядок № {p} має найбільшу суму {max_sum_row}");
            Console.ReadKey(); // затримка консолі
        }

        static void task2_2()
        {
            /*
            Завдання. З клавіатури вводяться числа n – кількість рядків матриці, m – кількість  стовпців матриці. 
            Потрібно створити матрицю типу double та заповнити її псевдовипадковими числами (діапазон вказано у варіанті). 
            Виконати вказані у варіанті дії  та після кожної з них вивести результат. 
            При виведенні результатів використовуйте  інтерпольовані рядки мови C#. 
                Задание 2.2 Циклічно зсунути парні рядки матриці зліва направо на k позицій.
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість рядків матриці: ");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            double[,] arr2d = new double[n, m];
            Random random = new Random();
            double rand;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rand = Math.Round((random.NextDouble(-110.34, 110.35)), 2);
                    arr2d[i, j] = rand;
                }
            }
            Console.WriteLine("Матриця з псевдовипадковими числами:");
            //вывод матриц
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int k = 0; k < arr2d.GetLength(1); k++)
                {
                    Console.Write(arr2d[i, k]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введіть K: ");
            int K = int.Parse(Console.ReadLine());
            //Циклічно зсунути парні рядки матриці зліва направо на k позицій.
            for (int b = 1; b <= K; b++)
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        double t = arr2d[i, m - 1];
                        for (int j = m - 1; j > 0; j--)
                            arr2d[i, j] = arr2d[i, j - 1];
                        arr2d[i, 0] = t;
                    }
                }
            Console.WriteLine($"Після зсуву на {K} поз.: ");
            //вывод матриц
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int k = 0; k < arr2d.GetLength(1); k++)
                {
                    Console.Write(arr2d[i, k]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
            Console.ReadKey(); // затримка консолі
        }

        static void Main(string[] args)
        {
            task2_2();
        }
    }
}
