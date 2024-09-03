using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é de: {saldo}");
        }

        public abstract void Creditar (decimal valor);
    }
}