using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SBQueueDemo
{
    class Program
    {
static string connectionString = "Endpoint=sb://chinzilla.servicebus.windows.net/;SharedAccessKeyName=UserPolicy;SharedAccessKey=BKzKP7ky7QPAGPgyvU9rjIdfy939fp4D0SWx+Nx6MoQ=;EntityPath=barbie";

        static void Main(string[] args)
        {
           //StringMessagesDemo();
           JsonObjectsDemo();
        }

        private static void JsonObjectsDemo()
        {
           Car aCar= new Car{ Id = 1, Name = "CarName" , Year = 1990};

            var senderClient = QueueClient.CreateFromConnectionString(connectionString);
            var receiveClient = QueueClient.CreateFromConnectionString(connectionString);
            var msgToSend = new BrokeredMessage(new MemoryStream(
                Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(aCar))));
            msgToSend.Label = "JsonDemo";
            msgToSend.TimeToLive = TimeSpan.FromDays(1);
            senderClient.Send(msgToSend);
            Console.WriteLine("msge sent");
            receiveClient.OnMessage(
                  msg =>
                  {

                      var body = msg.GetBody<Stream>(); ;
                      try
                      {
                          dynamic something= JsonConvert.DeserializeObject(new StreamReader(body, true).ReadToEnd());
                          lock (Console.Out)
                          {
                              Console.ForegroundColor = ConsoleColor.Cyan;
                              Console.WriteLine("{0}-{1}", something.Name, something.Year);
                              Console.ResetColor();
                          }
                          msg.Complete();
                      }
                      catch (Exception e)
                      {
                          Console.WriteLine(e.Message);
                          msg.DeadLetter();
                      }
                      
                 
                  },
                  new OnMessageOptions { AutoComplete = false, MaxConcurrentCalls = 1 });
            Console.ReadLine();

        }

        private static void StringMessagesDemo()
        {
            var senderClient = QueueClient.CreateFromConnectionString(connectionString);
            var receiveClient = QueueClient.CreateFromConnectionString(connectionString);

          Parallel.For(0, 10,  (counter) => senderClient.Send(new BrokeredMessage("Message" + counter)));

          receiveClient.OnMessageAsync(
                   async msg =>
                   {

                       var body = msg.GetBody<string>();

                       lock (Console.Out)
                       {
                           Console.ForegroundColor = ConsoleColor.Cyan;
                           Console.WriteLine(body);
                           Console.ResetColor();
                       }
                       await msg.CompleteAsync();
                   },
                   new OnMessageOptions { AutoComplete = false, MaxConcurrentCalls = 1 });

          
          Console.ReadLine();
        }

    }
    [DataContract]
    class Car {
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public string Name { get; set; }
        public int? Id { get; set; }
    }
}
