internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();
        double calc = double.Parse(arr[0]) / double.Parse(arr[1]);
        Console.WriteLine($"floor {arr[0]} / {arr[1]} = {(int)calc}");
        Console.WriteLine($"ceil {arr[0]} / {arr[1]} = {ceil(calc)}");
        Console.WriteLine($"round {arr[0]} / {arr[1]} = {round(calc)}");
	//Note: I can use built-in functions like Math.Floor and Math.Ceiling
	//      but I implemented them manually.

    }
    static int ceil(double num)
    {
        if(num == (int)num)
            return (int)num;
        else
            return (int)num + 1;
    }
    static int round(double num)
    {
        double n = num - (int)num;
        if (num == (int)num)
            return (int)num;
        else
        {
            if (n > 0.5)
                return (int)num + 1;
            else if (n < 0.5)
                return (int)num;
            else
                return (int)num + 1;
        }
    }
}
