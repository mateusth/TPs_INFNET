using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2_AT
{
    internal class ContaBancaria
    {
        private string titular;
        private double saldo;

        public double Saldo { get => saldo; }
        public string Titular { get => titular; set => titular = value; }

        public void Depositar(double valor)
        {
            if (valor >= 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
            } else
            {
                Console.WriteLine($"O valor do depósito deve ser positivo!");

            }
        }
        public void Sacar(double valor)
        {
            if (valor >= 0 && saldo > 0 && saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Tentativa de saque: R${valor}.");
                Console.WriteLine($"Saldo insuficiente para realizar o saque!");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Ola {titular}, seu saldo é R${saldo}");
        }
    }
}
