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
public sealed class CheckIfNumberIsSumOfPowersOfThreeBase3Check : ICheckIfNumberIsSumOfPowersOfThree
{
    /// <summary>
    ///     Time complexity - O(log3(n))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool CheckPowersOfThree(int n)
    {
        while (n > 0)
        {
            if (n % 3 == 2)
            {
                return false;
            }

            n /= 3;
        }

        return true;
    }
}