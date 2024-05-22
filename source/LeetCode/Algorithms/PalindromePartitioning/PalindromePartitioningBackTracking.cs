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

namespace LeetCode.Algorithms.PalindromePartitioning;

/// <inheritdoc />
public class PalindromePartitioningBackTracking : IPalindromePartitioning
{
    /// <summary>
    ///     Time complexity - O(n * 2^n)
    ///     Space complexity - O(n * 2^n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> result = new List<IList<string>>();

        Backtrack(s, 0, new List<string>(), result);

        return result;
    }

    private static void Backtrack(string s, int start, IList<string> currentPartition,
        ICollection<IList<string>> result)
    {
        if (start >= s.Length)
        {
            result.Add(new List<string>(currentPartition));

            return;
        }

        for (var end = start; end < s.Length; end++)
        {
            if (!IsPalindrome(s, start, end))
            {
                continue;
            }

            currentPartition.Add(s.Substring(start, end - start + 1));

            Backtrack(s, end + 1, currentPartition, result);

            currentPartition.RemoveAt(currentPartition.Count - 1);
        }
    }

    private static bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}