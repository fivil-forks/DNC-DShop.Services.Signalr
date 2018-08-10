using System.Threading.Tasks;
using DDShop.Services.Signalr.Messages.Events;
using DShop.Common.Handlers;
using DShop.Common.RabbitMq;
using DShop.Services.Signalr.Services;

namespace DShop.Services.Signalr.Handlers
{
    public class OperationUpdatedHandler : IEventHandler<OperationUpdated>
    {
        private readonly IHubService _hubService;
        
        public OperationUpdatedHandler(IHubService hubService)
        {
            _hubService = hubService;
        }

        public async Task HandleAsync(OperationUpdated @event, ICorrelationContext context)
            => await _hubService.PublishOperationUpdatedAsync(@event);
    }
}