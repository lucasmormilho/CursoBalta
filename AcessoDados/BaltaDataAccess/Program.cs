using System;
using Microsoft.Data.SqlClient;
using Dapper;
using BaltaDataAccess.Models;

namespace BaltaDataAccess;

class Program
{
    static void Main(string[] args)
    {
        const string connectionString = "Server= localhost\\SQLMORMILHO; Database= balta; Integrated Security=SSPI";

        #region CONEXAO ADO
        // usar using fechar a conexao automaticamente
        using (var connection = new SqlConnection(connectionString))
        {
            System.Console.WriteLine("Conectado");
            connection.Open();
            using (var command = new SqlCommand())
            {
                //passar a conexao
                command.Connection = connection;
                //Definir qual  tipo de comando vai usar
                command.CommandType = System.Data.CommandType.Text;
                //Aplicar o comando
                command.CommandText = "SELECT [id], [title] FROM [Category]";

                //ler ou inserir as informações pelo dataREader
                //podia ser executenonquery
                var reader = command.ExecuteReader();

                //percorrer
                while (reader.Read())
                {
                    System.Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                }
            }
            Console.WriteLine("Fim");
        }
        #endregion

        #region DAPPER

        using (var connectionDapper = new SqlConnection(connectionString))
        {
            System.Console.WriteLine("Abre conexao dapper");
            var categories = connectionDapper.Query<Category>("SELECT [Id], [Title] FROM [Category]");
            foreach (var Category in categories)
            {
                System.Console.WriteLine("Dapper" + " - " + Category.Id + " - " + Category.Title);
            }
            System.Console.WriteLine("fim dapper");
        }

        #endregion

    }
}
