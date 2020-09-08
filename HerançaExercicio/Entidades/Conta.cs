using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaExercicio.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double dinheiro)
        {
            Saldo -= dinheiro;
        }

        public void Deposito(double dinheiro)
        {
            Saldo += dinheiro;
        }
    }
}
