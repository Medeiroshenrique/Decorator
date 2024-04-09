using System;

namespace Decorator
{
    public class Filme : Item
    {
        public String Diretor { get; set; }
        public String Nome { get; set; }
        public int HorasDuracao { get; set; }

        public Filme(string diretor, string nome, int horasDuracao, int quantidade) {
            Diretor = diretor;
            Nome = nome;
            HorasDuracao= horasDuracao;            
            QuantasCopias = quantidade;
        }

        public override void Mostrar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine($"Diretor: {Diretor}");
            Console.WriteLine($"Nome do Filme: {Nome}");
            Console.WriteLine($"Duração em horas: {HorasDuracao}");
            Console.WriteLine($"Quantidade: {QuantasCopias}");
            Console.ResetColor();
        }
    }
}
