using System.Threading.Tasks;
using TrainTicketAgentApp.Memory;

namespace TrainTicketAgentApp.Skills
{
    public class SearchSkill : ISkill
    {
        public Task<string> ExecuteAsync(MemoryStore memory, string input)
        {
            // Simulate train search
            memory.Store("last_search", input);
            string trains = "- ICE 123 (08:00)\n- TGV 456 (09:30)";
            return Task.FromResult($"Searched trains for: {input}\nAvailable trains:\n{trains}");
        }
    }
}