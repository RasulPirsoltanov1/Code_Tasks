using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { Uri = new Uri("amqps://rctqzmnf:cSXWiUbvEGyuFjyad127zKeycF9KcxMi@jackal.rmq.cloudamqp.com/rctqzmnf") };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "task_queue",
                     durable: true,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

var message = "t.es.t. m.e.ss.age 1";
var body = Encoding.UTF8.GetBytes(message);

var properties = channel.CreateBasicProperties();
properties.Persistent = true;

channel.BasicPublish(exchange: string.Empty,
                     routingKey: "task_queue",
                     basicProperties: properties,
                     body: body);
Console.WriteLine($" [x] Sent {message}");

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();

