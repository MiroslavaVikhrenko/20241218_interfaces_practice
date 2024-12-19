using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public interface IPart
    {
        Guid Id { get; }
        void Inform();
    }
}
