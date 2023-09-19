namespace Banco.classes
{
    public class ContaBancariaaBase
    {

        public void Depositar(double valor)
        {
            if (valor >= 0)
            {
                SaldoConta += valor;
            }
            else
            {
                Console.WriteLine("saldo insuficiente");
            }

        }
    }
}