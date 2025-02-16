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

namespace LeetCode.Algorithms.DesignFrontMiddleBackQueue;

/// <summary>
///     https://leetcode.com/problems/design-front-middle-back-queue/description/
/// </summary>
public interface IDesignFrontMiddleBackQueue
{
    void PushFront(int value);

    void PushMiddle(int value);

    void PushBack(int value);

    int PopFront();

    int PopMiddle();

    int PopBack();
}