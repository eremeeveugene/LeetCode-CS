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

namespace LeetCode.Algorithms.MissingNumber;

/// <inheritdoc />
public static class MissingNumberSumFormula : IMissingNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int GetResult(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var numsLength = nums.Length;

        return (numsLength * (numsLength + 1) / 2) - nums.Sum();
    }
}