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

namespace LeetCode.Algorithms.RomanToInteger;

/// <inheritdoc />
public class RomanToIntegerDictionary : IRomanToInteger
{
    private readonly Dictionary<string, int> _romanIntegersDictionary = new()
    {
        { "IV", 4 },
        { "IX", 9 },
        { "XL", 40 },
        { "XC", 90 },
        { "CD", 400 },
        { "CM", 900 },
        { "I", 1 },
        { "V", 5 },
        { "X", 10 },
        { "L", 50 },
        { "C", 100 },
        { "D", 500 },
        { "M", 1000 }
    };

    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="romanString"></param>
    /// <returns></returns>
    public int RomanToInt(string romanString)
    {
        var result = 0;
        var i = 0;

        while (i < romanString.Length)
        {
            if (i < romanString.Length - 1 &&
                _romanIntegersDictionary.TryGetValue(romanString.Substring(i, 2), out var value))
            {
                result += value;
                i += 2;
            }
            else
            {
                if (_romanIntegersDictionary.TryGetValue(romanString.Substring(i, 1), out var value1))
                {
                    result += value1;
                }

                i++;
            }
        }

        return result;
    }
}