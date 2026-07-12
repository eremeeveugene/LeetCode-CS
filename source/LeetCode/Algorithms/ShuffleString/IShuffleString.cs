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

namespace LeetCode.Algorithms.ShuffleString;

/// <summary>
///     https://leetcode.com/problems/shuffle-string/description/
/// </summary>
public interface IShuffleString
{
    /// <summary>
    ///     Restores the shuffled string <paramref name="s" /> by placing each character at the position
    ///     specified by the corresponding entry in <paramref name="indices" />.
    /// </summary>
    /// <param name="s">The shuffled string to restore.</param>
    /// <param name="indices">The array specifying the target position of each character in <paramref name="s" />.</param>
    /// <returns>The restored, unshuffled string.</returns>
    string RestoreString(string s, int[] indices);
}