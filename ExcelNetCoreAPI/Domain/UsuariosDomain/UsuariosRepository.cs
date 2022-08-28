using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.UsuariosDomain
{
    public class UsuariosRepository: IUsuariosRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public UsuariosRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }


        public async Task<IEnumerable<Usuarios>> GetByDateRange(DateTime firstDate, DateTime secondDate)
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT idusuario, TipUsuario, DesNombre, Correo, Sexo, Edad, AnioNac, 
                        MesNac, DiaNac, AnioCrea, MesCrea, DiaCrea, fecha
                        FROM public.usuarios
                        WHERE fecha BETWEEN @FirstDate and  @SecondDate";
            return await db.QueryAsync<Usuarios>(sql, new { FirstDate = firstDate, SecondDate = secondDate });
        }

        public async Task<IEnumerable<Usuarios>> GetAllAsync()
        {
            var db = dbConnection();
            var sql = @" 
                        SELECT * FROM public.usuarios
                            ";
            return await db.QueryAsync<Usuarios>(sql, new { });
        }
    }
}
