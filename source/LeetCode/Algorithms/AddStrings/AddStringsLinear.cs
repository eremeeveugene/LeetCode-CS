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

namespace LeetCode.Algorithms.AddStrings;

/// <summary>
///     https://leetcode.com/problems/add-strings/description/
/// </summary>
public static class AddStringsLinear
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static string GetResult(string num1, string num2)
    {
        var len1 = num1.Length;
        var len2 = num2.Length;

        var result = new char[Math.Max(len1, len2) + 1];

        var carry = 0;
        var index = result.Length - 1;

        while (len1 > 0 || len2 > 0)
        {
            var sum = carry;

            if (len1 > 0)
            {
                sum += (int)char.GetNumericValue(num1[--len1]);
            }

            if (len2 > 0)
            {
                sum += (int)char.GetNumericValue(num2[--len2]);
            }

            carry = sum / 10;
            result[index--] = (char)((sum % 10) + '0');
        }

        if (carry <= 0)
        {
            return new string(result, index + 1, result.Length - index - 1);
        }

        result[index] = (char)(carry + '0');

        return new string(result).TrimStart('0');
    }
}