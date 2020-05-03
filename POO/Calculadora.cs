using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace POO
{
    class Calculadora
    {
        public double num1;
        public double num2;
        public double resultado;
        public int opcion = 0;
        

        public void Suma()
        {
            resultado = num1 + num2;
            Console.WriteLine(num1 + "+" + num2 + "=" + resultado);
        }

        public void Resta()
        {
            resultado = num1 - num2;
            Console.WriteLine(num1 + "-" + num2 + "=" + resultado);
        }

        public void Multiplicar()
        {
            resultado = num1 * num2;
            Console.WriteLine(num1 + "-" + num2 + "=" + resultado);
        }

        public void dividir()
        {
            if (num1 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por 0");
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine(num1 + "/" + num2 + "=" + resultado);
            }

            
        }
    }
}
