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

using System.Text;

namespace LeetCode.Algorithms.FractionToRecurringDecimal;

/// <inheritdoc />
public class FractionToRecurringDecimalDictionary : IFractionToRecurringDecimal
{
    private const string Zero = "0";
    private const char Minus = '-';
    private const char DecimalPoint = '.';
    private const char OpeningParenthesis = '(';
    private const char ClosingParenthesis = ')';

    /// <summary>
    ///     Time complexity - O(n), where n is the number of digits in the resulting decimal representation
    ///     Space complexity - O(n), where n is the number of digits in the resulting decimal representation
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    /// <returns></returns>
    public string FractionToDecimal(int numerator, int denominator)
    {
        if (numerator == 0)
        {
            return Zero;
        }

        var stringBuilder = new StringBuilder();

        if ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0))
        {
            stringBuilder.Append(Minus);
        }

        var dividend = Math.Abs((long)numerator);
        var divisor = Math.Abs((long)denominator);

        stringBuilder.Append(dividend / divisor);

        var remainder = dividend % divisor;

        if (remainder == 0)
        {
            return stringBuilder.ToString();
        }

        stringBuilder.Append(DecimalPoint);

        var remainderToIndex = new Dictionary<long, int>();

        while (remainder != 0)
        {
            if (remainderToIndex.TryGetValue(remainder, out var index))
            {
                stringBuilder.Insert(index, OpeningParenthesis);
                stringBuilder.Append(ClosingParenthesis);

                break;
            }

            remainderToIndex[remainder] = stringBuilder.Length;
            remainder *= 10;
            stringBuilder.Append(remainder / divisor);
            remainder %= divisor;
        }

        return stringBuilder.ToString();
    }
}