internal class Program
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int years = input / 365;
        int months = (input - ((years)*365))/ 30;
        int days = input-((years*365)+(months*30));
        Console.WriteLine($"{years} years\n{months} months\n{days} days");
    }
}