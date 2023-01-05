using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Heranca_e_Implementando_Interfaces.Desafios.DesafioAula_03
{
    class Livro
    {
        // Desafio: Agora imagine ter que modelar uma classe de livros com título,
        // autor, ISBN, ano de publicação, estilo literário,
        // número de páginas e país de publicação. Como podemos tornar o ISBN
        // e o título informações obrigatórias, ou seja,
        // algo que a pessoa que cria os objetos da classe precisa passar?

        public string Autor { get; set; }
        public string Titulo { get; private set; }
        public string PaisPublicacao { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public string Isbn { get; private set; }

        public Livro (string isbn,string titulo)
        {
            this.Isbn = isbn;   
            this.Titulo = titulo;
        }
    }
}
