using Common;
namespace BusinessLayer
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
