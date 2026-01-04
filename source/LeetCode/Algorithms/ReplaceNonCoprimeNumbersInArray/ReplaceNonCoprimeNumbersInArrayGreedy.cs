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

namespace LeetCode.Algorithms.ReplaceNonCoprimeNumbersInArray;

/// <inheritdoc />
public class ReplaceNonCoprimeNumbersInArrayGreedy : IReplaceNonCoprimeNumbersInArray
{
    /// <summary>
    ///     Time complexity - O(n log M), where n is the length of nums and M is max(nums[i])
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<int> ReplaceNonCoprimes(int[] nums)
    {
        var top = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var x = nums[i];

            while (top >= 0)
            {
                var y = nums[top];

                var greatestCommonDivisor = GetGreatestCommonDivisor(x, y);

                if (!IsNonComprime(greatestCommonDivisor))
                {
                    break;
                }

                x = GetLeastCommonMultiple(x, y, greatestCommonDivisor);

                top--;
            }

            top++;

            nums[top] = x;
        }

        var resultLength = top + 1;

        var result = new List<int>(resultLength);

        for (var i = 0; i < resultLength; i++)
        {
            result.Add(nums[i]);
        }

        return result;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="greatestCommonDivisor"></param>
    /// <returns></returns>
    private static bool IsNonComprime(int greatestCommonDivisor)
    {
        return greatestCommonDivisor > 1;
    }

    /// <summary>
    ///     Time complexity - O(log(min(x, y)))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    private static int GetGreatestCommonDivisor(int x, int y)
    {
        while (y != 0)
        {
            var temp = y;

            y = x % y;

            x = temp;
        }

        return int.Abs(x);
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="greatestCommonDivisor"></param>
    /// <returns></returns>
    private static int GetLeastCommonMultiple(int x, int y, int greatestCommonDivisor)
    {
        return int.Abs(x / greatestCommonDivisor * y);
    }
}