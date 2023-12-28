namespace MasteringSolidPrinciplesInC_
{
    /// <summary>
    /// Software entities should be open for extension but closed for modification.
    /// </summary>
    public class OpenClosePrinciple
    {
        public abstract class Shape
        {
            public abstract double Area();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Square : Shape
        {
            public double Side { get; set; }

            public override double Area()
            {
                return Side * Side;
            }
        }
    }
}
