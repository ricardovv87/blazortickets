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
    public class SucursalesRepository : ISucursalesRepository
    {
        private readonly IDbConnection _idbconnection;

        public SucursalesRepository(IDbConnection dbconnection) 
        {
            _idbconnection = dbconnection;
        }

        public async Task<IEnumerable<Sucursales>> GetSucursales()
        {
            var sql = @"SELECT Id,Sucursal FROM Sucursales";

            return await _idbconnection.QueryAsync<Sucursales>(sql, new { });
        }
    }
}
