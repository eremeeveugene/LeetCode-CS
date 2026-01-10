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

namespace LeetCode.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

/// <inheritdoc />
public sealed class LexicographicallyMinimumStringAfterRemovingStarsPriorityQueue :
    LexicographicallyMinimumStringAfterRemovingStarsBase
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public override string ClearStars(string s)
    {
        var charsPriorityQueue = new PriorityQueue<(char Char, int Index), (char Char, int Index)>();

        var chars = s.ToCharArray();

        for (var i = 0; i < chars.Length; i++)
        {
            var c = chars[i];

            if (c == '*')
            {
                var charToRemove = charsPriorityQueue.Dequeue();

                chars[charToRemove.Index] = '*';
            }
            else
            {
                charsPriorityQueue.Enqueue((c, i), (c, -i));
            }
        }

        return BuildResult(chars);
    }
}