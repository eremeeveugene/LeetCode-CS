namespace LeetCode.Algorithms.BinarySearch;

/// <inheritdoc />
public class BinarySearchUpperBound : IBinarySearch
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        if (left > 0 && nums[left - 1] == target)
        {
            return left - 1;
        }

        return -1;
    }
}