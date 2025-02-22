internal class Program
{
    static void Main()
    {
        string r = Console.ReadLine();
        double area = (float.Parse(r) * (float.Parse(r))) * 3.141592653;
        Console.WriteLine(area.ToString("f9"));
    }
}
