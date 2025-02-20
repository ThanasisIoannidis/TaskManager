using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace TaskManager
{
    internal class DatabaseHelper
    {
        private string connectionString = "Data Source=tasks.db;Version=3;";

        public DatabaseHelper()
        {
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Tasks (
                                            Task TEXT NOT NULL,
                                            Description TEXT NOT NULL)";

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertTaskIntoDatabase(string task, string description)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO Tasks (Task, Description) VALUES (@Task, @Description)";
                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Task", task);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTaskFromDatabase(string task)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = @"DELETE FROM Tasks WHERE Task = @Task";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Task", task);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Tuple<string, string>> GetAllTasks()
        {
            var tasks = new List<Tuple<string, string>>();


            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string selectQuery = "SELECT Task, Description FROM Tasks";

                using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string task = reader.GetString(0);
                        string description = reader.GetString(1);
                        tasks.Add(new Tuple<string, string>(task, description));
                    }
                }
            }
            return tasks;
        }



    }
}