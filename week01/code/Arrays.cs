using System.Globalization;
using System.Numerics;

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

        //We assume length is greater than 0
        // possibly a while loop to say while count is not equal to length we add a value to the number each time.
        //Or we can do a for loop and say for each count add a value and multiply that together with the number so it adds on.
        //Append the new number to the array at the end with Add.
        //Create a list to be used for storing the numbers.
        //Need to initialize a variable to keep track of the current count of the loop.
        //Create an if statement that will compute the calculation if count is not 0;
        //Perform the calculation based on the number and multiply it by the current count.
        //Add to the list each time the for loop until length is met.
        //Convert the list to an array and return the new array at the end.
        //Create an array to store the new variables that will be multiples of whatever the number is.
        //We assume length is greater than 0
        // possibly a while loop to say while count is not equal to length we add a value to the number each time.
        //Or we can do a for loop and say for each count add a value and multiply that together with the number so it adds on.
        //Append the new number to the array at the end with Add.
        //
        List<double> multiples = new List<double>();
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            count++;
            if (count != 0)
            {
                double total = number * count;
                multiples.Add(total);

            }

        }
        double[] totals = multiples.ToArray();





        return totals; // replace this return statement with your own
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
        //The loop can only run for the specified amount given in the method and will allow for usability it will also not return any values.
        //For the amount given we create a for loop and delete the value at the last size of the list 
        //Need to give a value to the final value that can be changed each time the for loop runs to stay with the count.
        // we can get this by using count to figure out how large the list is and after we can remove the items from the list
        //after we remove we will insert at 0 in the list.
        //This should make the list dynamically adapt to any size list and follow the amount as how many times we will do thi
        for (int i = 0; i < amount; i++)
        {
            int last = data[data.Count - 1];

            data.RemoveAt(data.Count - 1);

            data.Insert(0, last);

        }

    }
}

