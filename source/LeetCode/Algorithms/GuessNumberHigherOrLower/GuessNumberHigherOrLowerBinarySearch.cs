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

namespace LeetCode.Algorithms.GuessNumberHigherOrLower;

public sealed class GuessNumberHigherOrLowerBinarySearch : GuessNumberHigherOrLower
{
    public GuessNumberHigherOrLowerBinarySearch(int pickedNumber) : base(pickedNumber)
    {
    }

    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public override int GuessNumber(int n)
    {
        var left = 1;
        var right = n;
        int num;

        do
        {
            num = left + ((right - left) / 2);

            var result = Guess(num);

            if (result == 0)
            {
                break;
            }

            if (result > 0)
            {
                left = num + 1;
            }
            else
            {
                right = num - 1;
            }
        } while (left <= right);

        return num;
    }
}