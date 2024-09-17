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

namespace LeetCode.Algorithms.StringMatchingInAnArray;

/// <inheritdoc />
public class StringMatchingInAnArrayBruteForce : IStringMatchingInAnArray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public IList<string> StringMatching(string[] words)
    {
        return words.Where((t1, i) => words.Where((t, j) => i != j && t.Contains(t1)).Any()).ToArray();
    }
}