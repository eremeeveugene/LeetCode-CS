namespace LeetCode.Algorithms.SortColors;

/// <inheritdoc />
public class SortColorsThreePointers : ISortColors
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    public void SortColors(int[] nums)
    {
        var low = 0;
        var mid = 0;
        var high = nums.Length - 1;

        while (mid <= high)
        {
            switch (nums[mid])
            {
                case 0:
                    (nums[low], nums[mid]) = (nums[mid], nums[low]);

                    low++;
                    mid++;

                    break;
                case 1:
                    mid++;

                    break;
                case 2:
                    (nums[high], nums[mid]) = (nums[mid], nums[high]);

                    high--;

                    break;
            }
        }
    }
}