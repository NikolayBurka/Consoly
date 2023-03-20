using System;

class Program
{
    static void Main(string[] args)
    {
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