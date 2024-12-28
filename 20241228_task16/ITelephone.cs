using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task16
{
    public interface ITelephone
    {
        public int Number { get; }
        void SendMessage(Server server, Message message);
        void ReceiveMessage(Server server);

    }
}
