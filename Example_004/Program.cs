// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Данная программа покажет все четные числа от 1 до введенного пользователем числа");
Console.Write("Введите целое число больше 1: ");
int num = int.Parse(Console.ReadLine());
int count = 2;
if (num>1)
{
    while ( num >= count )
    {
    Console.WriteLine(count);
    count = count + 2;
    }
}
else Console.Write("Неверное число");
Console.ReadKey(); 