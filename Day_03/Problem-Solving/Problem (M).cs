internal class Program
{
    static void Main()
    {
        char x = char.Parse(Console.ReadLine());
        Console.WriteLine(char.IsDigit(x)? "IS DIGIT":
                         (char.IsUpper(x)? "ALPHA\nIS CAPITAL":
                          "ALPHA\nIS SMALL"));
    }
}