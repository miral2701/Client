using Microsoft.AspNetCore.SignalR.Client;
namespace Client
{
    internal class Program
    {
        static HubConnection connection;
        static async Task Main(string[] args)
        {
            connection = new HubConnectionBuilder()
                        .WithUrl("https://localhost:7027/kurs")
                        .Build();
            connection.On<string,decimal>("ReceiveMessage", (a,b) =>
            {
                
                    Console.WriteLine($"Message from server: {a}b->{b}");
                
               
            });
            await connection.StartAsync();
            Console.WriteLine("Connected to server");
            Console.ReadLine();
        }

    }
}