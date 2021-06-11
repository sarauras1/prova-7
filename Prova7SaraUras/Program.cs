using System;

namespace Prova7SaraUras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Menu--------------");

            Console.WriteLine("Scuola Inserimento Studente");
            HelperStudente();
            Console.WriteLine("Ora inserisci la classe dello studente");
            HelperClasse();
            Console.WriteLine("Ora inserisci i dati del relativo professore");
            HelperProfessore();
        }

        private static void HelperProfessore()
        {
            Insegnante ins = new Insegnante();
            Console.WriteLine("Inserisci Nome");
            ins.Name = Console.ReadLine();
            Console.WriteLine("Inserisci Cognome");
            ins.Surname = Console.ReadLine();       
            Console.WriteLine("Inserisci anni servizio");        
            ins.AnniServizio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci Materia insegnata");
            ins.Materia = Console.ReadLine();
            DBGestore.AddProfessore(ins.Name, ins.Surname, ins.Materia, ins.AnniServizio);
        }

        private static void HelperClasse()
        {
            Classe classe = new Classe();
            Console.WriteLine("Inserisci Codice classe");
            classe.Codice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci Livello corso");
            classe.Livello = Convert.ToInt32(Console.ReadLine());
            DBGestore.AddClasse(classe.Livello, classe.Codice);
        }

        private static void HelperStudente()
        {
            Studente studente = new Studente();
            Console.WriteLine("Inserisci Nome");
            studente.Name = Console.ReadLine();
            Console.WriteLine("Inserisci Cognome");
            studente.Surname = Console.ReadLine();
            Console.WriteLine("Inserisci Citta");
            studente.Citta = Console.ReadLine();
            Console.WriteLine("Inserisci data di nascita");
            studente.DataNascita = Convert.ToDateTime(Console.ReadLine());
        DBGestore.AddStudente(studente.Name, studente.Surname, studente.Citta, studente.DataNascita);
        }
    }
    }
}
