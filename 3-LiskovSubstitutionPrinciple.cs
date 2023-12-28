namespace MasteringSolidPrinciplesInC_
{
    /// <summary>
    /// Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.
    /// </summary>
    public class LiskovSubstitutionPrinciple
    {
        public abstract class Shape
        {
            public abstract int Area();
        }

        public class Rectangle : Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public override int Area()
            {
                return Width * Height;
            }
        }

        public class Square : Shape
        {
            public int Side { get; set; }

            public override int Area()
            {
                return Side * Side;
            }
        }
    }
}
