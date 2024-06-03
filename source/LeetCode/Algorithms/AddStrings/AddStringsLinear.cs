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

/// <inheritdoc />
public class AddStringsLinear : IAddStrings
{
    /// <summary>
    ///     Time complexity - O(max(n, m))
    ///     Space complexity - O(max(n, m))
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string AddStrings(string num1, string num2)
    {
        var result = new char[Math.Max(num1.Length, num2.Length) + 1];

        var num1Index = num1.Length - 1;
        var num2Index = num2.Length - 1;
        var resultIndex = result.Length - 1;

        var carry = 0;

        while (num1Index >= 0 || num2Index >= 0)
        {
            var sum = carry;

            if (num1Index >= 0)
            {
                sum += (int)char.GetNumericValue(num1[num1Index]);
                num1Index--;
            }

            if (num2Index >= 0)
            {
                sum += (int)char.GetNumericValue(num2[num2Index]);
                num2Index--;
            }

            carry = sum / 10;
            result[resultIndex--] = (char)((sum % 10) + '0');
        }

        if (carry <= 0)
        {
            return new string(result, resultIndex + 1, result.Length - resultIndex - 1);
        }

        result[resultIndex] = (char)(carry + '0');

        return new string(result).TrimStart('0');
    }
}