using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    public class EmpleadoHonorarios : Empleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Salario
        {
            // Quitándo impuestos
            get { return SueldoBase * 0.84m; }
        }

        public EmpleadoHonorarios(string nombre, string puesto, decimal sueldoBase) 
            : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por honorarios");
        }
    }
}
