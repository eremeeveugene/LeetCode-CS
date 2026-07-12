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

namespace LeetCode.Algorithms.DesignAnOrderedStream;

/// <summary>
///     https://leetcode.com/problems/design-an-ordered-stream/
/// </summary>
public interface IDesignAnOrderedStream
{
    /// <summary>
    ///     Inserts the pair (<paramref name="idKey" />, <paramref name="value" />) into the ordered stream and returns
    ///     the largest possible chunk of currently inserted values that appear next in the order.
    /// </summary>
    /// <param name="idKey">The one-based identifier of the value in the stream.</param>
    /// <param name="value">The value to insert.</param>
    /// <returns>The chunk of consecutive values that starts at the current pointer, or an empty list if none.</returns>
    IList<string?> Insert(int idKey, string value);
}