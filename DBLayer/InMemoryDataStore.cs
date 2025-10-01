using Common;
namespace DBLayer
{
    public class InMemoryDataStore : IDataStore
    {
        private static List<TicketInfo> Tickets = new List<TicketInfo>();

        public bool CreateTicket(TicketInfo ticket)
        {
            if (ticket != null)
            {
                Tickets.Add(ticket);
                return true;
            }
            return false;
            
        }

        public bool DeleteTicket(string ticketId)
        {
            var ticket = Tickets.Find(t => t.Id == ticketId);
            if (ticket != null)
            {
                Tickets.Remove(ticket);
                return true;
            }
            return false;
        }

        public TicketInfo GetTicketInfoById(string ticketId)
        {
            var ticket = Tickets.Find(t => t.Id == ticketId);
            return ticket;
        }

        public bool UpdateTicket(string ticketId,TicketInfo ticket)
        {
            var ticketToUpdate = Tickets.Find(t => t.Id == ticket.Id);
            if (ticketToUpdate != null)
            {
                ticketToUpdate.Id = ticket.Id;
                ticketToUpdate.Title = ticket.Title;
                ticketToUpdate.Description = ticket.Description;
                ticketToUpdate.CreatedAt = ticket.CreatedAt;
                ticketToUpdate.Status = ticket.Status;
                return true;
            }
            return false;
        }

        public List<TicketInfo> ViewAllTickets()
        {
            return Tickets;
        }

    }
}
