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

namespace LeetCode.Algorithms.JewelsAndStones;

/// <inheritdoc />
public class JewelsAndStonesHashSet : IJewelsAndStones
{
    /// <summary>
    ///     Time complexity - O(n+m)
    /// </summary>
    /// <param name="jewels"></param>
    /// <param name="stones"></param>
    /// <returns></returns>
    public int NumJewelsInStones(string jewels, string stones)
    {
        var jewelsSet = new HashSet<char>(jewels);

        return stones.Count(jewelsSet.Contains);
    }
}