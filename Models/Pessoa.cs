using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {

        public Pessoa() {} // construtor padrao
        public Pessoa(string nome, string sobrenome, int idade) // utilizado para que na instancia seja adicionado uns valores por obrigacao. Recebe variavel e adiciona na propriedade
        {
            Nome = nome; // o paramentro [nome] vai ser adicionado na propriedade [Nome] que sera feito a tratativa do valor pelo atributo [_nome]
            Sobrenome = sobrenome; 
            Idade = idade;
        }

        public void Deconstruct(out string nome, out string sobrenome, out int idade) // adiciona a propriedade na variavel
        {
            nome = Nome;
            sobrenome = Sobrenome;
            idade = Idade;
        }

        private string _nome; // vai ser armazenado aqui o valor atribuido na instacia da class e depois sera processado pelo get e set da propriedade e do metodo
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // como esse prop nao tem set, apenas get, pode ser simplificada e escrita desta maneira
        private int _idade;

        public string Nome // primeiro executa o que esta no set e depois executa o get
        {
            get => _nome.ToUpper();
            
            set
            {
                if(value == "") // value e o valor adicionado na instancia da class. O que for atribuido na instancia no arquivo Program vai ser atribuido a value
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }

                _nome = value;
            } 
        }

        public int Idade 
        { 
            get => _idade;
            
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Idade nao pode ser menor que 0");
                }

                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, eu me chamo {NomeCompleto} e tenho {Idade} anos");
        }
    }
}