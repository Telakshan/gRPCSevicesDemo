using Grpc.Net.Client;
using GrpcHelloWorldClient.Protos;

namespace GrpcHelloWorldClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            
            var client = new HelloService.HelloServiceClient(channel);

            var reply = await client.SayHelloAsync(
                    new HelloRequest { Name = "SWN Client" }
                );

            Console.WriteLine( "Greetings: " + reply.Message );
            Console.ReadLine();
        }
    }
}
