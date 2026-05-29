using _4_задание;
using System;

public class Test
{
    public static void Main()
    {
        int[] nums = new int[] { 1, -2, 3, 4, -5, 60, -700 };
        Console.WriteLine("Исходный массив");
        foreach (int i in nums)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Отсортированный массив в порядке возрастания");
        Array.Sort(nums);
        foreach (int i in nums)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Сортировка массива в порядке убывания");
        Array.Reverse(nums);
        foreach (int i in nums)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
var newvar = new NewClass1();
newvar.Name = "";
