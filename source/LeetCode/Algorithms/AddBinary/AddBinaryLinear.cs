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

namespace LeetCode.Algorithms.AddBinary;

/// <summary>
///     https://leetcode.com/problems/add-binary/description/
/// </summary>
public static class AddBinaryLinear
{
    /// <summary>
    ///     Time complexity - O(max(n1, n2))
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static string GetResult(string a, string b)
    {
        var len1 = a.Length;
        var len2 = b.Length;

        var result = new char[Math.Max(len1, len2) + 1];

        var carry = 0;
        var index = result.Length - 1;

        while (len1 > 0 || len2 > 0)
        {
            var sum = carry;

            if (len1 > 0)
            {
                sum += (int)char.GetNumericValue(a[--len1]);
            }

            if (len2 > 0)
            {
                sum += (int)char.GetNumericValue(b[--len2]);
            }

            carry = sum / 2;
            result[index--] = (char)((sum % 2) + '0');
        }

        if (carry <= 0)
        {
            return new string(result, index + 1, result.Length - index - 1);
        }

        result[index] = (char)(carry + '0');

        return new string(result).TrimStart('0');
    }
}