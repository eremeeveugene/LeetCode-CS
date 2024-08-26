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

namespace LeetCode.Algorithms.RansomNote;

/// <inheritdoc />
public class RansomNoteCounting : IRansomNote
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="ransomNote"></param>
    /// <param name="magazine"></param>
    /// <returns></returns>
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineChars = new int['z' - 'a'];

        foreach (var magazineChar in magazine)
        {
            magazineChars[magazineChar - 'a']++;
        }

        foreach (var magazineChar in ransomNote.Select(ransomNoteChar => ransomNoteChar - 'a'))
        {
            if (magazineChars[magazineChar] > 0)
            {
                magazineChars[magazineChar]--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}