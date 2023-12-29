
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa // : PESSOA - HERANÇA
    {
        public Aluno()
        {
            
        }

        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar() //POLIMORFISMO EM TEMPO DE EXECUÇÃO - OVERRIDE
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}.");
        }
    }
}