using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutOfTheBox.model;
using MySql.Data.MySqlClient;

namespace OutOfTheBox.database
{
    internal class MySqlDbConnection: IConnection
    {
        string connectionString;
        MySqlConnection conn;

        public MySqlDbConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void getConnection()
        {
            // Create the connection
            conn = new MySqlConnection("server=localhost;database=mysqltest;uid=root;pwd=root");
        }

        // Create methods

        public void CreateGevangenis(string naam, int maxCapaciteit)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.cmdString = "INSERT INTO gevangenis VALUES(@naam, @maxCapaciteit)";
            cmd.Parameters.AddWithValue("@naam", naam);
            cmd.Parameters.AddWithValue("@maxCapaciteit", maxCapaciteit);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            conn.Close();

        }

        // Select methods

        public Gevangenis SelectGevangenis(string naam)
        {
            Gevangenis gevangenis;

            try
            {
                conn.Open();

                string sql = "SELECT id, naam, gevangeneType, vervroegdVrij, opsluitTermijn " +
                    "FROM Gevangenis WHERE naam=@naam";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@naam", naam);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    gevangenis = new Gevangenis(id, naam, maxCapaciteit);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();

            return gevangenis;
        }
    }
}
