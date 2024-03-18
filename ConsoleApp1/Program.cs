// See https://aka.ms/new-console-template for more information

Console.WriteLine("Modification 3");
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 7, 9};
Console.WriteLine(CalculateAverage(arr));
Console.WriteLine(FindMax(arr));

static double CalculateAverage(int[] numbers)
{
    int sumOfNumbers = 0;
    foreach (int num in numbers)
    {
        sumOfNumbers += num;
    }
    return (double)sumOfNumbers / numbers.Length;
}

static int FindMax(int[] numbers)
{
    int max = -1;
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}