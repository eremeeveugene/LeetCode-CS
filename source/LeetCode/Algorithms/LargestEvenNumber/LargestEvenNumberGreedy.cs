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

namespace LeetCode.Algorithms.LargestEvenNumber;

/// <inheritdoc />
public sealed class LargestEvenNumberGreedy : ILargestEvenNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public string LargestEven(string s)
    {
        var index = s.Length - 1;

        while (index >= 0)
        {
            var c = s[index];

            if (c == '2')
            {
                break;
            }

            index--;
        }

        return s[..(index + 1)];
    }
}