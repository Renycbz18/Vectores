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
           
            VectorInicializar();
            Console.ReadKey();
        }

        public static void VectorInicializar()
        {
            int[] x=new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //IMPRIMIR EL VECTOR
            Console.WriteLine("\nELEMENTOS DEL VECTOR\n=============================\n");

            for (int i=0; i<8; i++)
            {
                Console.WriteLine("ELEMENTO INDICE {0} --> {1}", (i + 1), x[i]);
            }

            //SUMATORIA DE LOS VECTORES
            int suma = 0;
            for (int i=0; i < x.Length;i++)
            {
                suma = suma + x[i];
            }

            Console.WriteLine("SUMATORIA ES {0}", suma);
            Console.WriteLine("PROMEDIO ES {0}", (double)suma / x.Length);

            ///////

        }
    }
}
