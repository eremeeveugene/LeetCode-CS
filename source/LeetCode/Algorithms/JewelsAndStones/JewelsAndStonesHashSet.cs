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

namespace LeetCode.Algorithms.JewelsAndStones;

/// <inheritdoc />
public sealed class JewelsAndStonesHashSet : IJewelsAndStones
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m), where m is the length of the jewels string and n is the length of the stones string
    ///     Space complexity - O(m), where m is the length of the jewels string
    /// </remarks>
    public int NumJewelsInStones(string jewels, string stones)
    {
        var jewelsSet = new HashSet<char>(jewels);

        var count = 0;

        for (var i = 0; i < stones.Length; i++)
        {
            var stone = stones[i];

            if (jewelsSet.Contains(stone))
            {
                count++;
            }
        }

        return count;
    }
}