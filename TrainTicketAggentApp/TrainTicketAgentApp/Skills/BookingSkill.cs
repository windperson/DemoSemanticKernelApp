using System.Threading.Tasks;
using TrainTicketAgentApp.Memory;

namespace TrainTicketAgentApp.Skills
{
    public class BookingSkill : ISkill
    {
        public Task<string> ExecuteAsync(MemoryStore memory, string input)
        {
            // Simulate booking
            memory.Store("last_booking", input);
            return Task.FromResult($"Booked train: {input}");
        }
    }
}