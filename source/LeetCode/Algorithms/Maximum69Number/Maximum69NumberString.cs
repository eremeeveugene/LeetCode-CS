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

namespace LeetCode.Algorithms.Maximum69Number;

/// <inheritdoc />
public class Maximum69NumberString : IMaximum69Number
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
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