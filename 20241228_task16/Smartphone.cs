using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task16
{
    public class Smartphone : ITelephone
    {
        public int Number { get; set; }

        public Smartphone(int number)
        {
            Number = number;
        }

        public void ReceiveMessage(Server server)
        {
            int count = 0;
            foreach (var message in server.Messages)
            {
                if (message.Recipient.Phone == this && message.IsRead == false)
                {
                    count++;
                    Console.WriteLine(message.ToString());
                    message.IsRead = true;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No new messages found");
            }
        }

        public void SendMessage(Server server, Message message)
        {
            server.Messages.Add(message);
            Console.WriteLine($"Message to {message.Recipient.Name} has been sent");
        }
    }
}
