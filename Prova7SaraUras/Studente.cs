using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7SaraUras
{
   public class Studente: Persona
    {
      
        public string Citta { get; set; }


        public Studente(string name, string surname, DateTime data, string  citta)
        {
            Name = name;
            Surname = surname;
            DataNascita = data;
            Citta = citta;

        }
        public Studente()
        {

        }

    }
}
