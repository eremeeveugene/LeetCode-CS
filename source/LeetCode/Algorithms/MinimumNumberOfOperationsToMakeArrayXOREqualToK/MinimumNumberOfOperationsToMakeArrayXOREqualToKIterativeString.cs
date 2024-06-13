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

namespace LeetCode.Algorithms.MinimumNumberOfOperationsToMakeArrayXOREqualToK;

/// <inheritdoc />
public class MinimumNumberOfOperationsToMakeArrayXOREqualToKIterativeString :
    IMinimumNumberOfOperationsToMakeArrayXOREqualToK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinOperations(int[] nums, int k)
    {
        var xor = nums.Aggregate(0, (current, num) => current ^ num);

        if (xor == k)
        {
            return 0;
        }

        var minOperations = 0;

        var xorString = Convert.ToString(xor, 2);
        var kString = Convert.ToString(k, 2);

        var i = 0;

        while (i < xorString.Length || i < kString.Length)
        {
            var xorChar = '0';
            var kChar = '0';

            if (i < xorString.Length)
            {
                xorChar = xorString[xorString.Length - 1 - i];
            }

            if (i < kString.Length)
            {
                kChar = kString[kString.Length - 1 - i];
            }

            if (xorChar != kChar)
            {
                minOperations++;
            }

            i++;
        }

        return minOperations;
    }
}