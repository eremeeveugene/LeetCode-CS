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
public sealed class RansomNoteCounting : IRansomNote
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineChars = new int['z' - 'a' + 1];

        for (var i = 0; i < magazine.Length; i++)
        {
            var magazineChar = magazine[i] - 'a';

            magazineChars[magazineChar]++;
        }

        for (var i = 0; i < ransomNote.Length; i++)
        {
            var ransomNoteChar = ransomNote[i] - 'a';

            if (magazineChars[ransomNoteChar] > 0)
            {
                magazineChars[ransomNoteChar]--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}