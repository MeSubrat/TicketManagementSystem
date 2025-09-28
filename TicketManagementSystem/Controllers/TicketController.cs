using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.DB;
using TicketManagementSystem.Model;

namespace TicketManagementSystem.Controllers
{
    internal class TicketController : IController
    {
        private IDataStore _dataStore;
        public TicketController(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }
        public bool CreateTicket(TicketInfo ticket)
        {
            _dataStore.CreateTicket(ticket);
            return true;
        }

        public bool DeleteTicket(string Id)
        {
            _dataStore.DeleteTicket(Id);
            return true;
        }

        public TicketInfo GetTicketInfoById(string ticketId)
        {
            var ticket = _dataStore.GetTicketInfoById(ticketId);
            return ticket;
        }

        public bool UpdateTicket(string ticketId,TicketInfo ticket)
        {
            _dataStore.UpdateTicket(ticketId,ticket);
            return true;
        }

        public List<TicketInfo> ViewAllTickets()
        {
            List<TicketInfo> tickets = _dataStore.ViewAllTickets();
            return tickets;
        }
    }
}
