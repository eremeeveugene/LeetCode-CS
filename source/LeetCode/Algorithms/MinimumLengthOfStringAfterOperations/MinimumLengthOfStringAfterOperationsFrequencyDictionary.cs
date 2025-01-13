// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MinimumLengthOfStringAfterOperationsFrequencyDictionary : IMinimumLengthOfStringAfterOperations
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MinimumLength(string s)
    {
        var result = 0;

        var frequencyDictionary = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (frequencyDictionary.TryAdd(c, 1))
            {
                result++;
            }
            else
            {
                if (frequencyDictionary[c] == 2)
                {
                    frequencyDictionary[c]--;
                    result--;
                }
                else
                {
                    frequencyDictionary[c]++;
                    result++;
                }
            }
        }

        return result;
    }
}