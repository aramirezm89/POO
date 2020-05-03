using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Bicicleta
    {
        public string marca;
        public string modelo;
        public int rodada;
        public int velocidades;
        public string color;


        public void Acelerar()
        {
            Console.WriteLine("La bicicleta ha empezado a rodar!!");
        }

        public void frenar()
        {
            Console.WriteLine("La bicicleta se detuvo");
        }

        public void CambioVelocidades()
        {
            Console.WriteLine("La bicicleta cambio su velocidad");
        }

        public void informacion()
        {
            Console.WriteLine("Informacion de la bicicleta: ");
            Console.WriteLine("Marca: "+marca);
            Console.WriteLine("Modelo: "+ modelo);
            Console.WriteLine("rodada:"+ rodada);
            Console.WriteLine("velocidades:"+ velocidades);
            Console.WriteLine("color: "+ color);






        }
    }
}