using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeTickets.Shared
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public string Estado { get; set; }

        public string prioridad { get; set; }

        public string Asunto { get; set; }

        public string Ingeniero { get; set; }

        public string Mensaje { get; set; }


    }
}
