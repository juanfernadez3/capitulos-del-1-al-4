using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_cap_1_2_3_4.cap_4
{
    class capitulo_4
    {
        // capitulo 4 ejercicio 1
        public void tabla_de_multiplicar()
        {
            int  n;

            Console.WriteLine("Ingrese la tabla desea visualizar");
            n = int.Parse(Console.ReadLine());
            
            for (int cont = 1; cont <= 10; cont++) 
            {
                int r = 0;
                r = n * cont;
                Console.WriteLine("{0} * {1} = {2}", n, cont, r);
            }
        }

        // capitulo 4 ejercicio 2
        public void potencia()
        {
            int b = 0, e = 0;
            double r = 0;

            Console.WriteLine("Ingrese la Base");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Exponente");
            e = int.Parse(Console.ReadLine());
            r = Math.Pow(b,e);

            Console.WriteLine("El resultado es {0}", r);
        }

        // capitulo 4 ejercicio 5
        public void calculo_promedio_mayor_menor()
        {
            int pro = 0, ma = 0, me = 99999999, cpd = 0,total =0, edad =0;

            Console.WriteLine("Ingrese La cantidad de personas a digitar");
            cpd = int.Parse(Console.ReadLine());

            for(int cont=1; cont <= cpd; cont++)
            {
                Console.WriteLine("Ingrese La edad");
                edad = int.Parse(Console.ReadLine());
                total += edad; 
                if(edad < me) { me = edad;}
                if(edad > ma) { ma = edad;}
            }
            pro = total / cpd;

            Console.WriteLine("La edad menor es {0}",me);
            Console.WriteLine("La edad mayor es {0}", ma);
            Console.WriteLine("La edad Promedio es {0}", pro);
        }
    }
}
