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

namespace LeetCode.Algorithms.FindTargetIndicesAfterSortingArray;

/// <inheritdoc />
public class FindTargetIndicesAfterSortingArrayIterative : IFindTargetIndicesAfterSortingArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public IList<int> TargetIndices(int[] nums, int target)
    {
        var smallerCount = 0;
        var equalCount = 0;

        foreach (var num in nums)
        {
            if (num < target)
            {
                smallerCount++;
            }
            else if (num == target)
            {
                equalCount++;
            }
        }

        var result = new List<int>();

        for (var i = 0; i < equalCount; i++)
        {
            result.Add(smallerCount + i);
        }

        return result;
    }
}