// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTheDifferenceOfTwoArrays;

/// <inheritdoc />
public class FindTheDifferenceOfTwoArraysHashSet : IFindTheDifferenceOfTwoArrays
{
    /// <summary>
    ///     Time complexity - O(m+n)
    ///     Space complexity - O(m+n)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var result1 = set1.Where(num => !set2.Contains(num)).ToList();
        var result2 = set2.Where(num => !set1.Contains(num)).ToList();

        return new List<IList<int>> { result1, result2 };
    }
}