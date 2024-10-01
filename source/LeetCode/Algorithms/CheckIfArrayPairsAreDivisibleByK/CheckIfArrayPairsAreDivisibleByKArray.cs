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

namespace LeetCode.Algorithms.CheckIfArrayPairsAreDivisibleByK;

/// <inheritdoc />
public class CheckIfArrayPairsAreDivisibleByKArray : ICheckIfArrayPairsAreDivisibleByK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool CanArrange(int[] arr, int k)
    {
        var remainderCount = new int[k];

        foreach (var item in arr)
        {
            var remainder = ((item % k) + k) % k;

            remainderCount[remainder]++;
        }

        if (remainderCount[0] % 2 != 0)
        {
            return false;
        }

        for (var i = 1; i <= k / 2; i++)
        {
            if (remainderCount[i] != remainderCount[k - i])
            {
                return false;
            }
        }

        return true;
    }
}