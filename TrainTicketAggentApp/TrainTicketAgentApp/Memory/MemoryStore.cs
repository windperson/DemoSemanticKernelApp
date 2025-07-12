using System.Collections.Generic;

namespace TrainTicketAgentApp.Memory
{
    public class MemoryStore
    {
        private readonly Dictionary<string, string> _memory = [];

        public void Store(string key, string value) => _memory[key] = value;

        public string? Retrieve(string key) => _memory.TryGetValue(key, out var value) ? value : null;
    }
}