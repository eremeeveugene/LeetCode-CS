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

namespace LeetCode.Algorithms.FindTheDifferenceOfTwoArrays;

/// <inheritdoc />
public sealed class FindTheDifferenceOfTwoArraysHashSet : IFindTheDifferenceOfTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(m + n)
    /// </remarks>
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var result1 = GetMissingElements(set1, set2);
        var result2 = GetMissingElements(set2, set1);

        return new List<IList<int>> { result1, result2 };
    }

    private static List<int> GetMissingElements(HashSet<int> source, HashSet<int> other)
    {
        var elements = new int[source.Count];

        source.CopyTo(elements);

        var result = new List<int>();

        for (var i = 0; i < elements.Length; i++)
        {
            var element = elements[i];

            if (!other.Contains(element))
            {
                result.Add(element);
            }
        }

        return result;
    }
}