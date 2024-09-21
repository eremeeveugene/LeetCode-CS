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
public class LexicographicalNumbersIterative : ILexicographicalNumbers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<int> LexicalOrder(int n)
    {
        var result = new List<int>(n);

        var currentNumber = 1;

        for (var i = 0; i < n; i++)
        {
            result.Add(currentNumber);

            if (currentNumber * 10 <= n)
            {
                currentNumber *= 10;
            }
            else
            {
                if (currentNumber >= n)
                {
                    currentNumber /= 10;
                }

                currentNumber++;

                while (currentNumber % 10 == 0)
                {
                    currentNumber /= 10;
                }
            }
        }

        return result;
    }
}