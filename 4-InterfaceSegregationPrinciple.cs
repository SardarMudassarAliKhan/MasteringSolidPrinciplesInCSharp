namespace MasteringSolidPrinciplesInC_
{
    /// <summary>
    /// Refactored using ISP:
    /// </summary>
    public class InterfaceSegregationPrinciple
    {
        public interface IWorker
        {
            void Work();
        }

        public interface IBreakable
        {
            void TakeBreak();
        }

        public interface IClockable
        {
            void ClockOut();
        }

        public class Robot : IWorker
        {
            public void Work()
            {
                // Perform work
            }
        }
    }
}
