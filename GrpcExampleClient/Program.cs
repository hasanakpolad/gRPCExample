using Grpc.Net.Client;
using gRPCExampleService;
using System;
using System.Threading;

namespace GrpcExampleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var greeter = new Greeter.GreeterClient(channel);
            HelloReply reply = greeter.SayHello(new HelloRequest
            {
                Name = "Hasan's Request Example"
            });

            Console.WriteLine(reply.Message);
            Console.ReadKey();
        }
    }
}
