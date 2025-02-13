using System;
class Program
{
    static void Main()
    {
        int soma = 0;
        int quantidadeAlunos = 5;
        for (int i = 1; i <= quantidadeAlunos; i++)
        {
            Console.Write($"Digite a idade do aluno {i}: ");
            int idade = int.Parse(Console.ReadLine());
            soma += idade;
        }
        double media = (double)soma / quantidadeAlunos;
        Console.WriteLine($"A média das idades é: {media}");
    }
}