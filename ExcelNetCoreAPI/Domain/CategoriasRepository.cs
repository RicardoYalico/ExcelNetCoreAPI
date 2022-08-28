using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain
{
    public class CategoriasRepository : ICategoriasRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public CategoriasRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<IEnumerable<Categorias>> GetCategorias()
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT * FROM public.categorias
                            ";
            return await db.QueryAsync<Categorias>(sql, new { });
        }

        public async Task<IEnumerable<Categorias>> GetByDateRange(DateTime firstDate, DateTime secondDate)
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT id, descategoria, fecha 
                        FROM public.categorias
                        WHERE fecha BETWEEN @FirstDate and  @SecondDate";
            return await db.QueryAsync<Categorias>(sql, new { FirstDate = firstDate, SecondDate = secondDate });
        }


    }
}
