// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] massiv = new int[8];

System.Console.Write("[");

for (int i = 0; i < 8 - 1; i++)    
    {
        massiv[i] = new Random().Next(0,100);
        Console.Write(massiv[i] + ", ");
    }

massiv[8-1] = new Random().Next(0,100);
Console.WriteLine(massiv[8-1] + "]");

