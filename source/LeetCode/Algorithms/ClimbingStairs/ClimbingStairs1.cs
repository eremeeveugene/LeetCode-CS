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

namespace LeetCode.Algorithms.ClimbingStairs;

/// <inheritdoc />
public class ClimbingStairs1 : IClimbingStairs
{
    public int ClimbStairs(int n)
    {
        var count = 0;

        var i = 1;

        while (i < n)
        {
            

            var sum = 0;

            var a = 1;

            var b = 2;

            while (sum <= 6)
            {
                sum += 1;

                count++;
            }
        }

        return count;
    }
}