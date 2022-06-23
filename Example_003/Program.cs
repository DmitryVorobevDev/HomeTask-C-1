// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка).
Console.WriteLine("Эта программа позволит определить четное ли число, которое ввел пользователь");

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

bool result = num % 2 == 0;
if (result) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");

Console.ReadKey();
