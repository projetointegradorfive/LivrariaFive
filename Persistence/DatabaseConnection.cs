using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LivrariaFive.Persistence
{
    public static class DatabaseConnection
    {
        private const string ConnectionString = "Data Source=DESKTOP-18GHG6D;Initial Catalog=Livraria;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
