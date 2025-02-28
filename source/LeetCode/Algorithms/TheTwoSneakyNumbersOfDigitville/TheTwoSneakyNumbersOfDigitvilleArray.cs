// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class TheTwoSneakyNumbersOfDigitvilleArray : ITheTwoSneakyNumbersOfDigitville
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] GetSneakyNumbers(int[] nums)
    {
        var result = new int[2];
        var resultIndex = 0;

        var numbers = new bool[100];

        foreach (var num in nums)
        {
            if (numbers[num])
            {
                result[resultIndex] = num;

                resultIndex++;
            }
            else
            {
                numbers[num] = true;
            }
        }

        return result;
    }
}