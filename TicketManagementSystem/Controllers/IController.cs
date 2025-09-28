using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.Model;

namespace TicketManagementSystem.Controllers
{
    public interface IController
    {
        bool CreateTicket(TicketInfo ticket);
        List<TicketInfo> ViewAllTickets();
        bool DeleteTicket(string Id);
        bool UpdateTicket(string ticketId, TicketInfo ticket);
        TicketInfo GetTicketInfoById(string ticketId);
    }
}
