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

namespace LeetCode.Algorithms.NumberOfSeniorCitizens;

/// <inheritdoc />
public class NumberOfSeniorCitizensCharacterComparison : INumberOfSeniorCitizens
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="details"></param>
    /// <returns></returns>
    public int CountSeniors(string[] details)
    {
        return details.Count(x => x[^4] > '6' || (x[^4] == '6' && x[^3] > '0'));
    }
}