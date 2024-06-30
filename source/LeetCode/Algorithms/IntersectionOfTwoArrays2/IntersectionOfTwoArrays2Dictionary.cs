namespace LeetCode.Algorithms.IntersectionOfTwoArrays2;

/// <inheritdoc />
public class IntersectionOfTwoArrays2Dictionary : IIntersectionOfTwoArrays2
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var nums1Dictionary = new Dictionary<int, int>();

        foreach (var num1 in nums1)
        {
            if (!nums1Dictionary.TryAdd(num1, 1))
            {
                nums1Dictionary[num1]++;
            }
        }

        var result = new List<int>();

        foreach (var num2 in nums2)
        {
            if (!nums1Dictionary.ContainsKey(num2))
            {
                continue;
            }

            result.Add(num2);

            nums1Dictionary[num2]--;

            if (nums1Dictionary[num2] == 0)
            {
                nums1Dictionary.Remove(num2);
            }
        }

        return [.. result];
    }
}