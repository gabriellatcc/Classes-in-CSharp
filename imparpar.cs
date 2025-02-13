class Program
{
    static void Main()
    {
        int entrada = 5;
        String resposta;
        Console.Write($"Digite um valor: ");
        int entrada = int.Parse(Console.ReadLine());
        if (entrada % 2 == 0)
        {
            resposta =”par”;
        }
        else
        {
            resposta =”ímpar”;
        }
        Console.WriteLine($"O número informado é: {resposta}");
    }
}