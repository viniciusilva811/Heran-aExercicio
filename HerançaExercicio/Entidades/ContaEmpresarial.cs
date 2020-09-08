using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaExercicio.Entidades
{
    class ContaEmpresarial : Conta
    {
        public double Emprestimo { get; set; }

        public ContaEmpresarial()
        {  
        }

        
        public ContaEmpresarial(int numero, string titular, double saldo, double emprestimo)
        : base(numero, titular, saldo )
        {
            Emprestimo = emprestimo;
        }

        public void Emprest(double dinheiro) 
        {
            if (dinheiro <= Emprestimo) 
            {
                Saldo += dinheiro;
            }
        }
    }
}
