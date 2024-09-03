using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Interfaces;
namespace DesafioProjetoHospedagem.Models
{
    public class Calculadora : ICalculadora
    {
        int ICalculadora.Dividir(int x, int y)
        {
            return x / y;
        }

        int ICalculadora.Multiplicar(int x, int y)
        {
            return x * y;
        }

        int ICalculadora.Somar(int x, int y)
        {
            return x + y;
        }

        int ICalculadora.Subtrair(int x, int y)
        {
            return x - y;
        }

        public int res { get; set; }
        public void MostrarResultado()
        {
            Console.WriteLine($"O resultado da operação é {res}");
        }
    }
}