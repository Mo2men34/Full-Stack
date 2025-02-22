internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        Console.WriteLine($"{arr[0]} + {arr[1]} = {int.Parse(arr[0]) + int.Parse(arr[1])}");
        Console.WriteLine($"{arr[0]} * {arr[1]} = {int.Parse(arr[0]) * int.Parse(arr[1])}");
        Console.WriteLine($"{arr[0]} - {arr[1]} = {int.Parse(arr[0]) - int.Parse(arr[1])}");
    }
}
