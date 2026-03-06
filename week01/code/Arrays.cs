using System.Diagnostics;

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

        // First, I need an array to hold the multiples that I am going to return, I'll name it 'multiples'
        // Next, I need to iterate through the variable 'number' for the amount of times that is given in 'length', so I will use a for loop where 'i' is checked against length to know when to stop
        // While iterating through the multiples, the index of 'multiples' will be assigned based on the current value of 'i' and will be calculated by taking the input number and multiplying it by the number of iterations we are on
        // Since 'i' starts at 0, it will be measured as i + 1
        // return multiples

        var multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = (number * (i + 1));
        }

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

        // For a list to be rotated to the right, the last number of the list would be moved to the front.
        // if we use data.Count we can find the length of the list and get the index of the last value as data.Count - 1
        // Then, we store the value and use data.RemoveAt(data.Count - 1) to pluck it from the array
        // Once it's removed, we then re-add it at the beginning using data.Insert(0, value)
        // All of that is then enclosed in a for loop where i is less than the provided amount to continue to rotate the data

        int len = data.Count;
        for (int i = 0; i < amount; i++)
        {
            int val = data[len - 1];
            data.RemoveAt(len - 1);
            data.Insert(0, val);
            Debug.WriteLine(data);
        }
        Debug.WriteLine(data);
    }
}
