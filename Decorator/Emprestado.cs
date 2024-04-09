using System;

namespace Decorator
{
    public class Emprestado : Decorator
    {
        //Esta classe eh o decorator concreto
        protected List<string> ItensEmprestados = new List<string>();
        public Emprestado(Item item) : base(item)
        {
        }

        public void Emprestar(string nomeQuemPegouEmprestado) {
            ItensEmprestados.Add(nomeQuemPegouEmprestado);
            this._item.QuantasCopias--;
        }

        public void Devolver(string nome) {
            this.ItensEmprestados.Remove(nome);
            this._item.QuantasCopias++;
            Console.WriteLine($"{nome} acabou de devolver!");
        }

        public override void Mostrar()
        {
            base.Mostrar();
            foreach (string item in ItensEmprestados) {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                Console.WriteLine($"Item emprestado a: {item}");
                Console.ResetColor();
            }
        }
    }
}
