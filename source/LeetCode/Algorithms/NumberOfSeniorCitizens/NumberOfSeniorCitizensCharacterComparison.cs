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

/// <inheritdoc />
public sealed class NumberOfSeniorCitizensCharacterComparison : INumberOfSeniorCitizens
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountSeniors(string[] details)
    {
        var count = 0;

        for (var i = 0; i < details.Length; i++)
        {
            var detail = details[i];

            if (detail[^4] > '6' || (detail[^4] == '6' && detail[^3] > '0'))
            {
                count++;
            }
        }

        return count;
    }
}