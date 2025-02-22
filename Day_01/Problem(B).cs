internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        Console.WriteLine(int.Parse(arr[0]));
        Console.WriteLine(long.Parse(arr[1]));
        Console.WriteLine(char.Parse(arr[2]));
        Console.WriteLine(float.Parse(arr[3]));
        Console.Write(double.Parse(arr[4]));
    }
}
