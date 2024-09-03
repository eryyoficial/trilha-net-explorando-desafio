using System.Text;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Interfaces;

// Console.OutputEncoding = Encoding.UTF8;

// // Cria os modelos de hóspedes e cadastra na lista de hóspedes
// List<Pessoa> hospedes = new List<Pessoa>();

// Pessoa p1 = new Pessoa(nome: "Hóspede 1");
// Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// hospedes.Add(p1);
// hospedes.Add(p2);

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 10);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");


//MEUS TESTES
ICalculadora Calc = new Calculadora();
Console.WriteLine(Calc.Somar(2,3));

Professor prof = new Professor();
prof.Nome = "Augusto";
prof.Sobrenome = "Chata";
prof.Idade = 34;
prof.Apresentar();
Corrente c1 = new Corrente();
c1.Creditar(2000);
c1.ExibirSaldo();
c1.Creditar(2000);
c1.ExibirSaldo();