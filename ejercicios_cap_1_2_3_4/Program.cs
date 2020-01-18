using System;
using ejercicios_cap_1_2_3_4.cap_1;
using ejercicios_cap_1_2_3_4.cap_2;
using ejercicios_cap_1_2_3_4.cap_3;
using ejercicios_cap_1_2_3_4.cap_4;

namespace ejercicios_cap_1_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            capitulo_1 c1 = new capitulo_1();
            capitulo_2 c2 = new capitulo_2();
            capitulo_3 c3 = new capitulo_3();
            capitulo_4 c4 = new capitulo_4();

            Console.WriteLine("Un cordial saludo ING. Almonte");
            Console.WriteLine("Actualmente esta en la realizacion del estudiante:");
            Console.WriteLine("Juan de dios fernandez camilo");
            int cc = 0, ec = 0;
            do{
                
                Console.WriteLine("Ingrese el capitulo que sesea correguir");
                cc = int.Parse(Console.ReadLine());
                if (cc == 1)
                {
                    Console.WriteLine("Ingrese el ejercicio que sesea correguir");
                    ec = int.Parse(Console.ReadLine());
                    if (ec == 1) { c1.imprimir_el_nombre(); }else
                    if (ec == 5) { c1.Mensajes_extras(); }

                }
                else

                if (cc == 2)
                {
                    Console.WriteLine("Ingrese el ejercicio que sesea correguir");
                    ec = int.Parse(Console.ReadLine());

                    if (ec == 1) { c2.grados_centigrados_a_fahrenheit(); }else
                    if (ec == 3) { c2.convertir_dolar_a_euro(); }else
                    if (ec == 4) { c2.grados_a_radianes(); }else
                    if (ec == 5) { c2.perimetro(); }

                }
                else

                if (cc == 3)
                {
                    Console.WriteLine("Ingrese el ejercicio que sesea correguir");
                    ec = int.Parse(Console.ReadLine());

                    if (ec == 1) { c3.par_o_impar(); }else
                    if (ec == 4) { c3.dia_de_semana(); }else
                    if (ec == 5) { c3.perimetro_y_area(); }
                }

                if (cc == 4)
                {
                    Console.WriteLine("Ingrese el ejercicio que sesea correguir");
                    ec = int.Parse(Console.ReadLine());

                    if (ec == 1) { c4.tabla_de_multiplicar(); }else
                    if (ec == 2) { c4.potencia(); }else
                    if (ec == 5) { c4.calculo_promedio_mayor_menor(); }
                }

                Console.WriteLine("para continuar precione 1");
                Console.WriteLine("para Salir precione 2");
                op = int.Parse(Console.ReadLine());
                System.Console.Clear();
            } while (op != 2) ;
         
        }
    }
}
