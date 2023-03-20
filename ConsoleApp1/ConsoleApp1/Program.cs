using System;

class Program
{
    static void Main(string[] args)
    {
        //Zadanie4
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int count = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            { 
                count++;
            }
        }
        Console.WriteLine("Количество четных элементов: " + count);
        Console.ReadLine();

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
        int j = int.Parse(Console.ReadLine());
        int[] heights = new int[j];
        for (int i = 0; i < j; i++)
        {
            heights[heights[i]] = i;
        }
        int totalHeight = 0;
        foreach (int height in heights)
        {
            totalHeight += height;
        }
        Console.WriteLine(totalHeight);
        double averageHeight = (double)totalHeight / j;
        Console.WriteLine("Средний рост студентов: " + averageHeight);




    }
}
