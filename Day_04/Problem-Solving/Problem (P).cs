internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (char.IsDigit(input[0]))
        {
            if (Convert.ToInt32(input[0]) % 2 == 0)
                Console.WriteLine("EVEN");
            else
                Console.WriteLine("ODD");
        }
    }
}