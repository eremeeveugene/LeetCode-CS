namespace LeetCode.Algorithms.MinimumIncrementToMakeArrayUnique;

/// <inheritdoc />
public class MinimumIncrementToMakeArrayUniqueSorting : IMinimumIncrementToMakeArrayUnique
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinIncrementForUnique(int[] nums)
    {
        var result = 0;

        Array.Sort(nums);

        var current = -1;

        foreach (var num in nums)
        {
            if (num > current)
            {
                current = num;
            }
            else
            {
                current += 1;

                result += current - num;
            }
        }

        return result;
    }
}