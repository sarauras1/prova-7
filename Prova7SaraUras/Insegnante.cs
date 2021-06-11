using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7SaraUras
{
    public class Insegnante : Persona
    {
        public int AnniServizio { get; set; }
        public string Materia { get; set; }
       public Classe Classe { get; set; } =  new Classe();

        public Studente Studente { get; set; } = new Studente();
        public Insegnante(string name, string surname, DateTime data, int annis, string materia)
        {
            AnniServizio = annis;
            Name = name;
            Surname = surname;
            DataNascita = data;
            Materia = materia;
            Classe = new Classe();
            Studente = new Studente();

        }

        public Insegnante()
        {

        }
    }
}
