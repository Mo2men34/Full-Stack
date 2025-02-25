internal class Program
{
    static void Main()
    {
        char x = char.Parse(Console.ReadLine());
        Console.WriteLine(char.IsUpper(x)? 
                          char.ToLower(x):char.ToUpper(x));
    }
}