// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Binary gap ***");
Console.WriteLine();

int[] number = { 529, 1, 4, 5, 8, 9, 15, 20, 32, 561892 };

for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine($"Processing {number[i]} which is {Convert.ToString(number[i], 2)} in binary...");
    Console.WriteLine($"Binary gap is {Solution.GetBinaryGap(number[i])}");
    Console.WriteLine();
}


public static class Solution
{
    public static int GetBinaryGap(int number)
    {
        int inGapCounter = 0;
        int binarySpace = 0;
        bool isInGap = false;

        while (number > 0)
        {
            int last = number & 1;
            number = number >>= 1;

            if (last == 1)
            {
                if (binarySpace < inGapCounter) binarySpace = inGapCounter;

                isInGap = true;
                inGapCounter = 0;
            }
            else if (isInGap)
                inGapCounter++;
        }
        return binarySpace;
    }
}
