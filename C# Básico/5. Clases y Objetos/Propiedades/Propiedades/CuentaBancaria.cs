using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Propiedades
{
    public class CuentaBancaria
    {
        // Auto properties (propiedades automáticas)
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        // backing field
        private decimal _saldo;

        // full property
        public decimal Saldo
        {
            get { return _saldo; }
            set 
            {
                // Si el valor que se trata de asignar es negativo
                // Se asigna por default 0                
                if (value < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                }
                //_saldo = value < 0 ? 0 : value;
            }
        }

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
    }
}
