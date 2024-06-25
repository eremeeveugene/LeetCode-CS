namespace LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

/// <inheritdoc />
public class MaximumProductOfTwoElementsInAnArraySecondBiggest : IMaximumProductOfTwoElementsInAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxProduct(int[] nums)
    {
        var biggest = 0;
        var secondBiggest = 0;

        foreach (var num in nums)
        {
            if (num > biggest)
            {
                secondBiggest = biggest;
                biggest = num;
            }
            else
            {
                secondBiggest = Math.Max(secondBiggest, num);
            }
        }

        return (biggest - 1) * (secondBiggest - 1);
    }
}