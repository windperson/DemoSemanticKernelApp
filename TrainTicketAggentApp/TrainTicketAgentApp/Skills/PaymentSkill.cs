using System.Threading.Tasks;
using TrainTicketAgentApp.Memory;

namespace TrainTicketAgentApp.Skills
{
    public class PaymentSkill : ISkill
    {
        public Task<string> ExecuteAsync(MemoryStore memory, string input)
        {
            // Simulate payment
            memory.Store("last_payment", input);
            return Task.FromResult($"Processed payment for: {input}");
        }
    }
}