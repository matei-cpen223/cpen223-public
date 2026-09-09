//CPEN223 Lab1 
//Student name:
//Student number:

using System.Text; //This is only needed for the helper method 
//Do not include any other 'using' statement

Console.WriteLine("CPEN223 Lab 1");

//Testing: you may change/add any portion of this testing portion of the code
//         It is given as a starting point for your testing
//         Do consider more test cases to fully test your code

//Test case 1 - part 1
int[] testCase1 = { 2, 3, 42, 12, 7 };
int target = 0;
bool check = Lab1.CheckSum(testCase1, target);
Console.Write("One can");
if (!check) Console.Write("not");
Console.WriteLine($" select three elements from {Lab1.ToString(testCase1)} that sum to {target}.");
//end Testing code

public class Lab1  //do not change this line
{
    // Do not change method headers. 
    // Only add code where it is requested.

    /// <summary>
    /// ToDo: implement this method
    /// Method to check if there are any 3 elements in array resulting sum of target.
    /// Duplicate indices are not allowed.
    /// </summary>
    public static bool CheckSum(int[] array, int target)
    {
        //To implement
        return false; //To fix
    }

    // This is a helper method allowing us to print arrays for our testing.
    // Use as is.
    public static string ToString(int[] array)
    {
        if (array == null)
        {
            return "";
        }

        StringBuilder output = new StringBuilder();
        output.Append("{ ");
        foreach (int x in array)
        {
            output.Append(x);
            output.Append(" ");
        }
        output.Append("}");
        return output.ToString();
    }
}
