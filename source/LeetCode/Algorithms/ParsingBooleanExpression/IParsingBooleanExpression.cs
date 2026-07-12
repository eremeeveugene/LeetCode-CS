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

namespace LeetCode.Algorithms.ParsingBooleanExpression;

/// <summary>
///     https://leetcode.com/problems/parsing-a-boolean-expression/description/
/// </summary>
public interface IParsingBooleanExpression
{
    /// <summary>
    ///     Evaluates <paramref name="expression" />, a boolean expression composed of the literals 't' and 'f' and
    ///     the operators <c>!</c> (not), <c>&amp;</c> (and), and <c>|</c> (or).
    /// </summary>
    /// <param name="expression">The boolean expression string to parse and evaluate.</param>
    /// <returns><see langword="true" /> if <paramref name="expression" /> evaluates to true; otherwise, <see langword="false" />.</returns>
    bool ParseBoolExpr(string expression);
}