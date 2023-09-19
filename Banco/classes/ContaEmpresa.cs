using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.classes
{

    using System;

    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public string TitularConta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, int agencia, string titularConta, double saldo)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            TitularConta = titularConta;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("saldo insuficiente");
            }
           
        }

        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso. Novo saldo: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }
    }

    public class ContaEmpresa : ContaBancaria
    {
        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresa(int numeroConta, int agencia, string titularConta, double taxaAnuidade, double limiteEmprestimo, double totalEmprestimo,
                 double saldo ): 
            base(numeroConta,agencia,titularConta,saldo)
            
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = 0;
        }

        public void RealizarEmprestimo(decimal valor)
        {
            try
            {
                if (valor <= LimiteEmprestimo)
                {
                    Saldo += valor;
                    TotalEmprestimo += valor;
                    Console.WriteLine($"Empréstimo de R$ {valor} realizado com sucesso. Novo saldo: R$ {Saldo}");
                }
                else
                {
                    throw new Exception("Empréstimo não pode ser concedido devido ao limite excedido.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        public override void Sacar(double valor)
        {
            try
            {
                if (valor <= 5000)
                {
                    base.Sacar(valor);
                }
                else
                {
                    decimal taxaSaque = 5;
                    if (Saldo >= valor + taxaSaque)
                    {
                        Saldo -= valor + taxaSaque;
                        Console.WriteLine($"Saque de R$ {valor} realizado com sucesso. Taxa de saque de R$ {taxaSaque} aplicada. Novo saldo: R$ {Saldo}");
                    }
                    else
                    {
                        throw new Exception("Saldo insuficiente para saque com taxa.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }

   

  