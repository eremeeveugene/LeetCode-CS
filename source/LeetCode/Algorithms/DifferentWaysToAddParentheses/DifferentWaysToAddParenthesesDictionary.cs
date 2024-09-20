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
public class DifferentWaysToAddParenthesesDictionary : IDifferentWaysToAddParentheses
{
    /// <summary>
    ///     Time complexity - O(n * 2^n)
    ///     Space complexity - O(4^n)
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    public IList<int> DiffWaysToCompute(string expression)
    {
        return DiffWaysToCompute(expression, new Dictionary<string, IList<int>>());
    }

    private static IList<int> DiffWaysToCompute(string expression, Dictionary<string, IList<int>> expressionsDictionary)
    {
        if (expressionsDictionary.TryGetValue(expression, out var value))
        {
            return value;
        }

        var results = new List<int>();

        if (int.TryParse(expression, out var number))
        {
            results.Add(number);

            expressionsDictionary[expression] = results;

            return results;
        }

        for (var i = 0; i < expression.Length; i++)
        {
            if (char.IsDigit(expression[i]))
            {
                continue;
            }

            var leftResults = DiffWaysToCompute(expression[..i], expressionsDictionary);
            var rightResults = DiffWaysToCompute(expression[(i + 1)..], expressionsDictionary);

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

        expressionsDictionary.Add(expression, results);

        return results;
    }
}