using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace TP08.Models
{
    public class BDSeries
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-002;DataBase=BDSeries;Trusted_Connection=True;";
        public static Series ListarSeries()
        {
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Series";
                series = db.Query<Series>(sql);
            }
        }
    }
}