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

namespace LeetCode.Algorithms.ImplementRouter;

/// <summary>
///     https://leetcode.com/problems/implement-router/description/
/// </summary>
public interface IImplementRouter
{
    bool AddPacket(int source, int destination, int timestamp);

    int[] ForwardPacket();

    int GetCount(int destination, int startTime, int endTime);
}