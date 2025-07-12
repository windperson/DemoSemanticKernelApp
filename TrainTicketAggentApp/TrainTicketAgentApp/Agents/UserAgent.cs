using TrainTicketAgentApp.Skills;
using TrainTicketAgentApp.Memory;
using System.Threading.Tasks;

namespace TrainTicketAgentApp.Agents
{
    public class UserAgent : AgentBase
    {
        public UserAgent(ISkill skill, MemoryStore memory) : base(skill, memory) { }

        public override async Task<string> ExecuteAsync(string input)
        {
            return await Skill.ExecuteAsync(Memory, input);
        }
    }
}