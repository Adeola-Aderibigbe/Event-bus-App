using RabbitMQ.Client;
using System.Text;

namespace BackgroundService
{
    public static class EventFactory
    {
        public static void CreateConnection(string message)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "EmailService",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: true,
                                 arguments: null); 
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                                 routingKey: "EmailService",
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine(" [x] Sent {0}",message);
            Console.ReadLine();
        }
    }
}
