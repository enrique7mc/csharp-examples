using System;

namespace ExcepcionesPropias
{
    public class NegativeNumberException : Exception
    {
        // default constructor                                
        public NegativeNumberException()
            : base("Operación no válida con un número negativo")
        {
            // vacío                                    
        }                          

        // constructor con mensaje de error        
        public NegativeNumberException(string messageValue)
            : base(messageValue)
        {
            // vacío                                    
        }                    

        // constructor con mensaje de error y
        // excepción adicional
        public NegativeNumberException(string messageValue,
           Exception inner)
            : base(messageValue, inner)
        {
            // vacío                                
        } 
    }
}
