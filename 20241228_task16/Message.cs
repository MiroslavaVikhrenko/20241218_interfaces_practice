using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task16
{
    public class Message
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; }
        public Person Recipient { get; set; }
        public Person Sender { get; set; }

        public override string ToString()
        {
            return $"------------------\nFrom: {Sender.Name} \nTo: {Recipient.Name} \nDate: {Date}\nText: {Text}\n";
        }
    }
}
