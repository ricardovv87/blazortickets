using Dapper;
using SistemadeTickets.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsRepository
{
    public class TiposRepository : ITiposRepository
    {
        private readonly IDbConnection _dbconnection;

        public TiposRepository(IDbConnection dbconnection) 
        {
            _dbconnection = dbconnection;
        }


        public async Task<IEnumerable<Tipos>> GetTipos()
        {
            var sql = @"SELECT Id,Categoria FROM Tipos";

            return await _dbconnection.QueryAsync<Tipos>(sql, new { });
        }
    }
}
