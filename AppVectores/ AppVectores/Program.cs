using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de Versiones");
            Console.WriteLine("Probando la nueva version");
            Console.WriteLine("3 elevaddo a la 4 es igual a: {0}", Potencia(3, 4));
            try
            {
                Console.WriteLine("-5 elevaddo a la 2 es igual a: {0}", Potencia(-5, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message.ToString());
            }
            Console.WriteLine("2 elevaddo a la 5 es igual a: {0}", Potencia(2, 5));
            Console.ReadKey();
        }

        

        public static double Potencia(double x, int y)
        {
            if (x <= 0)
            {
                throw new Exception("X debe ser POSITIVO...");
            }
            if (y <= 0)
            {
                throw new Exception(" Y debe ser POSITIVO....");
            }
            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
            }
            return p;
        }
        public static void vectorinicial()
        {

            int[] x = new int[8];
            x[0] = 10;
            x[1] = 10;
            x[2] = 10;
            x[3] = 10;
            x[4] = 10;
            x[5] = 10;
            x[6] = 10;
            x[7] = 10;
            Console.WriteLine("\nElEmentos del vector\n=====================");
            for (int i = 0; i < 8; i++)
            {

                Console.WriteLine("elemento indice {0} --> {1}", (i + 1), x[i]);

            }

            int s = 0;
            for (int i = 0; i < x.Length; i++)
            {
                s += x[i];

            }
            Console.WriteLine("la sumatoria es {0}", s);
            Console.WriteLine("el pro,edio es  {0}", (double)s / x.Length);
        }
    }
public static void TareaVectores()

		{

			int[] vec = new int[10];

			int mayor = vec[0], menor = vec[0];


			for (int i = 0; i < vec.Length; i++)

			{

				while (vec[i] < 1 || vec[i] > 1000)

				{

					Console.WriteLine("Ingrese valor {0} del vector", i + 1);

					vec[i] = Int32.Parse(Console.ReadLine());

				}


			}

			for (int i = 0; i < vec.Length; i++)

			{

				if (vec[i] > mayor)
                    {

					mayor = vec[i];

				}

			}

			menor = mayor;

			for (int i = 0; i < vec.Length; i++)

			{

				if (vec[i] < menor)

				{

					menor = vec[i];

				}

			}



			Console.WriteLine("El numero mayor es: " + mayor);

			Console.WriteLine("El numero menor es: " + menor);

		
    }

























