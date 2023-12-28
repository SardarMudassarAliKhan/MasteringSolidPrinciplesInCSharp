namespace MasteringSolidPrinciplesInC_
{
    /// <summary>
    /// A class should have only one reason to change.
    /// </summary>

    public class SingleResponsablityPrinciple
    {
        public class SRPEmployee
        {
            public void CalculateSalary()
            {
                // Calculates salary
            }
        }

        public class ReportGenerator
        {
            public void GenerateReport(SRPEmployee employee)
            {
                // Generates employee report
            }
        }
    }
}
