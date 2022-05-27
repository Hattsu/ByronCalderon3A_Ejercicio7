using System;
using System.Collections.Generic;
using System.Text;
namespace ByronCalderon3A_Ejercicio7
{
    public class Triangulos
    {
        private int Numero1 { get; set; }
        private int Numero2 { get; set; }
        private int Numero3 { get; set; }
        public triangulo()
        {
            this.Numero1 = 5;
            this.Numero2 = 50;
            this.Numero3 = 5;
        }
        public void Calcular()
        {
            if (Numero1 == Numero2 && Numero1 == Numero3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else if (Numero2 == Numero1  || Numero2 == Numero3 || Numero1  == Numero3)
            {
                Console.WriteLine("Es un triángulo isócseles");
            }
            else
            {
                Console.WriteLine("Es un triangulo escaleno");
            }
        }
    }
}
