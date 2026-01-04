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

/// <inheritdoc />
public class ConvertBinaryNumberInLinkedListToIntegerIterative : IConvertBinaryNumberInLinkedListToInteger
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public int GetDecimalValue(ListNode head)
    {
        var result = 0;

        var current = head;

        while (current != null)
        {
            result *= 2;
            result += current.val;

            current = current.next;
        }

        return result;
    }
}