// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 
 int Division(int num)
 {
        int firstDigit = (num / 10000);
        int secondDigit = (num / 1000) % 10;
        int fourthDigit = (num / 10) % 10;
        int fifthDigit = (num % 10);
       if (firstDigit == fifthDigit && secondDigit == fourthDigit)
        Console.WriteLine ("Число является палиндромом");
        else 
       {
           Console.WriteLine("Число не является палиндромом");
       }

     return num;
 }


Console.WriteLine("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
 
 int division = Division(number);
