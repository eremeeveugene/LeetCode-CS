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

namespace LeetCode.Algorithms.RansomNote;

/// <inheritdoc />
public sealed class RansomNoteDictionary : IRansomNote
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var m = magazine.Length;

        var magazineDictionary = new Dictionary<char, int>();

        for (var i = 0; i < m; i++)
        {
            var magazineChar = magazine[i];

            if (!magazineDictionary.TryAdd(magazineChar, 1))
            {
                magazineDictionary[magazineChar]++;
            }
        }

        var n = ransomNote.Length;

        for (var i = 0; i < n; i++)
        {
            var ransomNoteChar = ransomNote[i];

            if (magazineDictionary.TryGetValue(ransomNoteChar, out var magazineCharValue))
            {
                if (magazineCharValue > 0)
                {
                    magazineDictionary[ransomNoteChar]--;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}