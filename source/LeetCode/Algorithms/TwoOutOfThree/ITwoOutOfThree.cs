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

/// <summary>
///     https://leetcode.com/problems/two-out-of-three/description/
/// </summary>
public interface ITwoOutOfThree
{
    /// <summary>
    ///     Finds every value that appears in at least two of the arrays <paramref name="nums1" />,
    ///     <paramref name="nums2" />, and <paramref name="nums3" />.
    /// </summary>
    /// <param name="nums1">The first array of distinct integers.</param>
    /// <param name="nums2">The second array of distinct integers.</param>
    /// <param name="nums3">The third array of distinct integers.</param>
    /// <returns>A list of the distinct values present in at least two of the three arrays.</returns>
    IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3);
}