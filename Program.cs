using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
        int idade;

        Console.WriteLine("Avalie se você pode ser doador de sangue: ");
        Console.Write("Qual a sua idade? ");
        idade = Convert.ToInt32(Console.ReadLine());

        if(idade <= 16)
        {
            Console.WriteLine("\nVocê não pode doar sangue");
        }
        if(idade >= 17 && idade <= 69)
        {
            Console.WriteLine("\nVocê pode doar sangue!");
        }
        if(idade >= 70)
        {
            Console.WriteLine("\nVocê não pode doar sangue");
        }
        }
    }
}
