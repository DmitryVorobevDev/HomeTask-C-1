// : Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Данная программа сравнивает три целых числа");

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

int maxnum = num1;
if (num1>=num2) 
{
    maxnum = num1;
    if (num3>=num1) maxnum = num3;
}
else if(num2>=num1)
{
    maxnum = num2;
    if (num3>=num2) maxnum = num3;
}
Console.Write(maxnum);

Console.ReadKey();
