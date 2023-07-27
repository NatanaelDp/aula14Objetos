using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        public bool inadimplente=false;
        public Endereco endereco;

        public Pessoa(string nome, int idade,string rua , string bairro,string cidade ) {
            this.nome = nome;
            this.idade = idade; 
            this.endereco=new Endereco(rua,bairro,cidade);

        }


        public void mostra()
        {
            Console.WriteLine($"Eu sou o {nome} e tenho {idade} anos");
        }
    }
}
