using System.Threading.Tasks;
using TrainTicketAgentApp.Memory;

namespace TrainTicketAgentApp.Skills
{
    public interface ISkill
    {
        Task<string> ExecuteAsync(MemoryStore memory, string input);
    }
}