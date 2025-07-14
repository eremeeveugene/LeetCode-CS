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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.ConvertBinaryNumberInLinkedListToInteger;

/// <summary>
///     https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/description/
/// </summary>
public interface IConvertBinaryNumberInLinkedListToInteger
{
    int GetDecimalValue(ListNode head);
}