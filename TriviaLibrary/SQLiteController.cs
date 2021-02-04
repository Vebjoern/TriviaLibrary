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
                                        "TriviaId integer PRIMARY KEY AUTOINCREMENT," +
                                        "TriviaName varchar(100) NOT NULL UNIQUE" +
                                        ")";

            string createQuestionTableQuery = @"CREATE TABLE IF NOT EXISTS Questions (" +
                                        "QuestionId integer PRIMARY KEY AUTOINCREMENT," +
                                        "Question varchar(512) NOT NULL UNIQUE," +
                                        "AlternativeA varchar(128) NOT NULL," +
                                        "AlternativeB varchar(128) NOT NULL," +
                                        "AlternativeC varchar(128) NOT NULL," +
                                        "AlternativeD varchar(128) NOT NULL," +
                                        "Solution CHAR(1) NOT NULL," +
                                        "Category int," +
                                        "FOREIGN KEY(Category) REFERENCES Trivias(TriviaId)" +
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

        public static List<QuestionModel> GetQuestionsFromTrivia(int triviaId)
        {
            string fetchQuestionsFromTrivia = "SELECT Question, AlternativeA, AlternativeB, AlternativeC, AlternativeD, Solution " +
                "FROM Questions WHERE Category = @TriviaId";
            List<QuestionModel> QuestionList = new List<QuestionModel>();

            using (var connection = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    connection.Open();
                    command.CommandText = fetchQuestionsFromTrivia;
                    command.Parameters.AddWithValue("TriviaId", triviaId);

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        QuestionList.Add(new QuestionModel(reader.GetString(0), reader.GetString(1), reader.GetString(2), 
                            reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                    }
                    return QuestionList;
                }
            }
        }

        public static void CreateNewTrivia(string collectionName)
        {
            using (var con = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(con))
                {
                    string insertTriviaQuery = "INSERT INTO Trivias (TriviaName) VALUES (@name)";
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

            string getTriviasQuery = "SELECT TriviaName from Trivias";

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

        public static int GetTriviaId(string collectionName)
        {
            string getTriviaIdQuery = "SELECT TriviaId FROM Trivias " +
                                        "WHERE TriviaName = @name";


            using (var con = new SQLiteConnection(dbCon))
            {
                using(var command = new SQLiteCommand(con)) {
                    command.CommandText = getTriviaIdQuery;
                    command.Parameters.AddWithValue("name", collectionName);

                    con.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return reader.GetInt32(0);
                    }
                }
            }

        }

        public static void DeleteTrivia(string name)
        {
            string deleteTriviaQuery = "DELETE FROM Trivias WHERE TriviaName = @name";
            // TODO - Delete all questions associated with the deleted Trivia?
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
            string insertQuestionQuery = "INSERT INTO Questions " +
                                            "(QUESTION, ALTERNATIVEA, ALTERNATIVEB, ALTERNATIVEC, ALTERNATIVED, SOLUTION, CATEGORY)" +
                                            "VALUES (@question, @altA, @altB, @altC, @altD, @sol, @category)";

            using (var con = new SQLiteConnection(dbCon))
            {
                using (var command = new SQLiteCommand(insertQuestionQuery, con))
                {

                    command.Parameters.AddWithValue("@question", question.Question);
                    command.Parameters.AddWithValue("@altA", question.AlternativeA);
                    command.Parameters.AddWithValue("@altB", question.AlternativeB);
                    command.Parameters.AddWithValue("@altC", question.AlternativeC);
                    command.Parameters.AddWithValue("@altD", question.AlternativeD);
                    command.Parameters.AddWithValue("@sol", question.Solution);
                    command.Parameters.AddWithValue("@category", GetTriviaId(collectionName));
                    // TODO - remove all this mess and bind QuestionModel question to a dict and use a separate function for the query? see https://riptutorial.com/csharp/example/17513/creating-simple-crud-using-sqlite-in-csharp

                    con.Open();
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
