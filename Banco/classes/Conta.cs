using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.classes
{
    internal class ContaBancaria
    {
        private int nConta;
        private int agencia;
        private string titularConta;
        private double saldo;

        public ContaBancaria(int nConta, int agencia, string titularConta, double saldo)
        {
            this.nConta = nConta;
            this.agencia = agencia;
            this.titularConta = titularConta;
            this.saldo = saldo;
        }

        public void RealizarEmprestimo(double valor)
        {
           
                if (valor <= LimiteEmprestimo - TotalEmprestimo)
                {
                    SaldoConta += valor;
                    TotalEmprestimo += valor;
                    Console.WriteLine($"Empréstimo de R$ {valor} realizado com sucesso. Novo saldo: R$ {Saldo}");
                }
                else
                {
                Console.WriteLine("Empréstimo não pode ser concedido devido ao limite excedido."); 
                }
            }

        public class ContaBancariaa : ContaBancariaaBase
        {
            public int NumeroConta { get; set; }
            public int Agencia { get; set; }
            public string TitularConta { get; set; }
            public double SaldoConta { get; set; }
            public double Depositar { get; set; }

            public ContaBancariaa(int NConta, int agencia, string titularConta, double saldo)
            {
                NumeroConta = NConta;
                Agencia = agencia;
                TitularConta = titularConta;
                SaldoConta = saldo;
            }

            public override void Saque(double valor)
            {
                if (SaldoConta >= 5000)
                {
                    SaldoConta -= 5;
                    Console.WriteLine($"Saque de R$ {valor} realizado com sucesso. Novo saldo: R$ {SaldoConta}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para saque.");
                }

            }

        }
    }
}
