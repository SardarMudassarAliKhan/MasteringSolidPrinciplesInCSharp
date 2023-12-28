using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringSolidPrinciplesInC_
{
    /// <summary>
    /// Clients should not be forced to depend on interfaces they do not use.
    /// </summary>
    public class WithOutInterfaceSegregationPrinciple
    {
        // Without ISP
        public interface IWorker
        {
            void Work();
            void TakeBreak();
            void ClockOut();
        }

        // For a Robot, some methods are irrelevant.
        public class Robot : IWorker
        {
            public void Work()
            {
                // Perform work
            }

            public void TakeBreak()
            {
                // Not applicable
            }

            public void ClockOut()
            {
                // Not applicable
            }
        }
    }
}
