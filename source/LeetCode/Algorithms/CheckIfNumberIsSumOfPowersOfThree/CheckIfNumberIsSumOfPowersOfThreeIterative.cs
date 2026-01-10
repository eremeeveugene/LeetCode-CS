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

namespace LeetCode.Algorithms.CheckIfNumberIsSumOfPowersOfThree;

/// <inheritdoc />
public sealed class CheckIfNumberIsSumOfPowersOfThreeIterative : ICheckIfNumberIsSumOfPowersOfThree
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool CheckPowersOfThree(int n)
    {
        for (var i = 14; i >= 0; i--)
        {
            var pow = (int)Math.Pow(3, i);

            if (n - pow >= 0)
            {
                n -= pow;
            }
        }

        return n == 0;
    }
}