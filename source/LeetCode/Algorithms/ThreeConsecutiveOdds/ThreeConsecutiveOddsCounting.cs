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

namespace LeetCode.Algorithms.ThreeConsecutiveOdds;

/// <inheritdoc />
public sealed class ThreeConsecutiveOddsCounting : IThreeConsecutiveOdds
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        var count = 0;

        foreach (var item in arr)
        {
            if (item % 2 == 0)
            {
                count = 0;
            }
            else
            {
                count++;

                if (count == 3)
                {
                    return true;
                }
            }
        }

        return false;
    }
}