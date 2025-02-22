internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        long[] arr2 = { long.Parse(arr[0]), long.Parse(arr[1]), long.Parse(arr[2])};
        Array.Sort(arr2);
        Console.WriteLine($"{arr2[0]} {arr2[2]}");
    }
}