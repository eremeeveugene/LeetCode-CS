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

namespace LeetCode.Algorithms.FractionAdditionAndSubtraction;

/// <inheritdoc />
public class FractionAdditionAndSubtractionSimulation : IFractionAdditionAndSubtraction
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    public string FractionAddition(string expression)
    {
        var numerator = 0;
        var denominator = 1;
        var i = 0;

        while (i < expression.Length)
        {
            var sign = 1;

            switch (expression[i])
            {
                case '-':
                    sign = -1;

                    i++;
                    break;
                case '+':
                    i++;
                    break;
            }

            var currentNumerator = 0;

            while (i < expression.Length && char.IsDigit(expression[i]))
            {
                currentNumerator = (currentNumerator * 10) + (int)char.GetNumericValue(expression[i]);

                i++;
            }

            currentNumerator *= sign;

            i++;

            var currentDenominator = 0;

            while (i < expression.Length && char.IsDigit(expression[i]))
            {
                currentDenominator = (currentDenominator * 10) + (int)char.GetNumericValue(expression[i]);
                i++;
            }

            numerator = (numerator * currentDenominator) + (currentNumerator * denominator);
            denominator *= currentDenominator;

            var divisor = GetDivisor(numerator, denominator);

            numerator /= divisor;
            denominator /= divisor;
        }

        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }

        return $"{numerator}/{denominator}";
    }

    private static int GetDivisor(int numerator, int denominator)
    {
        while (denominator != 0)
        {
            var temp = denominator;
            denominator = numerator % denominator;
            numerator = temp;
        }

        return numerator;
    }
}