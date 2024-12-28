using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task16
{
    public class Server
    {
        public List<Message> Messages { get; set; }
        public Server()
        {
            Messages = new List<Message>();
        }
    }
}
