// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
double b = a / 10000, b1, b2, b3, b4;
if (b > 0)
{   
    b1 = b;
    b2 = (a / 1000) % 10;
    b3 = (a / 10) % 10;
    b4 = a % 10;
    if (b1 == b4 & b2 == b3)
    {
        Console.WriteLine("Число " + a + " является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число " + a + " не является палиндромом!");
    }
}
else
{
    Console.WriteLine("Число " + a + " не является пятизначным!");
}

