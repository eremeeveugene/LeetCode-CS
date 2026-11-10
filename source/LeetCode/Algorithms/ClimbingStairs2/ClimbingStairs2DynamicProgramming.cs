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

namespace LeetCode.Algorithms.ClimbingStairs2;

/// <inheritdoc />
public sealed class ClimbingStairs2DynamicProgramming : IClimbingStairs2
{
    private const int UnreachableCost = int.MaxValue / 2;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int ClimbStairs(int n, int[] costs)
    {
        var threeStepsBackCost = UnreachableCost;
        var twoStepsBackCost = UnreachableCost;
        var oneStepBackCost = 0;

        for (var i = 0; i < n; i++)
        {
            var cost = costs[i];

            var fromOneStepBackCost = oneStepBackCost + 1;
            var fromTwoStepsBackCost = twoStepsBackCost + 4;
            var fromThreeStepsBackCost = threeStepsBackCost + 9;

            var minJumpCost = Math.Min(fromOneStepBackCost, Math.Min(fromTwoStepsBackCost, fromThreeStepsBackCost));
            var currentCost = minJumpCost + cost;

            threeStepsBackCost = twoStepsBackCost;
            twoStepsBackCost = oneStepBackCost;
            oneStepBackCost = currentCost;
        }

        return oneStepBackCost;
    }
}