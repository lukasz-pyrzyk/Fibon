using System.Threading.Tasks;
using Fibon.Messages.Commands;
using Fibon.Messages.Events;
using RawRabbit;

namespace Fibon.Service.Handlers
{
    public class CalculateValueCommandHandler : ICommandHandler<CalculateValueCommand>
    {
        private readonly IBusClient _busClient;
        private readonly ICalculator _calc;

        public CalculateValueCommandHandler(IBusClient busClient, ICalculator calc)
        {
            _busClient = busClient;
            _calc = calc;
        }

        public async Task HandleAsync(CalculateValueCommand command)
        {
            int result = _calc.Fib(command.Number);

            await _busClient.PublishAsync(new ValueCalculatedEvent { Number = command.Number, Value = result });
        }
    }
}
