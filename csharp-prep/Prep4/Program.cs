using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (num != 0)
        {
            Console.WriteLine("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());
            numbers.Add(num);
        }
        int sum = numbers.Sum();
        int ave = (sum / numbers.Count());
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max}");
    }
}