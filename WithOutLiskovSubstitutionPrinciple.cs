namespace MasteringSolidPrinciplesInC_
{
    /// <summary>
    /// Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.
    /// </summary>
    public class WithOutLiskovSubstitutionPrinciple
    {
        // Without LSP
        public class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public int CalculateArea()
            {
                return Width * Height;
            }
        }

        public class Square : Rectangle
        {
            public override int Width
            {
                get => base.Width;
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }

            public override int Height
            {
                get => base.Height;
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }
        }
    }
}
