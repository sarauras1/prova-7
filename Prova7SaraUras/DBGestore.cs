using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7SaraUras
{
   static class DBGestore
    {
      
      
       
       
                const string connectionString = @"Data Source= (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = Scuola;" +
                                         "Integrated Security=true;";
         

    //Non ho fatto it try catch utente non trovato perche nella traccia non c era
    //specificato che dovevamo creare un metodo trova studente. ho avuto problemi di
    //connessione e ho ritardato quindi non avrei avuto il tempo di implementarlo



private static SqlCommand GetCommand(SqlConnection connection)//metodo per la connesione
        {
            SqlCommand command = new SqlCommand();           
            try
            {
               

                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;                              
              
            }               
             catch (Exception ex) {
                string message = ex.Message;
                Console.WriteLine(message);
            }
            return command;
        }

        

        

        internal static void AddClasse(int livello, int codice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = GetCommand(connection);
                command.CommandText = "insert into dbo.Classe values()";
                command.Parameters.AddWithValue("@Livello", livello);
                command.Parameters.AddWithValue("@Codice", codice);
               


                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        internal static void AddProfessore(string name, string surname, string materia, int anniServizio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = GetCommand(connection);
                command.CommandText = "insert into dbo.Professore values(@Nome, @Cognome, @AnniServizio, @Materia)";
                command.Parameters.AddWithValue("@Nome", name);
                command.Parameters.AddWithValue("@Cognome", surname);
                command.Parameters.AddWithValue("@Materia", materia);
                command.Parameters.AddWithValue("@AnniServizio", anniServizio);


                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        internal static void AddStudente(string name, string surname, string citta, DateTime dataNascita)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               
                SqlCommand command = GetCommand(connection);
                command.CommandText = "insert into dbo.Studente values(@Nome, @Cognome, @DataNascita, @Citta)";
                command.Parameters.AddWithValue("@Nome", name);
                command.Parameters.AddWithValue("@Cognome", surname);
                command.Parameters.AddWithValue("@DataNascita", dataNascita);
                command.Parameters.AddWithValue("@Citta", citta);

                
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
