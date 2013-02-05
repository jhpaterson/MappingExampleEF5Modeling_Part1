

namespace MappingExample
{
    public class SalariedEmployee : Employee
    {
        private const int MAXGRADE = 10;
        
        public int PayGrade { get; set; }

        public int PayIncrement()
        {
            if (this.PayGrade < MAXGRADE)
            {
                this.PayGrade++;
            }
            return this.PayGrade;
        }
    }
}
