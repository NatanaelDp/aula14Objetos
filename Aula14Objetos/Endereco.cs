using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Endereco
    {
        public string rua;
        public string bairro;
        public string cidade;

        public Endereco(string rua ,string bairro , string cidade) { 
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;

        }
        public void mostra()
        {
            Console.WriteLine($"Eu moro na  {rua} no bairro {bairro} e na cidade {cidade}");
        }
    }
}
