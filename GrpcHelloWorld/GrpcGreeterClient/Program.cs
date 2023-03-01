using Grpc.Net.Client;
using GrpcGreeterClient;

namespace GrpcHelloWorldClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7042");

            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(
                    new HelloRequest { Name = "Hello SWN Client" }
                );

            Console.WriteLine("Greetings: " + reply.Message);
            Console.ReadLine();
        }
    }
}
