using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4_3_7
{
    class Persona7
    {
        public Persona7(int altura, int peso, string colorOjos, string colorPelo)
        {
            this.altura7 = altura;
            this.colorOjos7 = colorOjos;
            this.colorPelo7 = colorPelo;
            this.peso7 = peso;
        }

        public int peso7;
        public int altura7;
        public string colorOjos7;
        public string colorPelo7;

        public void PonerLentillas7(string colorLentillas)
        {
            if (comprobarColor7(colorLentillas))
                this.colorOjos7 = colorLentillas;
        }

        private static bool comprobarColor7(string colorLentillas)
        {
            return colorLentillas.Equals("azul") || colorLentillas.Equals("marron") || colorLentillas.Equals("verde");
        }


        public void Engordar7(int cantidad)
        {
            int nuevo_peso = this.peso7 + cantidad;
            if (nuevo_peso > 180)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                Console.WriteLine("Aumentando el peso en {0} kg", cantidad);
                this.peso7 = nuevo_peso;
            }
        }


        public void Adelgazar7(int cantidad)
        {
            int nuevo_peso = this.peso7 - cantidad;
            if (nuevo_peso < 40)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                // Aquí se le dice a los frenos que actúen, y...
                Console.WriteLine("Reduciendo el peso en {0} kg", cantidad);
                this.peso7 = nuevo_peso;
            }
            

        }
    }
}
