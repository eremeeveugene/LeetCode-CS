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

namespace LeetCode.Algorithms.NumberOfSubstringsContainingAllThreeCharacters;

/// <inheritdoc />
public class NumberOfSubstringsContainingAllThreeCharactersSlidingWindow :
    INumberOfSubstringsContainingAllThreeCharacters
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int NumberOfSubstrings(string s)
    {
        var numberOfSubstrings = 0;

        var left = 0;

        var frequency = new int[3];

        for (var right = 0; right < s.Length; right++)
        {
            frequency[s[right] - 'a']++;

            while (frequency[0] > 0 && frequency[1] > 0 && frequency[2] > 0)
            {
                numberOfSubstrings += s.Length - right;

                frequency[s[left] - 'a']--;

                left++;
            }
        }

        return numberOfSubstrings;
    }
}