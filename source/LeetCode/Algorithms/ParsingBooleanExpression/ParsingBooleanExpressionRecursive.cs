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

namespace LeetCode.Algorithms.ParsingBooleanExpression;

/// <inheritdoc />
public class ParsingBooleanExpressionRecursive : IParsingBooleanExpression
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    public bool ParseBoolExpr(string expression)
    {
        if (expression.Length == 1)
        {
            return expression == "t";
        }

        var operation = expression[0];

        if (operation == '!')
        {
            return !ParseBoolExpr(expression.Substring(2, expression.Length - 3));
        }

        var result = operation == '&';

        var level = 0;
        var start = 2;

        for (var i = start; i < expression.Length; i++)
        {
            var character = expression[i];

            switch (character)
            {
                case '(':
                    level++;
                    break;
                case ')':
                    level--;
                    break;
            }

            if ((character != ',' || level != 0) && (character != ')' || level != -1))
            {
                continue;
            }

            var subExpression = expression.Substring(start, i - start);
            var subResult = ParseBoolExpr(subExpression);

            switch (operation)
            {
                case '&':
                    result &= subResult;
                    break;
                case '|':
                    result |= subResult;
                    break;
            }

            start = i + 1;
        }

        return result;
    }
}