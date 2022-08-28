using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ArtesanosDomain
{
    public class ArtesanosRepository: IArtesanosRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public ArtesanosRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }


        public async Task<IEnumerable<Artesanos>> GetByDateRange(DateTime firstDate, DateTime secondDate)
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT idartesano, idpersona, despersona, inditems, indactivo, desdepa, desprov, desdist, codubigeoasumido, aniocrea, mescrea, diacrea, fecha
	                    FROM public.artesanos
                        WHERE fecha BETWEEN @FirstDate and  @SecondDate";
            return await db.QueryAsync<Artesanos>(sql, new { FirstDate = firstDate, SecondDate = secondDate });
        }

        public async Task<IEnumerable<Artesanos>> GetAllAsync()
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT * FROM public.artesanos
                            ";
            return await db.QueryAsync<Artesanos>(sql, new { });
        }
    }
}
