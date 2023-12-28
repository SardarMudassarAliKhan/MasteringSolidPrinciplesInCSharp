namespace MasteringSolidPrinciplesInC_
{
    public class WithOutOCPCircle
    {
        /// <summary>
        /// Without OCP
        /// </summary>
        public class Circle
        {
            public double Radius { get; set; }

            public double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        // Adding a new shape requires modifying existing code.
        public class Square
        {
            public double Side { get; set; }

            public double Area()
            {
                return Side * Side;
            }
        }
    }
}
