using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.RedesSocialesArtesanosDomain
{
    public class RedesSocialesArtesanosRepository: IRedesSocialesArtesanosRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public RedesSocialesArtesanosRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }


        public async Task<IEnumerable<RedesSocialesArtesanos>> GetByDateRange(DateTime firstDate, DateTime secondDate)
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT idartesano , IdRedSocial , DesPersona , DesRedSocial  ,IdPersona  ,Fecha 
                        FROM public.redessocialesartesanos 
                        WHERE fecha BETWEEN @FirstDate and  @SecondDate";
            return await db.QueryAsync<RedesSocialesArtesanos>(sql, new { FirstDate = firstDate, SecondDate = secondDate });
        }

        public async Task<IEnumerable<RedesSocialesArtesanos>> GetAllAsync()
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT * FROM public.redessocialesartesanos 
                            ";
            return await db.QueryAsync<RedesSocialesArtesanos>(sql, new { });
        }
    }
}
