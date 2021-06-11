using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7SaraUras
{
   public class Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DataNascita { get; set; }
        public Persona()
        {

        }
        public Persona(string name, string surname, DateTime data)
        {
            Name = name;
            Surname = surname;
            DataNascita = data;
        }
    }
}
