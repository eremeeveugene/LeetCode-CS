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

public static class AddStrings1
{
    public static string GetResult(string num1, string num2)
    {
        var resultBuilder = new StringBuilder();
        
        var carry = 0;

        var num1Length = num1.Length;
        var num2Length = num2.Length;

        var length = num1Length > num2Length ? num1Length : num2Length;

        for (int i = length - 1; i >= 0; i--)
        {
            double int1 = 0;
            double int2 = 0;

            if (i < num1Length)
            {
                int1 = char.GetNumericValue(num1[i]);

            }

            if (i < num2Length)
            {
                int2 = char.GetNumericValue(num2[i]);

            }

            var sum = int1 + int2 + carry;

            if (sum > 9)
            {
                sum -= 9;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            resultBuilder.Insert(0, sum.ToString());
        }

        return resultBuilder.ToString();
    }
}