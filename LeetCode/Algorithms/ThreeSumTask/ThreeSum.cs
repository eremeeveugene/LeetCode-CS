using LeetCode.Core;

namespace LeetCode.Algorithms.ThreeSumTask;

/// <summary>
///     Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k,
///     and j != k, and nums[i] + nums[j] + nums[k] == 0.
///     Notice that the solution set must not contain duplicate triplets.
///     Example 1:
///     Input: nums = [-1,0,1,2,-1,-4]
///     Output: [[-1,-1,2],[-1,0,1]]
///     Explanation:
///     nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
///     nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
///     nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
///     The distinct triplets are [-1,0,1] and [-1,-1,2].
///     Notice that the order of the output and the order of the triplets does not matter.
///     Example 2:
///     Input: nums = [0,1,1]
///     Output: []
///     Explanation: The only possible triplet does not sum up to 0.
///     Example 3:
///     Input: nums = [0,0,0]
///     Output: [[0,0,0]]
///     Explanation: The only possible triplet sums up to 0.
///     Constraints:
///     3 less than or equal nums.length less than or equal 3000
///     -105 less than or equal nums[i] less than or equal 105
/// </summary>
public static class ThreeSum
{
    /// <summary>
    ///     Time complexity - O (n^3)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static IList<IList<int>> GetResult(int[] nums)
    {
        var arraysWithDuplicates = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
            for (var j = i + 1; j < nums.Length - 1; j++)
                for (var k = j + 1; k < nums.Length; k++)
                    if (nums[i] + nums[j] + nums[k] == 0)
                        arraysWithDuplicates.Add(new[] { nums[i], nums[j], nums[k] });

        var uniqueArrays = new HashSet<int[]>(new OrderInsensitiveIntArrayEqualityComparer());

        foreach (var array in arraysWithDuplicates) uniqueArrays.Add(array.ToArray());

        return uniqueArrays.Cast<IList<int>>().ToList();
    }

    /// <summary>
    ///     Time complexity - O (n^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static IList<IList<int>> GetResultTwoPointers(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                switch (sum)
                {
                    case 0:
                        {
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });

                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;

                            left++;
                            right--;

                            break;
                        }
                    case < 0:
                        left++;
                        break;
                    default:
                        right--;
                        break;
                }
            }
        }

        return result;
    }
}