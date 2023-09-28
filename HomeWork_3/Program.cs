using System;

class Program
{
static void Main()
{
int[] array = new int[8];
Random random = new Random();

    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(1, 99);
    }

    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
    Console.ReadLine();
}
}