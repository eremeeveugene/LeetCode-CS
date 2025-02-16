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

namespace LeetCode.Algorithms.MinimumNumberOfOperationsToMakeElementsInArrayDistinct;

/// <inheritdoc />
public class MinimumNumberOfOperationsToMakeElementsInArrayDistinctIterative :
    IMinimumNumberOfOperationsToMakeElementsInArrayDistinct
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinimumOperations(int[] nums)
    {
        var frequencyArray = new int[101];

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            frequencyArray[nums[i]]++;

            if (frequencyArray[nums[i]] > 1)
            {
                return (i + 3) / 3;
            }
        }

        return 0;
    }
}