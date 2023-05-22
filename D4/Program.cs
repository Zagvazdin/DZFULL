// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int num1 = 22, num2 = 3, num3 = 9;
 int max;
 if (num1 >= num2)
 {
    if (num3 >= num1)
    {
       Console.WriteLine(max = num3);
    }
    else
    {
      Console.WriteLine(max = num1);
    }
 }
 else
 {
    if (num3 >= num2)
    {
       Console.WriteLine(max = num3);
    }
    else
    {
       Console.WriteLine(max = num2);
    }
 }