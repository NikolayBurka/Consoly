﻿using System;

class Program
{
    static void Main(string[] args)
    {
        //Задание №1 В массиве записана масса каждого из n предметов, загружаемых в автомобиль. Определить общую массу груза.

        int n = int.Parse(Console.ReadLine());
        int[] weights = new int[n];
        for (int i = 0; i < n; i++)
            weights[i] = i;
        int totalWeight = 0;
        foreach (int weight in weights)
        {
            totalWeight += weight;
        }

        Console.WriteLine("Общая масса груза: " + totalWeight);
        Console.ReadLine();

        //Задание №2 Известен рост каждого студента 212 группы.Найти средний рост студентов.
    }
}