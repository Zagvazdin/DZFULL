// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите Число А :");
int numbreA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Число B :");
int numbreB = int.Parse(Console.ReadLine());

if (numbreA > numbreB)
{
    Console.WriteLine(" МАХ = " + numbreA);
}
else 
{
    Console.WriteLine(" МАХ = " + numbreB);
}