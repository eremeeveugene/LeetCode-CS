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

/// <inheritdoc />
public class AddBinaryLinear : IAddBinary
{
    /// <summary>
    ///     Time complexity - O(max(n1, n2))
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public string AddBinary(string a, string b)
    {
        var result = new char[Math.Max(a.Length, b.Length) + 1];

        var aIndex = a.Length - 1;
        var bIndex = b.Length - 1;
        var resultIndex = result.Length - 1;

        var carry = 0;

        while (aIndex >= 0 || bIndex >= 0)
        {
            var sum = carry;

            if (aIndex >= 0)
            {
                sum += (int)char.GetNumericValue(a[aIndex]);
                aIndex--;
            }

            if (bIndex >= 0)
            {
                sum += (int)char.GetNumericValue(b[bIndex]);
                bIndex--;
            }

            carry = sum / 2;
            result[resultIndex--] = (char)((sum % 2) + '0');
        }

        if (carry <= 0)
        {
            return new string(result, resultIndex + 1, result.Length - resultIndex - 1);
        }

        result[resultIndex] = (char)(carry + '0');

        return new string(result).TrimStart('0');
    }
}