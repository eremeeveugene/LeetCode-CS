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

namespace LeetCode.Algorithms.CheckIfDigitsAreEqualInStringAfterOperations1;

/// <inheritdoc />
public class CheckIfDigitsAreEqualInStringAfterOperations1SimulationOptimized :
    ICheckIfDigitsAreEqualInStringAfterOperations1
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool HasSameDigits(string s)
    {
        var n = s.Length;

        Span<int> nums = stackalloc int[n];

        for (var i = 0; i < n; i++)
        {
            nums[i] = s[i] - '0';
        }

        while (n > 2)
        {
            for (var i = 0; i < n - 1; i++)
            {
                nums[i] = (nums[i] + nums[i + 1]) % 10;
            }

            n--;
        }

        return nums[0] == nums[1];
    }
}