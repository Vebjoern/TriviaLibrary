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
        // TODO - Move DB to within the solution/project and create relative path to it

        public static void EnsureDbExists()
        {
            string createTriviaTableQuery = @"CREATE TABLE IF NOT EXISTS Trivias (" +
                                        "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "NAME VARCHAR(100) NOT NULL UNIQUE" +
                                        ")";

            string createQuestionTableQuery = @"CREATE TABLE IF NOT EXISTS Questions (" +
                                        "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "QUESTION VARCHAR(512) NOT NULL UNIQUE," +
                                        "ALTERNATIVEA VARCHAR(128) NOT NULL," +
                                        "ALTERNATIVEB VARCHAR(128) NOT NULL," +
                                        "ALTERNATIVEC VARCHAR(128) NOT NULL," +
                                        "ALTERNATIVED VARCHAR(128) NOT NULL," +
                                        "SOLUTION CHAR(1) NOT NULL" +
                                        ")";

            using (var connection = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    if (!System.IO.File.Exists("TriviaLib.db"))
                    {
                        SQLiteConnection.CreateFile("TriviaLib.db");
                    }

                    connection.Open();

                    command.CommandText = createTriviaTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createQuestionTableQuery;
                    command.ExecuteNonQuery();
                    // TODO - consider making a separate method for insert/update queries, e.g. ExecuteQuery(string, Dict<string, objects> args)
                }
            }
        }
        public static void CreateNewTrivia(string collectionName)
        {
            using (var con = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(con))
                {
                    string insertTriviaQuery = "INSERT INTO Trivias (NAME) VALUES (@name)";
                    // TODO - Create the questionlist table here
                    con.Open();

                    command.CommandText = insertTriviaQuery;
                    command.Parameters.AddWithValue("name", collectionName);
                    command.ExecuteNonQuery();
                    // TODO - Add exception handling (e.g. for non-unique name)
                }
            }
        }

        public static List<TriviaModel> GetTrivias()
        {

            List<TriviaModel> TriviaList = new List<TriviaModel>();

            string getTriviasQuery = "SELECT NAME from Trivias";

            using (var con = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(getTriviasQuery, con))
                {
                    con.Open();

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TriviaList.Add(new TriviaModel(reader.GetString(0)));
                    }
                        

                }
            }

            return TriviaList;
         }
        public static void DeleteTrivia(string name)
        {
            string deleteTriviaQuery = "DELETE FROM Trivias WHERE NAME = @name";

            using (var con = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(deleteTriviaQuery, con))
                {
                    con.Open();

                    command.Parameters.AddWithValue("name", name);
                    command.ExecuteNonQuery();
                }
            }

        }

        public static void ImportNewTriviaFromFile()
        {

        }

        public static void ExportTriviaToFile()
        {

        }

       

        public static void AddQuestion(string collectionName, QuestionModel question)
        {
            using (var con = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(con))
                {
                    string insertQuestionQuery = "INSERT INTO Questions " +
                                                "(QUESTION, ALTERNATIVEA, ALTERNATIVEB, ALTERNATIVEC, ALTERNATIVED, SOLUTION)" +
                                                "VALUES (@question, @altA, @altB, @altC, @altD, @sol)";

                    command.Parameters.AddWithValue("@question", question.Question);
                    command.Parameters.AddWithValue("@altA", question.AlternativeA);
                    command.Parameters.AddWithValue("@altB", question.AlternativeB);
                    command.Parameters.AddWithValue("@altC", question.AlternativeC);
                    command.Parameters.AddWithValue("@altD", question.AlternativeD);
                    command.Parameters.AddWithValue("@sol", question.Solution);
                    // TODO - remove all this mess and bind QuestionModel question to a dict and use a separate function for the query? see https://riptutorial.com/csharp/example/17513/creating-simple-crud-using-sqlite-in-csharp
                    //TODO - implement either a FK in the Questions table or a separate table for which trivia(s) a question belongs to

                    con.Open();

                    command.CommandText = insertQuestionQuery;
                    //command.Parameters.AddWithValue("name", collectionName);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteQuestion(string collectionName, QuestionModel question)
        {

        }
        
        public static void EditQuestion(string collectionName, QuestionModel question)
        {

        }
    }
}
