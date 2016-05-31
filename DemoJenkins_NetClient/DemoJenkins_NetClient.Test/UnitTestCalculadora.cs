using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoJenkins_NetClient.BussLog;

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
            Assert.AreEqual(6, CalculadoraFacade.Suma(-2, 4));
        }

        [TestMethod]
        public void TestResta()
        {
            Assert.AreEqual(6, CalculadoraFacade.Resta(10, 4));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(2, CalculadoraFacade.Division(10000,5000));
        }

        [TestMethod]
        public void TestDiviCero()
        {
            Assert.AreEqual(0, CalculadoraFacade.Division(45, 0));
        }


        [TestMethod]
        public void TestBool()
        {
            Assert.AreEqual(true, CalculadoraFacade.checkinputs(1,2));
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
    }
}
