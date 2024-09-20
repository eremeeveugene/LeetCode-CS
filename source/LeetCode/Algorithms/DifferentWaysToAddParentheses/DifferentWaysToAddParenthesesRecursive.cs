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

namespace LeetCode.Algorithms.DifferentWaysToAddParentheses;

/// <inheritdoc />
public class DifferentWaysToAddParenthesesRecursive : IDifferentWaysToAddParentheses
{
    /// <summary>
    ///     Time complexity - O(3^n)
    ///     Space complexity - O(3^n)
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    public IList<int> DiffWaysToCompute(string expression)
    {
        var results = new List<int>();

        if (int.TryParse(expression, out var number))
        {
            results.Add(number);

            return results;
        }

        for (var i = 0; i < expression.Length; i++)
        {
            if (char.IsDigit(expression[i]))
            {
                continue;
            }

            var leftResults = DiffWaysToCompute(expression[..i]);
            var rightResults = DiffWaysToCompute(expression[(i + 1)..]);

            foreach (var leftResult in leftResults)
            {
                results.AddRange(rightResults.Select(rightResult => expression[i] switch
                {
                    '+' => leftResult + rightResult,
                    '-' => leftResult - rightResult,
                    '*' => leftResult * rightResult,
                    _ => 0
                }));
            }
        }

        return results;
    }
}