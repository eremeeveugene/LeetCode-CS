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
public sealed class FinalValueOfVariableAfterPerformingOperationsContains : IFinalValueOfVariableAfterPerformingOperations
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="operations"></param>
    /// <returns></returns>
    public int FinalValueAfterOperations(string[] operations)
    {
        var finalValue = 0;

        for (var i = 0; i < operations.Length; i++)
        {
            var operation = operations[i];

            if (operation.Contains('+'))
            {
                finalValue++;
            }
            else
            {
                finalValue--;
            }
        }

        return finalValue;
    }
}