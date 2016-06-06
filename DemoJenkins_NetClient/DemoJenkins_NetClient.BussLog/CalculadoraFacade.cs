using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoJenkins_NetClient.BussLog
{

    public class CalculadoraFacade
    {
        /// private static DemoJenkins_JavaServer.CalculadoraWSClient ws = null;

        private static void Initialize()
        {
            // ws = new DemoJenkins_JavaServer.CalculadoraWSClient();
        }
        public static int Suma(int x, int y)
        {
            //Initialize();
            //return ws.Suma(x, y);

            return x + y;
        }

        public static int Resta(int x, int y)
        {
            // Initialize();
            // return ws.Resta(x, y);
            return x - y;
        }

        public static int Division(int x, int y)
        {

            return x / y;
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
        public static string devolverMayusculas(string pPalabra)
        {
            return pPalabra.ToUpper();
        }

        public static int cantidadLetras(string pPalabra)
        {
            return pPalabra.Length;
        }

        public static string seEncontroenTexto(string textoOri, string textBuscar)
        {
            return textoOri.Contains(textBuscar) ? textBuscar : string.Empty;
        }

        public static string concatenar(string pPalabra1, string pPalabra2)
        {
            return pPalabra1 + pPalabra2;
        }

        public static List<int> obtenerLista(int numeroMaximo)
        {

            List<int> numero = null;

            if (numeroMaximo > 0 && numeroMaximo < 10000000)
            {
                numero = new List<int>();

                for (int i = 1; i <= numeroMaximo; i++)
                {
                    numero.Add(i);
                }
            }

            return numero;
        }

        public static int SumaDeTextoDosNumeros()
        {

            //List<int> numeros = new List<int>();
            //var leer = new StreamReader("archivo1.txt");


            //int numero1 = Convert.ToInt32(leer.ReadLine());
            //int numero2 = Convert.ToInt32(leer.ReadLine());
            //int respuesta = Convert.ToInt32(leer.ReadLine()); 



            //foreach (int num in numeros)
            //{
            //    suma += num;
            //}

            //return suma;
            return 0;
        }

        public static string concatenarTextodeTexto()
        {

            List<string> letras = new List<string>();
            var leer = new StreamReader("archivo2.txt");

            while (!leer.EndOfStream)
            {
                letras.Add(leer.ReadLine());
            }

            string texto = string.Empty;

            foreach (var let in letras)
            {
                texto = texto + " " + let;
            }

            return texto;
        }

        public static int cantidadLetrasdeTexto()
        {
            var leer = new StreamReader("archivo3.txt");

            string texto = string.Empty;

            while (!leer.EndOfStream)
            {
                texto = texto + leer.ReadLine();
            }

            return texto.Length;
        }

        public static string aMayusculadeTexto()
        {
            var leer = new StreamReader("archivo4.txt");

            string texto = string.Empty;

            while (!leer.EndOfStream)
            {
                texto = texto + " " + leer.ReadLine();
            }

            return texto.ToUpper();
        }

        public static string aMinusculadeTexto()
        {
            var leer = new StreamReader("archivo5.txt");

            string texto = string.Empty;

            while (!leer.EndOfStream)
            {
                texto = texto + " " + leer.ReadLine();
            }

            return texto.ToLower();
        }

        public static bool seEncontroenTexto(string palabra)
        {
            var leer = new StreamReader("archivo5.txt");

            string texto = string.Empty;

            while (!leer.EndOfStream)
            {
                texto = texto + leer.ReadLine();
            }

            return texto.Contains(palabra);
        }
    }
}

