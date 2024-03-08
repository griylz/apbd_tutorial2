// See https://aka.ms/new-console-template for more information


Console.WriteLine("Modification 3!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1!");
Console.WriteLine("Modification 2!");


static double CountAvg(int[] arr)
{
    double res = 0;
    foreach (int i in arr)
    {
        res += i;
    }

    return res / arr.Length;
}

int[] numbers = {1,3,4,5,6};
Console.WriteLine(CountAvg(numbers));