using Banco.classes;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Banco !");
        int Nconta = 1;
        string titularConta = ;   
        string agencia = "bradesco";

        while (true)
        {
            Console.WriteLine("\nEscolha o tipo de conta:");
            Console.WriteLine("1 - Conta Normal");
            Console.WriteLine("2 - Conta Empresa");
            Console.WriteLine("3 - Conta Estudante");


            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                ContaBancaria c = new ContaBancaria(Nconta, agencia, titularConta, 0);
                while (true)
                {
                    Console.WriteLine("1- Para Depositar, 2- Para sacar, 3 para sair");
                    escolha = Convert.ToInt32(Console.ReadLine());
                    c.Deposito (valor);
                }

            }
            else if (escolha == 2)
            {

                ContaEstudante cE = new ContaEstudante();

                Console.WriteLine("Digite o cpf do estudante");
                string cpf = Console.ReadLine();
                Console.WriteLine("informe a instituição");
                string instituição = Console.ReadLine();


            }
            else if (escolha == 3)
            {
                Console.Clear();
                break;
            }



            static void OperacoesConta(ContaBancaria conta)
            {
                while (true)
                {
                    Console.WriteLine("\nEscolha a operação:");
                    Console.WriteLine("1 - Depositar");
                    Console.WriteLine("2 - Sacar");
                    Console.WriteLine("3 - Saldo");
                    Console.WriteLine("4 - Voltar ao menu principal");

                    int operacao = Convert.ToInt32(Console.ReadLine());

                    switch (operacao)
                    {
                        case 1:
                            Console.WriteLine("Digite o valor a ser depositado:");
                            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());
                            conta.Deposito(valorDeposito);
                            break;
                        case 2:
                            Console.WriteLine("Digite o valor a ser sacado:");
                            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());
                            conta.Saque(valorSaque);
                            break;
                        case 3:
                            Console.WriteLine($"Saldo da conta: R$ {conta.SaldoConta}");
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
            } 
        


    