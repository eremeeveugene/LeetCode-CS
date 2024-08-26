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
public class RansomNoteDictionary : IRansomNote
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="ransomNote"></param>
    /// <param name="magazine"></param>
    /// <returns></returns>
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineDictionary = new Dictionary<char, int>();

        foreach (var magazineChar in magazine.Where(magazineChar => !magazineDictionary.TryAdd(magazineChar, 1)))
        {
            magazineDictionary[magazineChar]++;
        }

        foreach (var ransomNoteChar in ransomNote)
        {
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