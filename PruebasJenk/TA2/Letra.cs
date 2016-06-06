using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TA2
{
    class Letra
    {
        public string nombreLetra{get; set;}


        public Letra(string nombreLetraMayuscula)
        {
            this.nombreLetra = nombreLetraMayuscula.ToLower();
        }
    }
}
