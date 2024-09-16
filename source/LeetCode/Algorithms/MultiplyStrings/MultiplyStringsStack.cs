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

namespace LeetCode.Algorithms.MultiplyStrings;

/// <inheritdoc />
public class MultiplyStringsStack : IMultiplyStrings
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        var valuesStack = new Stack<string>();

        var num2Index = num2.Length - 1;

        var num2Multiplier = 0;

        while (num2Index >= 0)
        {
            var multiplyValuesStack = new Stack<int>();

            var num2Value = (int)char.GetNumericValue(num2[num2Index]);

            num2Index--;

            var num1Index = num1.Length - 1;

            var remainder = 0;

            while (num1Index >= 0)
            {
                var num1Value = (int)char.GetNumericValue(num1[num1Index]);

                num1Index--;

                var value = (num1Value * num2Value) + remainder;
                remainder = value / 10;
                value = value % 10;

                multiplyValuesStack.Push(value);
            }

            if (remainder > 0)
            {
                multiplyValuesStack.Push(remainder);
            }

            var valueStringBuilder = new StringBuilder();

            while (multiplyValuesStack.Count > 0)
            {
                var value = multiplyValuesStack.Pop();

                valueStringBuilder.Append(value);
            }

            for (var i = 0; i < num2Multiplier; i++)
            {
                valueStringBuilder.Append('0');
            }

            valuesStack.Push(valueStringBuilder.ToString());

            num2Multiplier++;
        }

        var result = valuesStack.Pop();

        while (valuesStack.Count > 0)
        {
            var value = valuesStack.Pop();

            result = Add(result, value);
        }

        return result;
    }

    private static string Add(string num1, string num2)
    {
        var num1Index = num1.Length - 1;
        var num2Index = num2.Length - 1;

        var remainder = 0;
        var valuesStack = new Stack<int>();

        while (num1Index >= 0 || num2Index >= 0)
        {
            var num1Value = num1Index >= 0 ? (int)char.GetNumericValue(num1[num1Index--]) : 0;
            var num2Value = num2Index >= 0 ? (int)char.GetNumericValue(num2[num2Index--]) : 0;

            var sum = num1Value + num2Value + remainder;

            remainder = sum / 10;

            valuesStack.Push(sum % 10);
        }

        if (remainder > 0)
        {
            valuesStack.Push(remainder);
        }

        var resultStringBuilder = new StringBuilder();

        while (valuesStack.Count > 0)
        {
            var value = valuesStack.Pop();

            resultStringBuilder.Append(value);
        }

        return resultStringBuilder.ToString();
    }
}