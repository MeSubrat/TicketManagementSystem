using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagementSystem.Model
{
    public class TicketInfo
    {
        public string Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public TicketStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public TicketInfo(string Id, string title, string description, TicketStatus status)
        {
            this.Id = Id;
            this.Title = title;
            this.Description = description;
            this.Status = status;
        }

        public override string ToString()
        {
            return $"Ticket id: {Id},Title:{Title},Description:{Description},Status:{Status},CreatedAt:{CreatedAt}";
        }
    }

}
