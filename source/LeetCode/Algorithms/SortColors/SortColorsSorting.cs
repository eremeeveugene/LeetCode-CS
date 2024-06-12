namespace LeetCode.Algorithms.SortColors;

/// <inheritdoc />
public class SortColorsSorting : ISortColors
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    public void SortColors(int[] nums)
    {
        Array.Sort(nums);
    }
}