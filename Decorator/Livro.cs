using System;

namespace Decorator
{
    public class Livro : Item
    {
        public string Autor { get; set; }
        public string Nome { get; set; }

        public Livro(string autor, string nome, int quantasCopias) {
            Autor = autor;
            Nome = nome;
            QuantasCopias = quantasCopias;
        }
        public override void Mostrar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Nome do Livro: {Nome}");
            Console.WriteLine($"Quantidade: {QuantasCopias}");
            Console.ResetColor();
        }
    }
}
