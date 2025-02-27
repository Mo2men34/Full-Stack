internal class Program
{
    static void Main()
    {
        float[] input = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
        Console.WriteLine(input[0] == 0 && input[1] == 0 ? "Origem"
                       : (input[0] == 0) ? "Eixo Y"
                       : (input[1] == 0) ? "Eixo X"
                       : (input[0] > 0 && input[1] > 0) ? "Q1"
                       : (input[0] < 0 && input[1] > 0) ? "Q2"
                       : (input[0] < 0 && input[1] < 0) ? "Q3"
                       : "Q4");
    }
}