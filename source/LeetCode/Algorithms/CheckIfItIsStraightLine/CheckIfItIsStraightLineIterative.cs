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

namespace LeetCode.Algorithms.CheckIfItIsStraightLine;

/// <inheritdoc />
public class CheckIfItIsStraightLineIterative : ICheckIfItIsStraightLine
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="coordinates"></param>
    /// <returns></returns>
    public bool CheckStraightLine(int[][] coordinates)
    {
        var a = coordinates[0];
        var b = coordinates[^1];

        var dx = b[0] - a[0];
        var dy = b[1] - a[1];

        for (var i = 1; i < coordinates.Length - 1; i++)
        {
            var x = coordinates[i][0] - a[0];
            var y = coordinates[i][1] - a[1];

            if (dx * y != dy * x)
            {
                return false;
            }
        }

        return true;
    }
}