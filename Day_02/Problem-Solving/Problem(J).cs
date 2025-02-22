internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        if (double.Parse(arr[0]) % double.Parse(arr[1]) == 0 || double.Parse(arr[1]) % double.Parse(arr[0]) == 0)
            Console.WriteLine("Multiples");
        else
            Console.WriteLine("No Multiples");
    }
}