namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedArray2;

/// <inheritdoc />
public class RemoveDuplicatesFromSortedArray2Dictionary : IRemoveDuplicatesFromSortedArray2
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicates(int[] nums)
    {
        var numsDictionary = new Dictionary<int, int>();

        var left = 0;
        var right = nums.Length;

        while (left < right)
        {
            if (numsDictionary.TryAdd(nums[left], 1))
            {
                left++;

                continue;
            }

            if (numsDictionary[nums[left]] < 2)
            {
                numsDictionary[nums[left]]++;

                left++;
            }
            else
            {
                for (var j = left; j < right - 1; j++)
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }

                right--;
            }
        }

        return right;
    }
}