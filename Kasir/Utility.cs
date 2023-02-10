using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kasir
{
    class Model
    {
        public static int id { set; get; }
        public static string name { set; get; }
        public static char role { set; get; }
    }

    class Command
    {
        public static string connection = @"Data Source=LAPTOP-S8UCE514;Initial Catalog=KasirDB;Integrated Security=True";

        public static SqlConnection conn = new SqlConnection(connection);

        public static DataTable getData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();

            return dt;
        }

        public static void nonGetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    class Enc
    {
        public static string getPass(string pass)
        {
            using (SHA256Managed sha = new SHA256Managed())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
                string password = Convert.ToBase64String(hash);

                return password;
            }
        }
    }
}//' or 1=1 -- Sql Injection Login
