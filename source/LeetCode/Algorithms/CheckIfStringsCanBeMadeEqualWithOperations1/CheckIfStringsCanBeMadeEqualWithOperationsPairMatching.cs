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

namespace LeetCode.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations1;

/// <inheritdoc />
public sealed class CheckIfStringsCanBeMadeEqualWithOperationsPairMatching : ICheckIfStringsCanBeMadeEqualWithOperations1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanBeEqual(string s1, string s2)
    {
        var firstAndThirdMatchDirectly = s1[0] == s2[0] && s1[2] == s2[2];
        var firstAndThirdMatchSwapped = s1[0] == s2[2] && s1[2] == s2[0];
        var secondAndFourthMatchDirectly = s1[1] == s2[1] && s1[3] == s2[3];
        var secondAndFourthMatchSwapped = s1[1] == s2[3] && s1[3] == s2[1];

        return (firstAndThirdMatchDirectly || firstAndThirdMatchSwapped) && (secondAndFourthMatchDirectly || secondAndFourthMatchSwapped);
    }
}