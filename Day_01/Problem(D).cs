internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        Console.WriteLine($"Difference = {(long.Parse(arr[0]) * long.Parse(arr[1])) - (long.Parse(arr[2]) * long.Parse(arr[3]))}");
    }
}
