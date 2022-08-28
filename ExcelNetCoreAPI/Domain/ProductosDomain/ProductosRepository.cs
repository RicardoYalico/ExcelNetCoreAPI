using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ProductosDomain
{
    public class ProductosRepository: IProductosRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public ProductosRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<IEnumerable<Productos>> GetCategorias()
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT * FROM public.productos
                            ";
            return await db.QueryAsync<Productos>(sql, new { });
        }

        public async Task<IEnumerable<Productos>> GetByDateRange(DateTime firstDate, DateTime secondDate)
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT Idartesano , IdItem , IdCategoria , DesCategoria , IdSubcategoria , 
                        DesSubcategoria , IdSublinea , DesSublinea , DesProducto,  NumPrec, TipProducto,
                        AnioCrea, MesCrea, DiaCrea, Fecha
                        FROM public.productos
                        WHERE fecha BETWEEN @FirstDate and  @SecondDate";
            return await db.QueryAsync<Productos>(sql, new { FirstDate = firstDate, SecondDate = secondDate });
        }


    }
}
