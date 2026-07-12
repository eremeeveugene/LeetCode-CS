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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.ConvertBinaryNumberInLinkedListToInteger;

/// <summary>
///     https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/description/
/// </summary>
public interface IConvertBinaryNumberInLinkedListToInteger
{
    /// <summary>
    ///     Converts the binary number represented by the linked list starting at <paramref name="head" /> into its
    ///     decimal value.
    /// </summary>
    /// <param name="head">The head node of the singly linked list representing the binary number.</param>
    /// <returns>The decimal value of the binary number represented by the linked list.</returns>
    int GetDecimalValue(ListNode head);
}