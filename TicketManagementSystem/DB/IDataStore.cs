using TicketManagementSystem.Model;

namespace TicketManagementSystem.DB
{
    public interface IDataStore
    {
        bool CreateTicket(TicketInfo ticket);
        List<TicketInfo> ViewAllTickets();
        bool DeleteTicket(string ticketId);
        bool UpdateTicket(string ticketId, TicketInfo ticket);
        TicketInfo GetTicketInfoById(string ticketId);
    }
}
