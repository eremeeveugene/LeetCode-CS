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

namespace LeetCode.Algorithms.TrafficSignalColor;

/// <inheritdoc />
public sealed class TrafficSignalColorSimulation : ITrafficSignalColor
{
    private const int GreenTimer = 0;
    private const int OrangeTimer = 30;
    private const int MaxRedTimer = 90;
    private const string Green = "Green";
    private const string Orange = "Orange";
    private const string Red = "Red";
    private const string Invalid = "Invalid";

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public string TrafficSignal(int timer)
    {
        return timer switch
        {
            GreenTimer => Green,
            OrangeTimer => Orange,
            > OrangeTimer and <= MaxRedTimer => Red,
            _ => Invalid
        };
    }
}