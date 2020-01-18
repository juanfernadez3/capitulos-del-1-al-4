using System;
using System.Collections.Generic;
using System.Text;
 

namespace ejercicios_cap_1_2_3_4.cap_2
{
    class capitulo_2
    {
        // cap 2 ejercicio 1
        public void perimetro()
        {
            int canntidad_de_lados = 0;
            int medida_lado = 0;
            int perimetro = 0;

            Console.WriteLine("Ingrese la cantidad de lados");
            canntidad_de_lados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de un lado");
            medida_lado = Convert.ToInt32(Console.ReadLine());

            perimetro = canntidad_de_lados * medida_lado;

            Console.WriteLine("El perimetro es {0}", perimetro);
        }

        // cap 2 ejercicio 3
        public void grados_a_radianes()
        {
            int grado = 0;
            double radianes = 0f;

            Console.WriteLine("ingrese el numero de grados a convertit");
            grado = Convert.ToInt32(Console.ReadLine());

            radianes = (Math.PI / 180) * grado;

            Console.WriteLine("Usted introdujo {0} grados que esto equivale a {1} radian", grado, radianes);
        }
        // cap 2 ejercicio 4
        public void grados_centigrados_a_fahrenheit()
        {
            double grados_centigrados = 0, fahrenheit = 0;

            Console.WriteLine("Escribra la cantidad de grados centigrados deseada para comvertien a fahrenheit ");
            grados_centigrados = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (grados_centigrados * 9 / 5) + 32;
            
            Console.WriteLine("Los gfrados centigrados ingresados fueron {0}, eso es un euivalente de {1}", grados_centigrados, fahrenheit);
        }
        // cap 2 ejercicio 5
        public void convertir_dolar_a_euro()
        {
           double euro = 0.90, dolar = 0f, cambio = 0.90;

            Console.WriteLine(" ingrese la cantidad de dolar que desea cambiar");
            dolar = double.Parse(Console.ReadLine());
           
            euro = (dolar * cambio);

            Console.WriteLine("usted introdujo {0} dolares que es el quivalente de {1} euros", dolar, euro);
            Console.WriteLine("la tasa de cambio en el dia de hoy es {0}",cambio);
           
        }
    }

}
