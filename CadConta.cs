using System;
using System.Globalization;
namespace BancoUdemy
{
    public class CadConta
    {

        public string Nome { get; set; } //Nome pode ser alterado em casos especificos : casamento, alteração de gênero, etc...
        public double Saldo { get; private set; }
        public int Numero { get; private set; } //Conta não pode ser alterada nunca

        public CadConta()
        {

        }
        public CadConta(int numero, string nome)
        {
            Nome = nome;
            Numero = numero;

        }
        public CadConta(int numero, string nome, double saldo) : this(numero, nome)
        {
            Deposito(saldo);
        }

        public void Deposito(double quantia){
            Saldo += quantia;
        }

        public void Saque(double quantia){
            Saldo -= quantia + 5.0; //5 é o valor da taxa de saque
        }
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular:" + Nome + ", Saldo : $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}