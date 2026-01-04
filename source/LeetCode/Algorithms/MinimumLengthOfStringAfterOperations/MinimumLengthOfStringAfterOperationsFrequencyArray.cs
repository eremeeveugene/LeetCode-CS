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

namespace LeetCode.Algorithms.MinimumLengthOfStringAfterOperations;

/// <inheritdoc />
public class MinimumLengthOfStringAfterOperationsFrequencyArray : IMinimumLengthOfStringAfterOperations
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MinimumLength(string s)
    {
        var result = 0;

        var frequencyArray = new int['z' - 'a' + 1];

        foreach (var c in s)
        {
            if (frequencyArray[c - 'a'] == 2)
            {
                frequencyArray[c - 'a']--;
                result--;
            }
            else
            {
                frequencyArray[c - 'a']++;
                result++;
            }
        }

        return result;
    }
}