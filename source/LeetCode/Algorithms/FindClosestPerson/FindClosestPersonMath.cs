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

namespace LeetCode.Algorithms.FindClosestPerson;

/// <inheritdoc />
public class FindClosestPersonMath : IFindClosestPerson
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <returns></returns>
    public int FindClosest(int x, int y, int z)
    {
        var distanceFromX = Math.Abs(z - x);
        var distanceFromY = Math.Abs(z - y);

        if (distanceFromX < distanceFromY)
        {
            return 1;
        }

        return distanceFromX > distanceFromY ? 2 : 0;
    }
}