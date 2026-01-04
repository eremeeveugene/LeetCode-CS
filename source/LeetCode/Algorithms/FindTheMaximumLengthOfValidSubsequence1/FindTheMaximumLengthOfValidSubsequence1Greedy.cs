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

namespace LeetCode.Algorithms.FindTheMaximumLengthOfValidSubsequence1;

/// <inheritdoc />
public class FindTheMaximumLengthOfValidSubsequence1Greedy : IFindTheMaximumLengthOfValidSubsequence1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaximumLength(int[] nums)
    {
        var evenCount = 0;
        var oddCount = 0;
        var alternateCount = 0;
        var parity = -1;

        foreach (var num in nums)
        {
            if (num % 2 == 0)
            {
                evenCount++;

                if (parity is 1 or -1)
                {
                    alternateCount++;
                }
            }
            else
            {
                oddCount++;

                if (parity is 0 or -1)
                {
                    alternateCount++;
                }
            }

            parity = num % 2;
        }

        return Math.Max(alternateCount, Math.Max(evenCount, oddCount));
    }
}