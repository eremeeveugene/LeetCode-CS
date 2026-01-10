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

namespace LeetCode.Algorithms.TheTwoSneakyNumbersOfDigitville;

/// <inheritdoc />
public sealed class TheTwoSneakyNumbersOfDigitvilleArray : ITheTwoSneakyNumbersOfDigitville
{
    private const int MaxNumber = 100;
    private const int ResultLength = 2;
    private static readonly int[] Result = new int[ResultLength];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] GetSneakyNumbers(int[] nums)
    {
        Span<bool> numbers = stackalloc bool[MaxNumber];

        var resultIndex = 0;

        foreach (var num in nums)
        {
            if (numbers[num])
            {
                Result[resultIndex] = num;

                resultIndex++;

                if (resultIndex == ResultLength)
                {
                    break;
                }
            }
            else
            {
                numbers[num] = true;
            }
        }

        return Result;
    }
}