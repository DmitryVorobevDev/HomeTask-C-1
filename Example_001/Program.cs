//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Эта программа позволяет сравнивать целые числа!");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1>num2) Console.Write("Первое число больше чем второе");
else if(num2>num1) Console.Write("Второе число больше чем первое");
else Console.Write("Числа равны");
Console.ReadKey();
