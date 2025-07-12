using System.Threading.Tasks;
using TrainTicketAgentApp.Memory;
using TrainTicketAgentApp.Skills;

namespace TrainTicketAgentApp.Agents
{
    public abstract class AgentBase
    {
        public ISkill Skill { get; }
        public MemoryStore Memory { get; }

        protected AgentBase(ISkill skill, MemoryStore memory)
        {
            Skill = skill;
            Memory = memory;
        }

        public abstract Task<string> ExecuteAsync(string input);
    }
}