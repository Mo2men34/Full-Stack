internal class Program
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());

        if (input % 1 == 0)
        {
            Console.WriteLine($"int {input}");
        }
        else
        {
            int integer_part = (int)input;
            double decimal_part = input - integer_part;
            Console.WriteLine($"float {integer_part} {decimal_part:F3}");
        }
    }
}