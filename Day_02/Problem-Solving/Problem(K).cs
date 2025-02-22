internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        long x = long.Parse(arr[0]);
        long y = long.Parse(arr[1]);
        long z = long.Parse(arr[2]);
        if (x==y && y==z)
            Console.WriteLine($"{x} {y}");
        else if (x >= y && x >= z)
        {
            if(y>=z)
            {
                Console.WriteLine($"{z} {x}");
            }
            else
            {
                Console.WriteLine($"{y} {x}");
            }
        }
        else if (y >= x && y >= z)
        {
            if (x >= z)
            {
                Console.WriteLine($"{z} {y}");
            }
            else
            {
                Console.WriteLine($"{x} {y}");
            }
        }
        else if(z >= x && z >= y)
        {
            if (x >= y)
            {
                Console.WriteLine($"{y} {z}");
            }
            else
            {
                Console.WriteLine($"{x} {z}");
            }
        }
    }
}