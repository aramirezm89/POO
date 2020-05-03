using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace POO
{
    class Program
    {

        static void Main(string[] args)
        {
            ////instancia de la clase
            //Bicicleta Bicicleta1 = new Bicicleta();
            ////asignacion de valores a los campos
            //Console.WriteLine("Primera bicicleta");
            //Bicicleta1.marca = "Factor";
            //Bicicleta1.modelo = "X45";
            //Bicicleta1.color = "Roja";
            //Bicicleta1.rodada = 23;
            //Bicicleta1.velocidades = 7;
            //Bicicleta1.Acelerar();
            //Bicicleta1.informacion();




            //Console.WriteLine("\n\nSegunda bicicleta");
            //Bicicleta bicicleta2 = new Bicicleta();
            //Bicicleta1.marca = "BIANCHI";
            //Bicicleta1.modelo = "j78";
            //Bicicleta1.color = "NEGRO";
            //Bicicleta1.rodada = 22;
            //Bicicleta1.velocidades = 10;

            //bicicleta2.informacion();
            //Console.WriteLine("\n\nPulse cualquier tecla");
            //Console.ReadKey();


            Calculadora calculadora1 = new Calculadora();
            Console.WriteLine("Ingresa numero");
            calculadora1.num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa numero");
            calculadora1.num2 = Convert.ToDouble(Console.ReadLine());
           
            while ((calculadora1.opcion > 0 && calculadora1.opcion < 4 )==false) 
            {
                Console.WriteLine("Ingrese opcion 1: para  sumar\nIngrese opcion 2: para restar\nIngrese opcion3 Para Multiplicar\nIngrese opcion 4: para dividir");
                calculadora1.opcion = Convert.ToInt32(Console.ReadLine());

            }
       

            if (calculadora1.opcion == 1)
            {

                calculadora1.Suma();
            }
            if (calculadora1.opcion == 2)
            {
                calculadora1.Resta();
            }
            if (calculadora1.opcion == 3)
            {
                calculadora1.Multiplicar();
            }
            if (calculadora1.opcion == 4)
            {
                calculadora1.dividir();
            }
           

        } 

    }
}
