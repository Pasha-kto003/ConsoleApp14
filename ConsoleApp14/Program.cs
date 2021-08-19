using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число 1");
            //string num1 = Console.ReadLine();

            //Console.WriteLine("Введите число 2");
            //string num2 = Console.ReadLine();

            //int n1 = Convert.ToInt32(num1);
            //int n2 = Convert.ToInt32(num2);

            //Console.WriteLine($"Сумма чисел: {n1 + n2}");
            //№1
            //Console.WriteLine("Введите первое число");
            //double number1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите второе число");
            //double number2 = double.Parse(Console.ReadLine());

            //double result = (number1 + number2) / 2;
            //Console.WriteLine(result);

            //№2
            //Console.WriteLine("Введите первое число");

            //string num1 = Console.ReadLine();
            //int n1 = Convert.ToInt32(num1);

            //Console.WriteLine("Введите второе число");

            //string num2 = Console.ReadLine();
            //int n2 = Convert.ToInt32(num2);

            //Console.WriteLine("Введите третье число");

            //string num3 = Console.ReadLine();
            //int n3 = Convert.ToInt32(num1);

            //int sum = n1 + n2 + n3;
            //Console.WriteLine("Сумма чисел" + sum);           
            //int proiz = n1 * n2 * n3;
            //Console.WriteLine("Произведение чисел" + proiz);

            //№3
            //Console.WriteLine("Введите Рубли для конвертера валюты");
            //string r = Console.ReadLine();
            //decimal rub = Convert.ToInt32(r);

            //Console.WriteLine("Сумма денежных средств в долларах США");
            //decimal dollar = rub / 75;
            //Console.WriteLine(dollar);

            //Console.WriteLine("Сумма денежных средств в Евро");
            //decimal euro = rub / 85;
            //Console.WriteLine(euro);

            //№4
            //int a = int.Parse(Console.ReadLine());
            //if(a % 2 == 0)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine("Число четное");
            //}
            //else
            //{
            //    Console.WriteLine("Число нечетное");
            //}

            //№5
            //Console.WriteLine("Введите первое число");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Выберите операцию (*, -, +, /)");
            //char znak = char.Parse(Console.ReadLine());

            //switch (znak)
            //{
            //    case '*':
            //        int result;
            //        result = num1 * num2;
            //        Console.WriteLine("Ваш ответ " + result);
            //        break;
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Ваш ответ " + result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Ваш ответ " + result);
            //        break;
            //    case '/':

            //        if (num2 == 0)
            //        {
            //            Console.WriteLine(0);
            //        }
            //        else
            //            Console.WriteLine("Ваш ответ " + num1 / num2);
            //        break;
            //}

            //№6
            //int chetnoe = 0;
            //int nechetnoe = 0;
            //int sumchetnoe = 0;
            //int sumnechetnoe = 0;
            //Console.WriteLine("Введите первое число диапазона");
            //int value = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите последнее число диапазона");
            //int limit = int.Parse(Console.ReadLine());

            //while (value <= limit)
            //{
            //    if (value % 2 == 0)
            //    {
            //        chetnoe++;
            //        sumchetnoe += value;

            //    }
            //    else
            //    {
            //        nechetnoe++;
            //        sumnechetnoe += value;

            //    }
            //    value++;
            //}

            //Console.WriteLine("Количество четных чисел: " + chetnoe);
            //Console.WriteLine("Количество нечетных чисел: " + nechetnoe);

            //Console.WriteLine("Сумма четных чисел: " + sumchetnoe);
            //Console.WriteLine("Сумма нечетных чисел: " + sumnechetnoe);

            //int i = int.Parse(Console.ReadLine());
            //for(; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0,j = 5; i < 5; i++, j--)
            //{
            //    Console.WriteLine("i: " + i);
            //    Console.WriteLine("j: " + j);
            //}

            //for(int i = 1; i <=3; i++)
            //{
            //    Console.WriteLine("цикл 1 итерация №: " + i);
            //    for(int j = 1; j <=3; j++)
            //    {
            //        Console.WriteLine("\tцикл 2 итерация №: " + j);
            //    }

            //}
            //Console.Write("Ведите высоту прямоугольника: ");
            //int height = int.Parse(Console.ReadLine());
            //for(int i = 0; i < height; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = height - 1; i >= 0; i--)
            //{
            //    for (int j = i - 1; j >= 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int[] myArray;         
            //myArray = new int[10];
            //myArray[1] = 3;
            //myArray[0] = 10;
            //int a = myArray[0];       
            //Console.WriteLine(a);

            //int count = int.Parse(Console.ReadLine());
            //int[] myArray = new int[count];
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //№7
            //Console.WriteLine("Введите количество цифр в массиве");
            //int count = int.Parse(Console.ReadLine());
            //int[] myArray = new int[count];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine($"Введите элемент массива с индексом: {i}");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Ваш массив: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //int[] myArray = new int[] { 10, 28, 45, 14, 67 };
            //Console.WriteLine("Ваш массив: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Console.WriteLine("Массив в обратном порядке:");
            //for (int i = myArray.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //Console.WriteLine("Введите количество цифр в массиве");
            //int count = int.Parse(Console.ReadLine());
            //int[] myArray = new int[count];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine($"Введите элемент массива с индексом: {i}");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Ваш массив: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Console.WriteLine($"Сумма четных чисел в массиве: {myArray.Where(i => i % 2 == 0).Sum()}");

            //Console.WriteLine("Введите количество цифр в массиве");
            //int count = int.Parse(Console.ReadLine());
            //int[] myArray = new int[count];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine($"Введите элемент массива с индексом: {i}");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Ваш массив: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Console.WriteLine($"Наименьшее число массива: {myArray.Min()}");

            //int[] myArray = { 11, 11, 12, 16, 18, 20, 11, 12, 16 };
            //int[] res = myArray.OrderByDescending(i =>i).ToArray();
            //for(int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}

            //int[] myArray = { 11, 11, 12, 16, 18, 20, 11, 12, 16, 66, 78, 56, 89, 100 };
            //int res = Array.FindIndex(myArray, i => i == 66);

            //int[,] myArray = new int[,]
            //{
            //    {1, 2, 3, 7, 4 },
            //    {2, 1, 5, 8, 6 },
            //    {6, 4, 3, 1, 7 },
            //    {23, 45, 32, 11, 34 }
            //};
            //foreach (int item in myArray) // вывод в одну строку
            //{
            //    Console.WriteLine(item);
            //}

            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);
            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.Write(myArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] myArray = new int[10, 6];
            //Random random = new Random();
            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        myArray[i, j] = random.Next(0, 250);
            //    }
            //}
            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.Write(myArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Введите высоту массива");        
            //int height = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите ширину массива");
            //int width = int.Parse(Console.ReadLine());
            //int[,] myArray = new int[height, width];      
            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine("i: " + i + "j: " + j);
            //        myArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.Write(myArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] myArray = new int [5][];
            //myArray[4] = new int[2];
            //myArray[0] = new int[5];
            //Random random = new Random();

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    for (int j = 0; j < myArray[i].Length; j++)
            //    {
            //        myArray[i][j] = random.Next(100);
            //    }
            //}

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    for (int j = 0; j < myArray[i].Length; j++)
            //    {
            //        Console.Write(myArray[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}