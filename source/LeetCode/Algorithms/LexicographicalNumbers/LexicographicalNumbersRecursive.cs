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

namespace LeetCode.Algorithms.LexicographicalNumbers;

/// <inheritdoc />
public sealed class LexicographicalNumbersRecursive : ILexicographicalNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> LexicalOrder(int n)
    {
        var result = new List<int>();

        LexicalOrder(1, Math.Min(9, n), n, result);

        return result;
    }

    private static void LexicalOrder(int currentNumber, int targetNumber, int maxNumber, List<int> numbers)
    {
        while (currentNumber <= targetNumber)
        {
            numbers.Add(currentNumber);

            var nextNumber = currentNumber * 10;

            if (nextNumber <= maxNumber)
            {
                LexicalOrder(nextNumber, Math.Min(nextNumber + 9, maxNumber), maxNumber, numbers);
            }

            currentNumber++;
        }
    }
}