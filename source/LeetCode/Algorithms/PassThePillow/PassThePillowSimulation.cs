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

namespace LeetCode.Algorithms.PassThePillow;

/// <inheritdoc />
public class PassThePillowSimulation : IPassThePillow
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    public int PassThePillow(int n, int time)
    {
        var currentPerson = 1;

        var isReversed = false;

        var currentTime = 0;

        while (currentTime < time)
        {
            if (isReversed)
            {
                currentPerson--;
            }
            else
            {
                currentPerson++;
            }

            if (currentPerson == n)
            {
                isReversed = true;
            }
            else if (currentPerson == 1)
            {
                isReversed = false;
            }

            currentTime++;
        }

        return currentPerson;
    }
}