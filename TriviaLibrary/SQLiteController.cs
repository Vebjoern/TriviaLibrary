using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TriviaLibrary
{
    public static class SQLiteController
    {
        private static readonly string dbCon = "Data source=TriviaLib.db";
        // TODO - Move DB to within the solution and create relative path to it

        public static void EnsureDbExists()
        {
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Trivias (" +
                                        "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "NAME VARCHAR(100) NOT NULL UNIQUE" +
                                        ")";

            using (var connection = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    if(!System.IO.File.Exists("TriviaLib.db"))
                    {
                        SQLiteConnection.CreateFile("TriviaLib.db");
                    }

                    connection.Open();

                    command.CommandText = createTableQuery;
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void CreateNewTrivia(string collectionName)
        {
            using(var con = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(con))
                {
                    string insertTriviaQuery = "INSERT INTO Trivias (NAME) VALUES (@name)";

                    con.Open();

                    command.CommandText = insertTriviaQuery;
                    command.Parameters.AddWithValue("name", collectionName);
                    command.ExecuteNonQuery();
                    // TODO - Add catch for non-unique name
                }
            }
        }

        public static void ImportNewTriviaFromFile()
        {

        }

        public static void ExportTriviaToFile()
        {

        }

        public static void DeleteTrivia(string collectionName)
        {

        }

        public static void AddQuestion(string collectionName, QuestionModel question)
        {

        }
        public static void DeleteQuestion(string collectionName, QuestionModel question)
        {

        }
        
        public static void EditQuestion(string collectionName, QuestionModel question)
        {

        }
    }
}
