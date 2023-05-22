// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Ведите  значение :");
int number1 = int.Parse(Console.ReadLine());
int resultat = number1 % 2;
if (resultat == 0)
{
Console.WriteLine("ДА " + number1);
}
else 
{
    Console.WriteLine("НЕТ " + number1);
}
