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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.FindModeInBinarySearchTree;

/// <inheritdoc />
public abstract class FindModeInBinarySearchTreeBase : IFindModeInBinarySearchTree
{
    /// <inheritdoc />
    public abstract int[] FindMode(TreeNode? root);

    /// <summary>
    ///     Increments the occurrence count of <paramref name="val" />.
    /// </summary>
    /// <param name="valToCountDictionary">The occurrence counts of the values seen so far.</param>
    /// <param name="val">The value to count.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static void IncrementCount(Dictionary<int, int> valToCountDictionary, int val)
    {
        if (!valToCountDictionary.TryAdd(val, 1))
        {
            valToCountDictionary[val]++;
        }
    }

    /// <summary>
    ///     Collects the values with the highest occurrence count.
    /// </summary>
    /// <param name="valToCountDictionary">The occurrence counts of all values in the tree.</param>
    /// <returns>The values that occur most often.</returns>
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of distinct values
    ///     Space complexity - O(n), where n is the number of distinct values
    /// </remarks>
    protected static int[] GetModes(Dictionary<int, int> valToCountDictionary)
    {
        var vals = new int[valToCountDictionary.Count];

        valToCountDictionary.Keys.CopyTo(vals, 0);

        var n = vals.Length;

        var maxCount = 0;

        for (var i = 0; i < n; i++)
        {
            var val = vals[i];

            maxCount = Math.Max(maxCount, valToCountDictionary[val]);
        }

        var modes = new List<int>();

        for (var i = 0; i < n; i++)
        {
            var val = vals[i];

            if (valToCountDictionary[val] == maxCount)
            {
                modes.Add(val);
            }
        }

        return modes.ToArray();
    }
}