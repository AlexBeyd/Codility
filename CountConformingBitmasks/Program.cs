// See https://aka.ms/new-console-template for more information
Dictionary<uint, uint> numbers = new Dictionary<uint, uint> { { 1073741631u, 1073741679u }, { 1073741727u, 1073741807u }, { 1073741632u, 1073741632u } };

foreach (var key in numbers.Keys)
{
    Console.WriteLine($"Number\t\t\t{Convert.ToString(key, 2)}");
    Console.WriteLine($"Conforms to\t\t{Convert.ToString(numbers[key], 2)}\t=====>\t{Solution.IsConforming(key, numbers[key])}");
    Console.WriteLine();
}

public static class Solution
{
    public static string IsConforming(uint number, uint conformingTo)
    {
        bool result = true;

        while (number > 0 && result)
        {
            result = (conformingTo & 1) == 0 || ((conformingTo & 1) == 1 && (number & 1) == 1);

            number = number >>= 1;
            conformingTo = conformingTo >>= 1;
        }

        return result ? "yes" : "no";
    }
}