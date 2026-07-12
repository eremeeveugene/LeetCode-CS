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

namespace LeetCode.Algorithms.KthLargestElementInStream;

/// <summary>
///     https://leetcode.com/problems/kth-largest-element-in-a-stream/description/
/// </summary>
public interface IKthLargestElementInStream
{
    /// <summary>
    ///     Appends <paramref name="val" /> to the stream and returns the k-th largest element in the stream.
    /// </summary>
    /// <param name="val">The value to add to the stream.</param>
    /// <returns>The k-th largest element in the stream after the value is added.</returns>
    int Add(int val);
}