using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//tentativa segundo commit //segunda
namespace Banco.classes
{
    internal class ContaEstudante
    {
        public class ContaEstudantee : ContaBancaria
        {
            public double LimiteChequeEspecial { get; set; }
            public string CPF { get; set; }
            public string InstituicaoEnsino { get; set; }

            public ContaEstudantee(int numeroConta, int agencia, int titularConta, double limiteChequeEspecial, string cpf, string instituicaoEnsino,double saldo):
                base(numeroConta,titularConta,saldo)
               
            {
         
                LimiteChequeEspecial = limiteChequeEspecial;
                CPF = cpf;
                InstituicaoEnsino = instituicaoEnsino;
            }

            public override void Sacar(double valor)
            {
                
                
                    if (valor <= Saldo + LimiteChequeEspecial)
                    {
                        Saldo -= valor;
                        
                    }
                    else
                    {
                    Console.WriteLine("Limite de cheque especial excedido. Saldo insuficiente para saque."); 
                    }
                }
                
            }
        }
    }
}
