namespace LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

/// <inheritdoc />
public class MaximumProductOfTwoElementsInAnArrayBruteForce : IMaximumProductOfTwoElementsInAnArray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxProduct(int[] nums)
    {
        var maxProduct = 0;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                maxProduct = Math.Max(maxProduct, (nums[i] - 1) * (nums[j] - 1));
            }
        }

        return maxProduct;
    }
}