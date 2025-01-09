public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /// ----- PLAN -----
        /// ** ( the inputs are number and length ) **
        ///  1. Need to create an array to hold the size of 'length'. According to the tests, we need to be able to store positive and negative whole numbers as well as decimal values. Even though float could also accommodate these, the function specifically wants double. 
        ///  2. Use a for loop to iterate through the 'length' array with multiples of 'number'. We want each iteration to multiply 'number' times (i times 'number'), and we want i to stop after each iteration of 'length'.
        ///  3. Return the new array

        // Step 1. 
        double[] multiples = new double[length];

        // Step 2. 
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3.
        return multiples;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>


    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /// ----- PLAN -----
        /// ** inputs data and amount **
        ///  1. Wrap around index number back to 0 by using modulo
        ///  2. We'll want to divide or split the original list into 2 parts- the end (to move up in the index) and the beginning (the original numbers from the beginning index of the list). Use .GetRange to get a small copy of a range of elements.
        ///  3. To be on the safe side, clear everything in list before adding new list with the rotated data. When list is cleared, add the end numbers first, then add the beginning numbers to the end of new list.

        // Step 1.
        amount %= data.Count;

        // Step 2.
        List<int> end = data.GetRange(data.Count - amount, amount);
        List<int> beginning = data.GetRange(0, data.Count - amount);

        // Step 3. 
        data.Clear();
        data.AddRange(end);
        data.AddRange(beginning);
    }
}
