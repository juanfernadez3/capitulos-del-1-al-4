using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_cap_1_2_3_4.cap_3
{
    class capitulo_3
    {

        //capitulo 3 ejercicio 1
        public void par_o_impar()
        {
            float n = 0f;

            Console.WriteLine("Porfavor ingrese el numero a evaluar");
            n = float.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("EL numero que usted ha ingresado es Un numero par");
            }
            else
                {
                    Console.WriteLine("EL numero que usted ha ingresado es Un numero impar");
                }
        }

        //capitulo 3 ejercicio 4
        public void dia_de_semana()
        {
            int d = 0;

            Console.WriteLine("Por favor ingrese un numero del 1 al 7");
            d = int.Parse(Console.ReadLine());   
            if (d == 1) { Console.WriteLine("Domingo"); }   else
            if (d == 2) { Console.WriteLine("Lunes"); }     else
            if (d == 3) { Console.WriteLine("Martes"); }    else
            if (d == 4) { Console.WriteLine("Miercoles"); } else
            if (d == 5) { Console.WriteLine("Jueves"); }    else
            if (d == 6) { Console.WriteLine("Viernes"); }   else
            if (d == 7) { Console.WriteLine("Sabado"); }    
            else { Console.WriteLine("el numero no pertenece a los dias de la semana"); }
        }

        //capitulo 3 ejercicio 5
        public void perimetro_y_area()
        {
            int op = 0;

            Console.WriteLine("Si Desea Calcular El Perimetro ingrese el numero 1");
            Console.WriteLine("Si Desea Calcular El Area ingrese el numero 2");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
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
            }else
               if(op == 2) 
               {
                   int area = 0;
                   int apotema = 0;
                   int perimetro = 0;
                   Console.WriteLine("Ingrese la medida de la apotema");
                   apotema = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Ingrese El Perimetro");
                   perimetro = Convert.ToInt32(Console.ReadLine());
                   area = (perimetro * apotema) / 2;
                   Console.WriteLine("El area es {0}", area);
               }
                else { Console.WriteLine("La opciobn ingresada no es valida"); }
        }
    }
}
