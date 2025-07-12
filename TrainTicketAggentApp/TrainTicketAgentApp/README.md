# TrainTicketAgentApp

A sample .NET 8 multi-agent console app using Semantic Kernel architectural patterns to search and book train tickets.

## Structure

- **Agents/** – Classes for Search, Booking, Payment & User agents.
- **Skills/** – Each agent's skill logic.
- **Memory/** – Simple in-memory key-value store.
- **Orchestration/** – Orchestrator coordinates agent workflow.
- **Program.cs** – Entry point.

## How to Run

1. Copy all files into a folder named `TrainTicketAgentApp`.
2. Open `TrainTicketAgentApp.sln` in Visual Studio 2022+.
3. Restore NuGet packages if needed.
4. Build and run.

## Demo

Type your train request (e.g., "Book me a train from Berlin to Paris tomorrow morning.")  
The agents will simulate searching, booking, and payment.

## Extending

- Replace mock skills with real API calls.
- Integrate Semantic Kernel once out of preview/available for NuGet.
- Add LLM for natural language parsing and dialogue.