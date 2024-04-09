using System;

namespace Decorator {
    public class Program {
        static void Main(string[] args) {
            Livro livro = new Livro("Token","Lord of Rings",5);
            livro.Mostrar();

            Filme filme = new Filme("Zack Snyder","Justice League: Snyder's cut",2,3);
            filme.Mostrar();

            Emprestado itensEmprestados = new Emprestado(livro);
            itensEmprestados.Emprestar("Celia Pontes Medeiros");
            itensEmprestados.Emprestar("Gustavo Rodrigues");

            itensEmprestados.Mostrar();

            itensEmprestados.Devolver("Gustavo Rodrigues");

            itensEmprestados.Mostrar();

            itensEmprestados.Devolver("Celia Pontes Medeiros");

            itensEmprestados.Mostrar();

        }
    }
}