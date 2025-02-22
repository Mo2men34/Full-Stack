internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        if (int.Parse(arr[0]) >= int.Parse(arr[1]))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}