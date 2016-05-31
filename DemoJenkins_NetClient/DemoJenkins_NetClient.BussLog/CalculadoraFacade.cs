using System;
using System.Collections.Generic;
using System.Text;

namespace DemoJenkins_NetClient.BussLog 
{
    
    public class CalculadoraFacade
    {
        private static DemoJenkins_JavaServer.CalculadoraWSClient ws = null;

        private static void Initialize()
        {
            ws = new DemoJenkins_JavaServer.CalculadoraWSClient();
        }
        public static int Suma(int x, int y)
        {
            Initialize();
            return ws.Suma(x, y);
        }

        public static int Resta(int x, int y)
        {
            Initialize();
            return ws.Resta(x, y);
        }

        public static int Division(int x, int y)
        {
            
            return x/y;
        }

        public static bool checkinputs(int a, int b)
        {
            bool condition = true;
            
            if (a == b)
            {
                condition = false;
            }
            else
            {
                condition = true;
            }

            return condition;
        }

        public static string devolverSinEspaciosInicioFinal(string pPalabraoriginal)
        {
            // devuelves quitandole los espacios.
            return pPalabraoriginal.Trim();
        }

        public static string devolverMinusculas(string pPalabraMayuscula)
        {
            Letra letra = new Letra(pPalabraMayuscula);
            return letra.letra;
        }

        public static List<int>  obtenerLista(int numeroMaximo)
        {

            List<int> numero = null;

            if (numeroMaximo <= 0)
            {
                numero = new List<int>();

                for (int i = 1; i <= numeroMaximo; i++)
                {
                    numero.Add(i);
                }
            }

            return numero;
        }
     }
}

