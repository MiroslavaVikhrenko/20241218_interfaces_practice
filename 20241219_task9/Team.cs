using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Team
    {
        public Worker[] Workers { get; set; } = new Worker[11];
        public TeamLeader TeamLeader { get; set; }

        public Team()
        {
            TeamLeader = new TeamLeader("Bob");
            Workers = new Worker[11]
            {
                new Worker("Adam"),
                new Worker("Erik"),
                new Worker("Kevin"),
                new Worker("Alex"),
                new Worker("Tyler"),
                new Worker("Chris"),
                new Worker("David"),
                new Worker("Frank"),
                new Worker("Barry"),
                new Worker("Bill"),
                new Worker("Peter")
            };
        }
    }
}
