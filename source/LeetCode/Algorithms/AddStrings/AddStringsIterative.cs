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

using System.Text;

namespace LeetCode.Algorithms.AddStrings;

/// <inheritdoc />
public class AddStringsIterative : IAddStrings
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
        var resultBuilder = new StringBuilder();

        var num1Index = num1.Length - 1;
        var num2Index = num2.Length - 1;

        var carry = 0;

        while (num1Index >= 0 || num2Index >= 0)
        {
            var val1 = 0;
            var val2 = 0;

            if (num1Index >= 0)
            {
                val1 = (int)char.GetNumericValue(num1[num1Index]);
                num1Index--;
            }

            if (num2Index >= 0)
            {
                val2 = (int)char.GetNumericValue(num2[num2Index]);
                num2Index--;
            }

            var sum = val1 + val2 + carry;

            if (sum >= 10)
            {
                sum -= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            resultBuilder.Insert(0, sum);
        }

        if (carry > 0)
        {
            resultBuilder.Insert(0, carry);
        }

        return resultBuilder.ToString();
    }
}