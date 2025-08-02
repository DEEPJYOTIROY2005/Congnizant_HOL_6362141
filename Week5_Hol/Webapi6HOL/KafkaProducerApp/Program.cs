using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Kafka Producer Started. Type messages to send:");

        while (true)
        {
            Console.Write("You: ");
            var message = Console.ReadLine();
            if (message?.ToLower() == "exit") break;

            var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
            Console.WriteLine($"✔ Sent to {result.TopicPartitionOffset}");
        }
    }
}
