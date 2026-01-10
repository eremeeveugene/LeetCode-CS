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

namespace LeetCode.Algorithms.TakeKOfEachCharacterFromLeftAndRight;

/// <inheritdoc />
public sealed class TakeKOfEachCharacterFromLeftAndRightSlidingWindow : ITakeKOfEachCharacterFromLeftAndRight
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int TakeCharacters(string s, int k)
    {
        var count = new int[3];

        foreach (var c in s)
        {
            count[c - 'a']++;
        }

        if (count.Any(c => c < k))
        {
            return -1;
        }

        var window = new int[3];
        var left = 0;
        var maxWindow = 0;

        for (var right = 0; right < s.Length; right++)
        {
            window[s[right] - 'a']++;

            while (left <= right && (count[0] - window[0] < k || count[1] - window[1] < k || count[2] - window[2] < k))
            {
                window[s[left] - 'a']--;

                left++;
            }

            maxWindow = Math.Max(maxWindow, right - left + 1);
        }

        return s.Length - maxWindow;
    }
}