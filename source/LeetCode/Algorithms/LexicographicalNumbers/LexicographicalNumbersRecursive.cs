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

namespace LeetCode.Algorithms.LexicographicalNumbers;

/// <inheritdoc />
public class LexicographicalNumbersRecursive : ILexicographicalNumbers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<int> LexicalOrder(int n)
    {
        return LexicalOrder(1, int.Min(9, n), n);
    }

    private static List<int> LexicalOrder(int currentNumber, int targetNumber, int maxNumber)
    {
        var result = new List<int>();

        while (currentNumber <= targetNumber)
        {
            result.Add(currentNumber);

            var nextNumber = currentNumber * 10;

            if (nextNumber <= maxNumber)
            {
                var nextNumbers = LexicalOrder(nextNumber, int.Min(nextNumber + 9, maxNumber), maxNumber);

                result.AddRange(nextNumbers);
            }

            currentNumber++;
        }

        return result;
    }
}