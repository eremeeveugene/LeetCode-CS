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

namespace LeetCode.Algorithms.MinimizedMaximumOfProductsDistributedToAnyStore;

/// <inheritdoc />
public class
    MinimizedMaximumOfProductsDistributedToAnyStoreBinarySearch : IMinimizedMaximumOfProductsDistributedToAnyStore
{
    /// <summary>
    ///     Time complexity - O(n * log Q)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="quantities"></param>
    /// <returns></returns>
    public int MinimizedMaximum(int n, int[] quantities)
    {
        var left = 1;
        var right = quantities.Max();

        var answer = right;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            if (CanDistribute(quantities, n, mid))
            {
                answer = mid;

                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return answer;
    }

    private static bool CanDistribute(int[] quantities, int n, int maxPerStore)
    {
        var storesNeeded = quantities.Sum(quantity => (quantity + maxPerStore - 1) / maxPerStore);

        return storesNeeded <= n;
    }
}