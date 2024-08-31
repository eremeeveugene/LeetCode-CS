namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedArray2;

/// <inheritdoc />
public class RemoveDuplicatesFromSortedArray2TwoPointers : IRemoveDuplicatesFromSortedArray2
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        var left = 2;

        for (var right = 2; right < nums.Length; right++)
        {
            if (nums[right] == nums[left - 2])
            {
                continue;
            }

            nums[left] = nums[right];

            left++;
        }

        return left;
    }
}