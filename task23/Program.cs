// Задача 23. Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Ведите число: ");
double x = 1, x3, N = Convert.ToDouble(Console.ReadLine());
while (x <= N)
{
    x3 = Math.Pow((x),3);
    Console.WriteLine(x + " | " + x3);
    x = x + 1;    
}