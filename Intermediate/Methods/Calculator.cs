namespace Methods
{
    public class Calculator
    {
        // Params modifier   

        public int Add(params int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
