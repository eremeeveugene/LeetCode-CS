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

namespace LeetCode.Algorithms.FinalValueOfVariableAfterPerformingOperations;

/// <inheritdoc />
public sealed class FinalValueOfVariableAfterPerformingOperationsSwitch : IFinalValueOfVariableAfterPerformingOperations
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FinalValueAfterOperations(string[] operations)
    {
        var finalValue = 0;

        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "++X" or "X++":
                    finalValue++;
                    break;
                case "--X" or "X--":
                    finalValue--;
                    break;
            }
        }

        return finalValue;
    }
}