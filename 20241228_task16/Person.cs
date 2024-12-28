using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task16
{
    public class Person
    {
        public string Name { get; set; }
        public ITelephone Phone { get; set; }

        public void CheckMessages(Server server)
        {
            Console.WriteLine($"------------------\nChecking new messages for {Name} on server...");
            Phone.ReceiveMessage(server);
        }

        public void SendMessage(Server server, List<Person> phonebook)
        {
            try
            {
                Console.WriteLine("------------------\nChoose recipient");

                foreach (var contact in phonebook)
                {
                    Console.WriteLine(contact.ToString());
                }

                string recipientName = Console.ReadLine();

                bool result = false;

                foreach (var contact in phonebook)
                {
                    if (contact.Name == recipientName)
                    {
                        result = true;
                    }
                }

                if (!result)
                {
                    throw new Exception("Contact not found!");
                }

                Console.WriteLine("------------------\nType your message:");
                string text = Console.ReadLine();

                Message message = new Message()
                {
                    Date = DateTime.Now,
                    IsRead = false,
                    Text = text,
                    Sender = this,
                    Recipient = phonebook.Find(x => x.Name == recipientName)
                };

                Phone.SendMessage(server, message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Tel. {Phone.Number}";
        }
    }
}
