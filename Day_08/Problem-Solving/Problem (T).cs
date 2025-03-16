internal class Program
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] original_numbers = new int[3];
        Array.Copy(numbers, original_numbers, 3);
        Array.Sort(numbers);
 
        foreach (var i in numbers)
            Console.WriteLine(i);
 
        Console.WriteLine();
 
        foreach (var i in original_numbers)
            Console.WriteLine(i);
    }
}