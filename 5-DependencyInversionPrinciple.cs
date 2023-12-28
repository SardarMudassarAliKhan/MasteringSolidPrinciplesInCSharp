using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringSolidPrinciplesInC_
{
    public class _5_DependencyInversionPrinciple
    {
        public interface ISwitchable
        {
            void Toggle();
        }

        public class LightSwitch
        {
            private readonly ISwitchable _device;

            public LightSwitch(ISwitchable device)
            {
                _device = device;
            }

            public void Toggle()
            {
                _device.Toggle();
            }
        }

        public class Bulb : ISwitchable
        {
            public void Toggle()
            {
                // Toggle the bulb
            }
        }
    }
}
