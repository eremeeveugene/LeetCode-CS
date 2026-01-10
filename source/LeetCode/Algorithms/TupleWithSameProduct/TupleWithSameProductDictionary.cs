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

namespace LeetCode.Algorithms.TupleWithSameProduct;

/// <inheritdoc />
public sealed class TupleWithSameProductDictionary : ITupleWithSameProduct
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int TupleSameProduct(int[] nums)
    {
        var count = 0;

        var frequencyDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                var product = nums[i] * nums[j];

                if (frequencyDictionary.TryAdd(product, 1))
                {
                    continue;
                }

                count += frequencyDictionary[product] * 8;

                frequencyDictionary[product]++;
            }
        }

        return count;
    }
}