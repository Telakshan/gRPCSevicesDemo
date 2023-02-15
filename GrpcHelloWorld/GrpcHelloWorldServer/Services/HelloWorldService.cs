using Grpc.Core;
using GrpcHelloWorldServer.Protos;

namespace GrpcHelloWorldServer.Services
{
    public class HelloWorldService: HelloService.HelloServiceBase
    {
        private readonly ILogger<HelloWorldService> _logger;

        public HelloWorldService(ILogger<HelloWorldService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloResponse> SayHello(HelloRequest request, ServerCallContext context)
        {
            string resultMessage = $"Hello {request.Name}";

            var response = new HelloResponse
            {
                Message = resultMessage
            };

            return Task.FromResult(response);
        }

    }
}
