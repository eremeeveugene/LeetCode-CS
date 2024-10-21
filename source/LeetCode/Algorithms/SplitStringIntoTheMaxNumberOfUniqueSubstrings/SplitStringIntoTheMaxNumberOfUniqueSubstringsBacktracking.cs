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

namespace LeetCode.Algorithms.SplitStringIntoTheMaxNumberOfUniqueSubstrings;

/// <inheritdoc />
public class SplitStringIntoTheMaxNumberOfUniqueSubstringsBacktracking : ISplitStringIntoTheMaxNumberOfUniqueSubstrings
{
    /// <summary>
    ///     Time complexity - O(n * 2^n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MaxUniqueSplit(string s)
    {
        return MaxUniqueSplit(s, [], 0);
    }

    private static int MaxUniqueSplit(string s, HashSet<string> hashSet, int start)
    {
        if (start == s.Length)
        {
            return 0;
        }

        var maxCount = 0;

        for (var end = start + 1; end <= s.Length; end++)
        {
            var subString = s.Substring(start, end - start);

            if (!hashSet.Add(subString))
            {
                continue;
            }

            var count = 1 + MaxUniqueSplit(s, hashSet, end);

            maxCount = Math.Max(maxCount, count);

            hashSet.Remove(subString);
        }

        return maxCount;
    }
}