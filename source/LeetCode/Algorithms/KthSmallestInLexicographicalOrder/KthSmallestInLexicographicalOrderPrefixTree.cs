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

namespace LeetCode.Algorithms.KthSmallestInLexicographicalOrder;

/// <inheritdoc />
public class KthSmallestInLexicographicalOrderPrefixTree : IKthSmallestInLexicographicalOrder
{
    /// <summary>
    ///     Time complexity - O(k * log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int FindKthNumber(int n, int k)
    {
        var result = 1;

        k--;

        while (k > 0)
        {
            var nodesCount = GetNodesCount(result, n);

            if (nodesCount <= k)
            {
                k -= nodesCount;
                result++;
            }
            else
            {
                result *= 10;
                k--;
            }
        }

        return result;
    }

    private static int GetNodesCount(int prefix, int n)
    {
        var count = 0;
        long current = prefix;
        long next = prefix + 1;

        while (current <= n)
        {
            count += (int)(Math.Min(n + 1, next) - current);
            current *= 10;
            next *= 10;
        }

        return count;
    }
}