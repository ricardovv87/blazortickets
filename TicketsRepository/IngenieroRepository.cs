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
    public class IngenieroRepository : IingenieroRepository
    {
        private readonly IDbConnection _dbconnection;

        public IngenieroRepository(IDbConnection dbConnection)
        {
            _dbconnection = dbConnection;
        }

        public async Task DeleteIng(int Id)
        {
            var sql = @"DELETE FROM Ingenieros WHERE Id = @Id";
            var result = await _dbconnection.QueryAsync<Ingeniero>(sql, new { Id = Id });
        }

        public async Task<Ingeniero> GetDetailsInge(int Id)
        {
            var sql = @"SELECT Id,
                               Ingeniero FROM Ingenieros";

            return await _dbconnection.QueryFirstOrDefaultAsync<Ingeniero>(sql, new {Id = Id});
        }

        public async Task<IEnumerable<Ingeniero>> GetIngenieros()
        {
            var sql = @"SELECT Id,Ingeniero FROM Ingenieros";

            return await _dbconnection.QueryAsync<Ingeniero>(sql, new { });
        }
            public async Task<bool> InsertIng(Ingeniero ingeniero)
            {
                try
                {
                    var sql = @"INSERT INTO Ingenieros (Ingneniero) VALUES Ingeniero =@Ingeniero";
                    var result = await _dbconnection.ExecuteAsync(
                            sql, new
                            {
                                ingeniero.ingeniero
                            });
                    return result > 0;
                }
                catch (Exception e)
                {

                    throw e;
                }

            }

        public async Task<bool> UpdateIng(Ingeniero ingeniero)
        {
            var sql = @"UPDATE Ingenieros SET Ingeniero =@Ingieniero WHERE Id = @Id";

            var result = await _dbconnection.ExecuteAsync(sql, new
            {
                ingeniero.ingeniero,
                ingeniero.Id
            });
            return result > 0;
        }
    }

    } 

