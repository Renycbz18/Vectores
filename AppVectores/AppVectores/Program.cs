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
    }

    }

























