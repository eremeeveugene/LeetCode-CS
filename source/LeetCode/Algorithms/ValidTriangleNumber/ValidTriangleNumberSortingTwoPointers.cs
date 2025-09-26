namespace LeetCode.Algorithms.ValidTriangleNumber;

/// <inheritdoc />
public class ValidTriangleNumberSortingTwoPointers : IValidTriangleNumber
{
    /// <summary>
    ///     Time complexity -  O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int TriangleNumber(int[] nums)
    {
        var numsLength = nums.Length;

        if (numsLength < 3)
        {
            return 0;
        }

        Array.Sort(nums);

        var count = 0;

        for (var cIndex = numsLength - 1; cIndex > 1; cIndex--)
        {
            var aIndex = 0;
            var bIndex = cIndex - 1;

            while (aIndex < bIndex)
            {
                var a = nums[aIndex];
                var b = nums[bIndex];
                var c = nums[cIndex];

                if (a + b > c)
                {
                    count += bIndex - aIndex;

                    bIndex--;
                }
                else
                {
                    aIndex++;
                }
            }
        }

        return count;
    }
}