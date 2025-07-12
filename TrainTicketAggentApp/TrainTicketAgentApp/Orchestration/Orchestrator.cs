using System.Threading.Tasks;
using TrainTicketAgentApp.Agents;
using TrainTicketAgentApp.Memory;

namespace TrainTicketAgentApp.Orchestration
{
    public class Orchestrator
    {
        private readonly UserAgent _userAgent;
        private readonly SearchAgent _searchAgent;
        private readonly BookingAgent _bookingAgent;
        private readonly PaymentAgent _paymentAgent;

        public Orchestrator(
            UserAgent userAgent,
            SearchAgent searchAgent,
            BookingAgent bookingAgent,
            PaymentAgent paymentAgent)
        {
            _userAgent = userAgent;
            _searchAgent = searchAgent;
            _bookingAgent = bookingAgent;
            _paymentAgent = paymentAgent;
        }

        public async Task<string> ExecuteAsync(string userRequest)
        {
            var userResult = await _userAgent.ExecuteAsync(userRequest);
            var searchResult = await _searchAgent.ExecuteAsync(userResult);

            // For demo, just pick first train from search
            string chosenTrain = "ICE 123 (08:00)";
            var bookingResult = await _bookingAgent.ExecuteAsync(chosenTrain);

            var paymentResult = await _paymentAgent.ExecuteAsync(chosenTrain);

            return $"{userResult}\n\n{searchResult}\n\n{bookingResult}\n\n{paymentResult}\n\nBooking complete!";
        }
    }
}