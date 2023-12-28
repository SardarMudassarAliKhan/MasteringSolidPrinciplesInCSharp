using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringSolidPrinciplesInC_
{
    /// <summary>
    /// High-level modules should not depend on low-level modules. Both should depend on abstractions.
    /// </summary>
    public class WithOutDependencyInversionPrinciple
    {
        // Without DIP
        public class LightSwitch
        {
            private readonly Bulb _bulb;

            public LightSwitch()
            {
                _bulb = new Bulb();
            }

            public void Toggle()
            {
                _bulb.Toggle();
            }
        }

        public class Bulb
        {
            public void Toggle()
            {
                // Toggle the bulb
            }
        }
    }
}
