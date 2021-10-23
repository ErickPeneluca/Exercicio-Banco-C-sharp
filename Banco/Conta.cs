using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    class Conta
    {
        private int _numero;
        private string _nome;
        private double _saldo;

        public Conta()
        {
        }

        public string Nome
        {
            set
            {
                if (value != null && value.Length > 2)
                {
                    _nome = value;
                }
            }
        }

        public int Numero
        {
            set
            {
                _numero = value;
            }
        }

        public double Saldo
        {
            set { _saldo = value; }
        }

        public void AdicionarDinheiro(double depositoInicial)
        {
            _saldo = depositoInicial + _saldo;
        }

        public void RetirarDinheiro(double saqueInicial)
        {
            _saldo = (_saldo - saqueInicial) - 5;
        }

        public override string ToString()
        {
            return "Conta " + _numero + ", Titular: " + _nome + ", Saldo: $ " + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
