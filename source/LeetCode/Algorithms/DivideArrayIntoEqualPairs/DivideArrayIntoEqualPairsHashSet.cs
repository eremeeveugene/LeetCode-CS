// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DivideArrayIntoEqualPairs;

/// <inheritdoc />
public class DivideArrayIntoEqualPairsHashSet : IDivideArrayIntoEqualPairs
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool DivideArray(int[] nums)
    {
        var countHashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!countHashSet.Add(num))
            {
                countHashSet.Remove(num);
            }
        }

        return countHashSet.Count == 0;
    }
}