using System;
using System.Security.Cryptography.X509Certificates;
using TicketManagementSystem.Controllers;
using TicketManagementSystem.DB;
using TicketManagementSystem.Model;

namespace TicketManagementSystem
{
    internal class Client
    {
        private static void Menu()
        {
            Console.WriteLine("--- Ticket Management System ---");
            Console.WriteLine(
                "1. Create a ticket!\n" +
                "2. View All Tickets\n" +
                "3. Update a ticket\n" +
                "4. Search a Ticket\n" +
                "5. Delete a Ticket\n" +
                "6. Exit\n"
            );
        }
        public static void Main()
        {
            //Updated
            //TicketOperations operations = new TicketOperations();
            InMemoryDataStore dataStore = new InMemoryDataStore();
            TicketController controller = new TicketController(dataStore);
            try
            {
                while (true)
                {
                    Menu();
                    Console.Write("Enter Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Ticket title: ");
                            var title = Console.ReadLine();
                            Console.Write("Enter Ticket Description: ");
                            var description = Console.ReadLine();
                            controller.CreateTicket(new TicketInfo(
                                Id: Guid.NewGuid().ToString(),
                                title,
                                description,
                                status: TicketStatus.New
                            ));
                            break;
                        case 2:
                            List<TicketInfo> tickets  = controller.ViewAllTickets();
                            foreach (var ticket in tickets)
                            {
                                Console.WriteLine(ticket.ToString());
                            }
                            break;
                        case 3:
                            Console.Write("Enter Ticket Id to update: ");
                            string ticketId = Console.ReadLine().Trim();
                            Console.Write("Enter Ticket title: ");
                            var updatedTitle = Console.ReadLine();
                            Console.Write("Enter Ticket Description: ");
                            var updatedDescription = Console.ReadLine();
                            TicketStatus updatedStatus = TicketStatus.Inprogress;

                            TicketInfo updatedTicket = new TicketInfo(ticketId, updatedTitle, updatedDescription, updatedStatus);
                            controller.UpdateTicket(ticketId,updatedTicket);
                            break;
                        case 4:
                            Console.Write("Enter Ticket Id to Search: ");
                            string ticketIdToSearch = Console.ReadLine().Trim();
                            TicketInfo SearchedTicket = controller.GetTicketInfoById(ticketIdToSearch);
                            Console.WriteLine(SearchedTicket.ToString());
                            break;
                        case 5:
                            Console.Write("Enter Ticket Id to Delete: ");
                            string ticketIdToDelete = Console.ReadLine().Trim();
                            controller.DeleteTicket(ticketIdToDelete);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter a valid choice!");
                            break;
                    }
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine($"Error: {exp}");
            }
        }
    }
}
