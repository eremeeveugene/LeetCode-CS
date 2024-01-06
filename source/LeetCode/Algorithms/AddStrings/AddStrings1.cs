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

using System.Globalization;
using System.Text;

namespace LeetCode.Algorithms.AddStrings;

/// <summary>
///     https://leetcode.com/problems/add-strings/description/
/// </summary>
public static class AddStrings1
{
    public static string GetResult(string num1, string num2)
    {
        StringBuilder resultBuilder = new StringBuilder();

        int carry = 0;

        int num1Index = num1.Length;
        int num2Index = num2.Length;

        while (num1Index > 0 || num2Index > 0)
        {
            double int1 = 0;
            double int2 = 0;

            if (num1Index > 0)
            {
                int1 = char.GetNumericValue(num1[num1Index - 1]);
            }

            if (num2Index > 0)
            {
                int2 = char.GetNumericValue(num2[num2Index - 1]);
            }

            double sum = int1 + int2 + carry;

            if (sum > 9)
            {
                sum -= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            resultBuilder.Insert(0, sum.ToString(CultureInfo.InvariantCulture));

            num1Index--;
            num2Index--;
        }

        if (carry > 0)
        {
            resultBuilder.Insert(0, carry.ToString());
        }

        return resultBuilder.ToString();
    }
}