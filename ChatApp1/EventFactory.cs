using App1._0;
using Event_bus_App;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp1
{
    public static class EventFactory
    {
        public static void ReceiveConnection(IEventBus _eventBus)
        {
            var messageReceived = string.Empty;
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "EmailService",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: true,
                                 arguments: null);

            Console.WriteLine(" [*] Waiting for messages.");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($" [x] Received {message}");
                var messageReceived = message;
                if (!string.IsNullOrEmpty(messageReceived))
                {
                    var sendMessage = new SendMessages(_eventBus);
                    sendMessage.SendMessage("Hello from App 1.0");
                }
            };

            channel.BasicConsume(queue: "EmailService",
                                 autoAck: true,
                                 consumer: consumer);

            Console.WriteLine(" Press [enter] to exit.");

            
          
            Console.ReadLine();
        }
    }
}
