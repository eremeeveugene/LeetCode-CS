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

namespace LeetCode.Algorithms.ShuffleString;

/// <inheritdoc />
public class ShuffleStringIterative : IShuffleString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="indices"></param>
    /// <returns></returns>
    public string RestoreString(string s, int[] indices)
    {
        var sIndex = 0;

        var chars = new char[indices.Length];

        foreach (var index in indices)
        {
            chars[index] = s[sIndex];

            sIndex++;
        }

        return new string(chars);
    }
}