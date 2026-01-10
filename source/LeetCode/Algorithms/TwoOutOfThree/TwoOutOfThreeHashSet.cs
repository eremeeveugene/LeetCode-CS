// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.TwoOutOfThree;

/// <inheritdoc />
public sealed class TwoOutOfThreeHashSet : ITwoOutOfThree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <param name="nums3"></param>
    /// <returns></returns>
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var result = new List<int>();
        var seen = new HashSet<int>();

        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        var set3 = new HashSet<int>(nums3);

        foreach (var num in set1)
        {
            if (!set2.Contains(num) && !set3.Contains(num))
            {
                continue;
            }

            if (seen.Add(num))
            {
                result.Add(num);
            }
        }

        foreach (var num in set2)
        {
            if (!set3.Contains(num) || set1.Contains(num))
            {
                continue;
            }

            if (seen.Add(num))
            {
                result.Add(num);
            }
        }

        return result;
    }
}