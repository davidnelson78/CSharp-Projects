using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace PasswordGenerator
{
    internal class Provider
    {
        private SQLiteConnection dbConnect;

        public Provider(string db, string pass = "")
        {
            try
            {
                if (!File.Exists(db))
                {
                    SQLiteConnection.CreateFile(db);
                }
                dbConnect = new SQLiteConnection(string.Format("Data Source={0};Version=3;", db));
                if (pass != string.Empty)
                {
                    dbConnect.SetPassword(pass);
                }
                dbConnect.Open();
            }
            catch
            {
            }
        }

        public bool CheckTable(string tableName)
        {
            try
            {
                string query = string.Format("SELECT name FROM sqlite_master WHERE type='table' AND name='{0}';", tableName);
                SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
                var table = cmd.ExecuteScalar();
                if (table != null && table.ToString() == tableName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public int CreateTable(string tableName)
        {
            try
            {
                if (!CheckTable(tableName))
                {
                    string query = "CREATE TABLE passwords (id INTEGER PRIMARY KEY, title varchar(255), password varchar(255), customPassword varchar(255))";
                    SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
                    int rowAffected = cmd.ExecuteNonQuery();

                    return rowAffected;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int InsertData(string title, string pass, string customPassword)
        {
            try
            {
                string query = "INSERT INTO passwords(title, password, customPassword) VALUES (@title, @password, @customPassword)";
                SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@customPassword", customPassword);
                int rowAffected = cmd.ExecuteNonQuery();

                return rowAffected;
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateData(int id, string title, string password, string customPassword)
        {
            try
            {
                string query = string.Format(@"UPDATE passwords SET title={0}, password={1}, customPassword={2}
                    WHERE id={3};", "@title", "@password", "@customPassword", id);

                SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@customPassword", customPassword);
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    return rowAffected;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteData(int id, string customPassword = "")
        {
            try
            {
                string query = string.Format("DELETE FROM passwords WHERE id={0}", id);
                if (customPassword != string.Empty)
                {
                    query += string.Format(" and customPassword IS NULL OR customPassword='{1}';", "@customPassword");
                }
                SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
                cmd.Parameters.AddWithValue("@customPassword", customPassword);
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    return rowAffected;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public DataTable GetDataTable(string search = "")
        {
            string query = string.Format("SELECT * FROM passwords");
            if (search != string.Empty)
            {
                query += string.Format(" WHERE title IS NULL OR title LIKE '%{0}%'", search);
            }
            DataTable dt = new DataTable();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
                SQLiteDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        //public SQLiteDataReader GetPasswordDetail(int id)
        //{
        //    string query = string.Format("SELECT * FROM passwords WHERE id='{0}';", id);
        //    SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
        //    SQLiteDataReader detail = null;
        //    try
        //    {
        //        detail = cmd.ExecuteReader();
        //    }
        //    catch
        //    {
        //    }

        //    return detail;
        //}

        public bool CustomIsValid(int id, string customPassword)
        {
            try
            {
                string query = string.Format("SELECT * FROM passwords WHERE id='{0}' AND customPassword='{1}';", id, customPassword);
                SQLiteCommand cmd = new SQLiteCommand(query, dbConnect);
                var password = cmd.ExecuteScalar();
                if (password != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void CloseDb()
        {
            dbConnect.Close();
        }
    }
}