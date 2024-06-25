namespace LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

/// <inheritdoc />
public class MaximumProductOfTwoElementsInAnArraySecondMax : IMaximumProductOfTwoElementsInAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxProduct(int[] nums)
    {
        var firstMax = 0;
        var secondMax = 0;

        foreach (var num in nums)
        {
            if (num > firstMax)
            {
                secondMax = firstMax;
                firstMax = num;
            }
            else
            {
                secondMax = Math.Max(secondMax, num);
            }
        }

        return (firstMax - 1) * (secondMax - 1);
    }
}