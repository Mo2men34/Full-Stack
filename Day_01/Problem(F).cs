internal class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] arr = input.Split();
        int x = (int.Parse(arr[0])) % 10;
        int y = (int.Parse(arr[1])) % 10;

        Console.WriteLine(x + y);
    }
}
