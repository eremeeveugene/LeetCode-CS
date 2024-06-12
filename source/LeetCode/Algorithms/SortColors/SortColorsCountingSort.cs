namespace LeetCode.Algorithms.SortColors;

/// <inheritdoc />
public class SortColorsCountingSort : ISortColors
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    public void SortColors(int[] nums)
    {
        var zeroesCount = 0;
        var onesCount = 0;

        foreach (var num in nums)
        {
            switch (num)
            {
                case 0:
                    zeroesCount++;
                    break;
                case 1:
                    onesCount++;
                    break;
            }
        }

        for (var i = 0; i < zeroesCount; i++)
        {
            nums[i] = 0;
        }

        for (var i = zeroesCount; i < zeroesCount + onesCount; i++)
        {
            nums[i] = 1;
        }

        for (var i = zeroesCount + onesCount; i < nums.Length; i++)
        {
            nums[i] = 2;
        }
    }
}