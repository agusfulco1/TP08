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
        private static List<Series> listaSeries = new List<Series>();
        private static List<Actores> listaActores = new List<Actores>();
        private static List<Temporadas> listaTemporadas = new List<Temporadas>();
        private static string _connectionString = @"Server=A-PHZ2-CIDI-006;DataBase=BDSeries;Trusted_Connection=True;";
        public static List<Series> ListarSeries()
        {
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Series";
                return listaSeries = db.Query<Series>(sql).ToList();
            }
        }
        public static List<Actores> ListarActores(int idS)
        {
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Actores WHERE IdSerie = @Pidserie";
                return listaActores = db.Query<Actores>(sql, new {Pidserie = idS}).ToList();
            }
        }
        public static List<Temporadas> ListarTemporadas(int idS)
        {
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Temporadas WHERE IdSerie = @Pidserie";
                return listaTemporadas = db.Query<Temporadas>(sql, new {Pidserie = idS}).ToList();
            }
        }
        public static Series VerInfoSerie(int idS)
        {
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Series WHERE IdSerie = @Pidserie";
                return listaTemporadas = db.Query<Temporadas>(sql, new {Pidserie = idS}).ToList();
            }
        }
    }
}