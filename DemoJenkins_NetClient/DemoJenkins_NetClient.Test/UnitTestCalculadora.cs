using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoJenkins_NetClient.BussLog;
using System.IO;
using System.Collections.Generic;

namespace DemoJenkins_NetClient.Test
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            Assert.AreEqual(6, CalculadoraFacade.Suma(2, 4));
        }

        [TestMethod]
        public void TestSumaNega()
        {
            Assert.AreEqual(2, CalculadoraFacade.Suma(-2, 4));
        }

        [TestMethod]
        public void TestResta()
        {
            Assert.AreEqual(6, CalculadoraFacade.Resta(10, 4));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(2, CalculadoraFacade.Division(10000, 5000));
        }

        [TestMethod]
        public void TestDiviCero()
        {
            Assert.AreEqual(22, CalculadoraFacade.Division(44, 2));
        }


        [TestMethod]
        public void TestBool()
        {
            Assert.AreEqual(true, CalculadoraFacade.checkinputs(1, 2));
        }

        [TestMethod]
        public void TestBoolNull()
        {
            Assert.AreEqual(false, CalculadoraFacade.checkinputs(0, 0));
        }

        [TestMethod]
        public void TestEspacios()
        {
            Assert.AreEqual("a", CalculadoraFacade.devolverSinEspaciosInicioFinal("   a   "));
        }

        [TestMethod]
        public void TestMinusculas()
        {
            Assert.AreEqual("b", CalculadoraFacade.devolverMinusculas("b"));
        }

        [TestMethod]
        public void TestMinusculasNum()
        {
            Assert.AreEqual("1", CalculadoraFacade.devolverMinusculas("1"));
        }

        [TestMethod]
        public void TestLista()
        {
            Assert.AreEqual(null, CalculadoraFacade.obtenerLista(0));
        }

        [TestMethod]
        public void TestListaGrande()
        {
            Assert.AreEqual(null, CalculadoraFacade.obtenerLista(10000000));
        }

        [TestMethod]
        public void TestSumaDeTextoNumeros()
        {

            List<int> numeros = new List<int>();
            var leer = new StreamReader("C:\\archivo1.txt");

            int[] vec = new int[3];

            int i = 0;
            while (!leer.EndOfStream)
            {
                vec[i] = Convert.ToInt32(leer.ReadLine());
                i++;
            }
            /*
            int numero1 = Convert.ToInt32(leer.ReadLine());
            int numero2 = Convert.ToInt32(leer.ReadLine());
            int respuesta = Convert.ToInt32(leer.ReadLine());
            */

            leer.Close();
            Assert.AreEqual(vec[2], CalculadoraFacade.Suma(vec[0], vec[1]));
        }

        [TestMethod]
        public void TestConcatenarTextodeTexto()
        {
            List<string> letras = new List<string>();
            var leer = new StreamReader("C:\\archivo2.txt");

            while (!leer.EndOfStream)
            {
                letras.Add(leer.ReadLine());
            }

            string texto = string.Empty;

            for (int i = 0; i < letras.Count - 1; i++)
            {
                texto = CalculadoraFacade.concatenar(texto, letras[i]);
            }


            Assert.AreNotEqual(letras[letras.Count - 1], texto);
        }

        [TestMethod]
        public void TestCantidadLetrasdeTexto()
        {
            var leer = new StreamReader("C:\\archivo3.txt");

            string texto = string.Empty;


            texto = leer.ReadLine();
            int cantidad = Convert.ToInt32(leer.ReadLine());



            Assert.AreEqual(cantidad, CalculadoraFacade.cantidadLetras(texto));
        }

        [TestMethod]
        public void TestaMayusculadeTexto()
        {
            var leer = new StreamReader("C:\\archivo4.txt");

            string texto = string.Empty;


            texto = leer.ReadLine();
            string textomayus = leer.ReadLine();



            // texto original "ExigeteInnova"
            Assert.AreEqual(textomayus, CalculadoraFacade.devolverMayusculas(texto));
        }

        [TestMethod]
        public void TestaMinusculadeTexto()
        {
            var leer = new StreamReader("C:\\archivo4.txt");

            string texto = string.Empty;


            texto = leer.ReadLine();
            string textomayus = leer.ReadLine();
            string textomin = leer.ReadLine();



            // texto original "ExigeteInnova"
            Assert.AreEqual(textomin, CalculadoraFacade.devolverMinusculas(texto));
        }

        [TestMethod]
        public void TestseEncontroenTexto()
        {
            var leer = new StreamReader("C:\\archivo5.txt");

            string texto = string.Empty;


            texto = leer.ReadLine();
            string texbuscar = leer.ReadLine();

            Assert.AreEqual(texbuscar, CalculadoraFacade.seEncontroenTexto(texto, texbuscar));
        }
    }
}
