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

namespace LeetCode.Algorithms.ElevatorRequests1;

/// <inheritdoc />
public sealed class ElevatorRequests1Simulation : IElevatorRequests1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m), where m is the number of requests
    ///     Space complexity - O(1)
    /// </remarks>
    public int ElevatorRequests(int n, int[] requests)
    {
        var m = requests.Length;

        var result = 0;
        var currentFloor = 0;

        for (var i = 0; i < m; i++)
        {
            var request = requests[i];

            result += Math.Abs(currentFloor - request);

            currentFloor = request;
        }

        return result;
    }
}