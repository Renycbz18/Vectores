﻿using System;
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
            Nombres(nombres);
	    NombresOrde(nombres);
            NombreInprem(nombres);
		
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
	 public static void Vectorestarea()
        {      
            int[] vecto = new int[10];
            int mayor = vecto[0], menor = vecto[0];
            for (int i = 0; i < vecto.Length; i++)
            {
                while (vecto[i] < 1 || vecto[i] > 1000)
                {
                    Console.WriteLine("VALOR {0} DEL VECTOR", i + 1);
                    vecto[i] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < vecto.Length; i++)
            {
                if (vecto[i] > mayor)
                {
                    mayor = vecto[i];
                }
            }
            menor = mayor;
            for (int i = 0; i < vecto.Length; i++)
            {
                if (vecto[i] < menor)
                {
                    menor = vecto[i];
                }
            }
            Console.WriteLine("NUMERO MAYOR: " + mayor);
            Console.WriteLine("NUMERO MENOR: " + menor);
        }
	public static void NombresOrde(string[] x)
		{
			string aux = "";
			for (int i = 0; i < x.Length; i++)
			{
				for (int j = i; j < x.Length; j++)
				{
					if (String.Compare(x[i], x[j], StringComparison.Ordinal) > 0)
					{
						aux = x[i];
						x[i] = x[j];
						x[j] = aux;
					}
				}
			}
		}

		public static void NombreInprem(string[] x)
		{
			foreach (string num in x)
			{
				Console.WriteLine("\nNombres Ordenados: {0}", num);

 }

		public static void Nombres(string[] x)
		{
			for (int i = 0; i < MAX; i++)
			{
				Console.WriteLine("\nColoque los nombres : {0}: ", i + 1);
				x[i] = Console.ReadLine();

			}
		}

























