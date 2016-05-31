using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJenkins_NetClient.BussLog
{
    public class Letra
    {
        public string letra { get; set; }
 
     public Letra(string nombreLetraMayuscula)
        {
            this.letra = nombreLetraMayuscula.ToLower();
        }
         

    }
}
