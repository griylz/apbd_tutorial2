// See https://aka.ms/new-console-template for more information


Console.WriteLine("Modification 3!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1!");
Console.WriteLine("Modification 2!");


static double CountAvg(int[] arr)
{
    double rest = 0;
    foreach (int i in arr)
    {
        rest += i;
    }

    return rest / arr.Length;
}

static int CountMax(int[] arr)
{
    int max = 0;
    foreach (int i in arr)
    {
        if (i>max)
        {
            max = i;
        }
    }
    return max;
}

int[] numbers = {1,3,4,5,6};
Console.WriteLine(CountAvg(numbers));
Console.WriteLine(CountMax(numbers));