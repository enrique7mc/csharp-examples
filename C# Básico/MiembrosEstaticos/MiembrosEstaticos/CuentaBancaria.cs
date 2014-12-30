using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiembrosEstaticos
{
    public class CuentaBancaria
    {
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        private decimal _saldo;

        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                _saldo = value < 0 ? 0 : value;
            }
        }

        public static string Banco { get; set; }

        #region constructores
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta, string usuario)
            : this(noCuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo)
            : this(noCuenta, usuario)
        {
            Saldo = saldo;
        }

        public CuentaBancaria() { }
        #endregion

        #region métodos de instancia
        public void Retirar(decimal cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            Saldo -= cantidad;
        }

        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
        }

        public override string ToString()
        {
            return string.Format("NoCuenta: {0}, Usuario: {1}, Saldo: ${2}, Banco: {3}", 
                NoCuenta, Usuario, Saldo, Banco);
        }
        #endregion

        // Los métodos estáticos solo pueden acceder directamente
        // a otros miembros estáticos (métodos o propiedades)
        public static void AsignarBanco(string banco)
        {
            Console.WriteLine("Asignando nuevo banco...");
            Banco = banco;

            // Saldo = 10; // Error Saldo no es una propiedad estática
        }
    }
}
