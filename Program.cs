// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Random rand = new Random();
// int number = rand.Next(100, 1000);
// Console.WriteLine(number);

// string str = number.ToString();
// Console.WriteLine(str[1]);

// int number2 = Convert.ToInt32(Convert.ToString(str[1]));
// Console.WriteLine(number2);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Введите число, имеющее больше 2-х символов");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99)
// {
//   while (number > 999)
//   {
//     number /= 10;
//   }
//   Console.WriteLine(number % 10);
// }
// else
// {
//   Console.WriteLine("Введено не трёхзначное число");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня недели от 1 до 7");
// int num1 = int.Parse(Console.ReadLine()!);
// while (num1 > 7 || num1 < 1)
// {
//   Console.WriteLine("Введите число от 1 до 7");
//   num1 = int.Parse(Console.ReadLine()!);
// }
// if (num1 == 6 || num1 == 7)
// {
//   Console.WriteLine("Это выходной");
// }
// else
// {
//   Console.WriteLine("Это не выходной");
// }
