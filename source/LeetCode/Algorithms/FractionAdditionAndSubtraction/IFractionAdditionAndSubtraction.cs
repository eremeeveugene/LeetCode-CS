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

namespace LeetCode.Algorithms.FractionAdditionAndSubtraction;

/// <summary>
///     https://leetcode.com/problems/fraction-addition-and-subtraction/description/
/// </summary>
public interface IFractionAdditionAndSubtraction
{
    /// <summary>
    ///     Evaluates the mixed addition and subtraction <paramref name="expression" /> of fractions and returns the result as an irreducible fraction.
    /// </summary>
    /// <param name="expression">The expression containing fractions separated by '+' or '-' signs.</param>
    /// <returns>The resulting fraction in irreducible form, expressed as a string.</returns>
    string FractionAddition(string expression);
}