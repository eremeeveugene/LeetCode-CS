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

namespace LeetCode.Algorithms.DesignCircularQueue;

/// <summary>
///     https://leetcode.com/problems/design-circular-queue/description/
/// </summary>
public interface IDesignCircularQueue
{
    bool EnQueue(int value);

    bool DeQueue();

    int Front();

    int Rear();

    bool IsEmpty();

    bool IsFull();
}