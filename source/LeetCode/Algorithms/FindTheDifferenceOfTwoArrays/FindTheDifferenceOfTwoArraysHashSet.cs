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
        return new List<IList<int>> { FindDifferenceArray(nums1, nums2), FindDifferenceArray(nums2, nums1) };
    }

    private static int[] FindDifferenceArray(IEnumerable<int> nums1, IEnumerable<int> nums2)
    {
        var nums1HashSet = new HashSet<int>();
        var nums2HashSet = new HashSet<int>();

        foreach (var num2 in nums2)
        {
            nums2HashSet.Add(num2);
        }

        foreach (var num1 in nums1)
        {
            if (!nums2HashSet.Contains(num1))
            {
                nums1HashSet.Add(num1);
            }
        }

        return [.. nums1HashSet];
    }
}