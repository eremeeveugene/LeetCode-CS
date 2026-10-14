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
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var result = new List<int>();
        var seen = new HashSet<int>();

        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        var set3 = new HashSet<int>(nums3);

        var uniqueNums1 = new int[set1.Count];

        set1.CopyTo(uniqueNums1);

        for (var i = 0; i < uniqueNums1.Length; i++)
        {
            var num = uniqueNums1[i];

            if (!set2.Contains(num) && !set3.Contains(num))
            {
                continue;
            }

            if (seen.Add(num))
            {
                result.Add(num);
            }
        }

        var uniqueNums2 = new int[set2.Count];

        set2.CopyTo(uniqueNums2);

        for (var i = 0; i < uniqueNums2.Length; i++)
        {
            var num = uniqueNums2[i];

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