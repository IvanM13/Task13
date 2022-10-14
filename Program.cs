/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Write("Введите  число: ");
string num = Convert.ToString(Console.ReadLine());

if (num.Length >= 4)
    Console.WriteLine(num[2]);

else
    Console.WriteLine("третьей цифры нет");
