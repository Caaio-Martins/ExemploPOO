using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa // : PESSOA - HERANÇA
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome) //CHAMANDO O PAI : BASE
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar() //POLIMORFISMO EM TEMPO DE EXECUÇÃO - OVERRIDE
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}.");
        }
    }
}