using System.Threading.Tasks;
using TrainTicketAgentApp.Memory;

namespace TrainTicketAgentApp.Skills
{
    public class UserSkill : ISkill
    {
        public Task<string> ExecuteAsync(MemoryStore memory, string input)
        {
            // Simulate parsing user intent
            memory.Store("last_user_request", input);
            return Task.FromResult($"User wants to {input}");
        }
    }
}