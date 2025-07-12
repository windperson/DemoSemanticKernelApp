using System;
using System.Threading.Tasks;
using TrainTicketAgentApp.Agents;
using TrainTicketAgentApp.Orchestration;
using TrainTicketAgentApp.Memory;
using TrainTicketAgentApp.Skills;

namespace TrainTicketAgentApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var memory = new MemoryStore();

            // Create agents
            var searchAgent = new SearchAgent(new SearchSkill(), memory);
            var bookingAgent = new BookingAgent(new BookingSkill(), memory);
            var paymentAgent = new PaymentAgent(new PaymentSkill(), memory);
            var userAgent = new UserAgent(new UserSkill(), memory);

            // Orchestrator
            var orchestrator = new Orchestrator(
                userAgent,
                searchAgent,
                bookingAgent,
                paymentAgent);

            Console.WriteLine("Welcome to TrainTicketAgentApp!");
            Console.WriteLine("Type your request (e.g., 'Book me a train from Berlin to Paris tomorrow morning.')");
            string? userInput = Console.ReadLine();

            if (userInput != null)
            {
                var result = await orchestrator.ExecuteAsync(userInput);
                Console.WriteLine("\n--- Result ---");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }
    }
}