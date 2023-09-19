using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//teste
namespace Banco.classes
{

    using System;
    using System.Security.Cryptography.X509Certificates;

   

    public class ContaEmpresa : ContaBancaria
    {
        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }
        public double SaldoConta { get; private set; }

        public ContaEmpresa(int NConta, int agencia, string titularConta, double taxaAnuidade, double limiteEmprestimo, double totalEmprestimo,
                 double saldo ): 
            base(NConta,agencia,titularConta,saldo)
            
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = 0;
        }

        public ContaEmpresa(double taxaAnuidade, double limiteEmprestimo, double totalEmprestimo)
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }
    }


    public override void Sacar(double valor)
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
                    Console.WriteLine("Saldo insuficiente para saque com taxa."); 
                    }
                }
            
           
        }
    }

   

  
