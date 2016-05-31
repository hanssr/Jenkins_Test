using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TA2
{
    public class Util
    {
        public string devolverSinEspaciosInicioFinal(string pPalabraoriginal)
        {
            // devuelves quitandole los espacios.
            return pPalabraoriginal.Trim();
        }

        public string devolverMinusculas(string pPalabraMayuscula)
        {
            Letra letra = new Letra(pPalabraMayuscula);
            return letra.nombreLetra;
        }

        public List<int>  obtenerLista(int numeroMaximo)
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
