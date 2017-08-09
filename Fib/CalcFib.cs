namespace Fib
{
    class CalcFib
    {
        public int CalculateFibonacci(int n)
        {
            // Set initial values
            int returnValue = 0;
            int nextFib = 1;

            // loop through each step to calculate increase
            for (int i = 0; i < n; i++)
            {
                int prevTotal = returnValue; // Store the previous steps total for next itteration 
                returnValue = nextFib; // Set return value for this itteration
                nextFib = prevTotal + nextFib; // Calculate the next step
            }
            return returnValue;
        }

    }
}
