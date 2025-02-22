internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        long i = long.Parse(input);
        long sum = 0;
        while (i > 0)
        {
            sum += i;
            i--;
        }
        Console.WriteLine(sum);
    }
}
