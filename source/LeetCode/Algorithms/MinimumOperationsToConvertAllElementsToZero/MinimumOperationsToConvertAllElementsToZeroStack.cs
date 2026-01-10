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

namespace LeetCode.Algorithms.MinimumOperationsToConvertAllElementsToZero;

/// <inheritdoc />
public sealed class MinimumOperationsToConvertAllElementsToZeroStack : IMinimumOperationsToConvertAllElementsToZero
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinOperations(int[] nums)
    {
        var numsStack = new Stack<int>();

        var minOperations = 0;

        foreach (var num in nums)
        {
            while (numsStack.Count > 0 && numsStack.Peek() > num)
            {
                numsStack.Pop();
            }

            if (num == 0)
            {
                continue;
            }

            if (numsStack.Count > 0 && numsStack.Peek() >= num)
            {
                continue;
            }

            numsStack.Push(num);

            minOperations++;
        }

        return minOperations;
    }
}