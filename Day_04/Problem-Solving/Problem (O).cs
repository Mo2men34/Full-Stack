internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int operation_index = 0;
        char operation = '=';
        for (int i = 0; i < input.Length; i++)
            if (input[i] =='+' || input[i] == '-' || input[i] == '*'|| input[i] == '/')
            {
                operation_index = i;
                operation = input[i];
                break;
            }
        int x = int.Parse(input.Substring(0, operation_index));
        int y = int.Parse(input.Substring(operation_index+1));
        switch(operation)
        {
            case '+':
                Console.Write(x + y);
                break;
            case '-':
                Console.Write(x - y);
                break;
            case '*':
                Console.Write(x * y);
                break;
            case '/':
                Console.Write(x / y);
                break;
        }
    }
}