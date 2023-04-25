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
    public class TicketRepository : ITicketRepository
    {
        private readonly IDbConnection _dbConnection;

        public TicketRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }


        public async Task DeleteTicket(int Id)
        {
            var sql = @"DELETE FROM Ticket WHERE Id=@Id";

            var result = await _dbConnection.QueryAsync<Ticket>(sql, new {Id=Id});
        }

        public async Task<Ticket> GetDetails(int Id)
        {
            var sql = @"SELECT Id,
                                Usuario,
                                Fecha,
                                Estado, 
                                Prioridad, 
                                Asunto,
                                Ingeniero,
                                Mensaje,
                                IngenieroMensaje,
                                Telefono,
                                Categoria,
                                Sucursal,
                                FechaSolucion FROM Ticket WHERE Id =@Id";

            return await _dbConnection.QueryFirstOrDefaultAsync<Ticket>(
                sql, new { Id = Id });
                

        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            var sql = @"SELECT Id,Usuario, Fecha, Estado, Prioridad, Asunto, Ingeniero, Mensaje, IngenieroMensaje, FechaSolucion, Telefono, Categoria, Sucursal FROM Ticket";

            return await _dbConnection.QueryAsync<Ticket>(sql, new {});
        }

        public async Task<bool> InsertTicket(Ticket ticket)
        {
            try
            {
                var sql = @"INSERT INTO Ticket (Usuario, Fecha, Estado, Prioridad, Asunto, Ingeniero, Mensaje, IngenieroMensaje, Telefono, Categoria, Sucursal)
                                                VALUES(@Usuario, @Fecha, @Estado, @Prioridad, @Asunto, @Ingeniero, @Mensaje, @IngenieroMensaje, @Telefono, @Categoria, @Sucursal)";

                var result = await _dbConnection.ExecuteAsync(
                    sql, new
                    {
                        ticket.Usuario,
                        ticket.Fecha,
                        ticket.Estado,
                        ticket.prioridad,
                        ticket.Asunto,
                        ticket.Ingeniero,
                        ticket.Mensaje,
                        ticket.IngenieroMensaje,
                        ticket.Telefono,
                        ticket.Categoria,
                        ticket.Sucursal
                        


                    });
                return result > 0;

            }
            catch (Exception e) 
            {
                throw e;
            }
        }

        public async Task<IEnumerable<Ticket>> SoloAbiertos()
        {
            var sql = @"SELECT Id,Usuario, Fecha, Estado, Prioridad, Asunto, Ingeniero, Mensaje, IngenieroMensaje, Telefono, Categoria, Sucursal FROM Ticket where Estado != 'Cerrado'";

            return await _dbConnection.QueryAsync<Ticket>(sql, new { });

        }

        

        public async Task<bool> UpdateTicket(Ticket ticket)
        {
            try
            {
                var sql = @"UPDATE Ticket SET Usuario =@Usuario,
                                                Fecha =@Fecha,
                                                Estado =@Estado,
                                                Prioridad =@Prioridad,
                                                Asunto =@Asunto,
                                                Ingeniero =@Ingeniero,
                                                IngenieroMensaje =@IngenieroMensaje,
                                                Mensaje =@Mensaje,
                                                Telefono =@Telefono,
                                                Categoria =@Categoria,
                                                Sucursal =@Sucursal,
                                                FechaSolucion =@FechaSolucion WHERE Id = @Id";
                                                
                var result = await _dbConnection.ExecuteAsync(
                    sql, new
                    {
                        ticket.Usuario,
                        ticket.Fecha,
                        ticket.Estado,
                        ticket.prioridad,
                        ticket.Asunto,
                        ticket.Ingeniero,
                        ticket.Mensaje,
                        ticket.IngenieroMensaje,
                        ticket.FechaSolucion,
                        ticket.Telefono,
                        ticket.Categoria,
                        ticket.Sucursal,
                        ticket.Id
                    });
                return result > 0;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
