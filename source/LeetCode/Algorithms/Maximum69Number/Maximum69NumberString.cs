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

namespace LeetCode.Algorithms.Maximum69Number;

/// <inheritdoc />
public sealed class Maximum69NumberString : IMaximum69Number
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int Maximum69Number(int num)
    {
        var numStr = num.ToString();

        var index = numStr.IndexOf('6');

        if (index != -1)
        {
            numStr = numStr[..index] + '9' + numStr[(index + 1)..];
        }

        return int.Parse(numStr);
    }
}