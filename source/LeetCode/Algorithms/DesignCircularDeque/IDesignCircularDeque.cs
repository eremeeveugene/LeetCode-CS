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

namespace LeetCode.Algorithms.DesignCircularDeque;

/// <summary>
///     https://leetcode.com/problems/design-circular-deque/description/
/// </summary>
public interface IDesignCircularDeque
{
    bool InsertFront(int value);

    bool InsertLast(int value);

    bool DeleteFront();

    bool DeleteLast();

    int GetFront();

    int GetRear();

    bool IsEmpty();

    bool IsFull();
}