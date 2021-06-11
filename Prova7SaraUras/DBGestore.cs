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
         

    //Metodo Utente non trovato? stiamo facendo un iserimento di studenti con relativi esami e professori
    //(non ha senso) e sopratutto sono studenti non utenti  



private static SqlCommand GetCommand(SqlConnection connection)
        {
            try
            {
             
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                return command;
                if (!GetCommand())
                {
                    throw new
                }
            }               
             catch (Exception ex) {
                string message = ex.Message;
                Console.WriteLine(message);
            }
           
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
