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

namespace LeetCode.Algorithms.StringToInteger;

/// <inheritdoc />
public sealed class StringToIntegerIterative : IStringToInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MyAtoi(string s)
    {
        var i = 0;

        while (i < s.Length && s[i] == ' ')
        {
            i++;
        }

        var sign = 1;

        if (i < s.Length && (s[i] == '+' || s[i] == '-'))
        {
            if (s[i] == '-')
            {
                sign = -1;
            }

            i++;
        }

        long result = 0;

        while (i < s.Length && char.IsDigit(s[i]))
        {
            result = (result * 10) + (s[i] - '0');

            switch (sign)
            {
                case 1 when result > int.MaxValue:
                    return int.MaxValue;
                case -1 when -result < int.MinValue:
                    return int.MinValue;
                default:
                    i++;
                    break;
            }
        }

        return (int)(sign * result);
    }
}