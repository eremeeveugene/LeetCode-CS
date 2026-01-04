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

namespace LeetCode.Algorithms.MaximumSubstringsWithDistinctStart;

/// <inheritdoc />
public abstract class MaximumSubstringsWithDistinctStartBase : IMaximumSubstringsWithDistinctStart
{
    protected const int AlphabetLength = 'z' - 'a' + 1;

    public abstract int MaxDistinct(string s);

    protected int GetIndex(char c)
    {
        return c - 'a';
    }
}