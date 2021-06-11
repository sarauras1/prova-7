using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7SaraUras
{
   public class Classe
    {
        public int Codice { get; set; }
        public int Livello { get; set; }
        public Classe(int livello, int codice)
        {
            Codice = codice;
            Livello = livello;

        }
        public Classe()
        {

        }
    }
}
