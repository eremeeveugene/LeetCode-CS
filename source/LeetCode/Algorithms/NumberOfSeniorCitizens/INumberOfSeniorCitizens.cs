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

namespace LeetCode.Algorithms.NumberOfSeniorCitizens;

/// <summary>
///     https://leetcode.com/problems/number-of-senior-citizens/
/// </summary>
public interface INumberOfSeniorCitizens
{
    /// <summary>
    ///     Counts the number of passengers who are strictly older than 60, based on the age encoded within each
    ///     passenger's identity information in <paramref name="details" />.
    /// </summary>
    /// <param name="details">The array of 15-character passenger detail strings, each encoding a two-digit age.</param>
    /// <returns>The number of passengers older than 60.</returns>
    int CountSeniors(string[] details);
}