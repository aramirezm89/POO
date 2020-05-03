using System;

namespace POO
{
    class Program
    {

        static void Main(string[] args)
        {
            //instancia de la clase
            Bicicleta Bicicleta1 = new Bicicleta();
            //asignacion de valores a los campos
            Bicicleta1.marca = "Factor";
            Bicicleta1.modelo = "X45";
            Bicicleta1.color = "Roja";
            Bicicleta1.rodada = 23;
            Bicicleta1.velocidades = 7;

            Bicicleta1.Acelerar();
            Bicicleta1.informacion();


            Console.ReadKey();
        } 

    }
}
