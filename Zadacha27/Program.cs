﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int num =Convert.ToInt32(Console.ReadLine());
int sum = 0;
int last_digit = 0;

while(num > 0){
    last_digit = num % 10;
    sum += last_digit;
    num /= 10;
}

Console.WriteLine(sum);

