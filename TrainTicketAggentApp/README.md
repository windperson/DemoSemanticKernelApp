# TrainTicketAgentApp

A sample .NET 8 multi-agent console app using Semantic Kernel architectural patterns to search and book train tickets.

[User] <-> [User Agent] <-> [Search Agent] <-> [Booking Agent] <-> [Payment Agent]  

        |<-------------- Shared Memory ---------------------|

## Project Structure

- **Agents/** – Classes for Search, Booking, Payment & User agents.
- **Skills/** – Each agent's skill logic.
- **Memory/** – Simple in-memory key-value store.
- **Orchestration/** – Orchestrator coordinates agent workflow.
- **Program.cs** – Entry point.
