using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Professor : Pessoa
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou um prof Louco de nome {NomeCompleto} e idade {Idade}");
        }
    }
}