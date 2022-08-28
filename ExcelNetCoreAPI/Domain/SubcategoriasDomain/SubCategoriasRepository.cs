using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.SubcategoriasDomain
{
    public class SubCategoriasRepository : ISubCategoriasRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public SubCategoriasRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }


        public async Task<IEnumerable<SubCategorias>> GetByDateRange(DateTime firstDate, DateTime secondDate)
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT idsubcategoria, dessubcategoria, fecha 
                        FROM public.subcategorias
                        WHERE fecha BETWEEN @FirstDate and  @SecondDate";
            return await db.QueryAsync<SubCategorias>(sql, new { FirstDate = firstDate, SecondDate = secondDate });
        }

        public async Task<IEnumerable<SubCategorias>> GetAllAsync()
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT * FROM public.subcategorias
                            ";
            return await db.QueryAsync<SubCategorias>(sql, new { });
        }


    }
}
