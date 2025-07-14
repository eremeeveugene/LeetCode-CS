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
using System.Text;

namespace LeetCode.Algorithms.ConvertBinaryNumberInLinkedListToInteger;

/// <inheritdoc />
public class ConvertBinaryNumberInLinkedListToIntegerStringBuilder : IConvertBinaryNumberInLinkedListToInteger
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public int GetDecimalValue(ListNode head)
    {
        var stringBuilder = new StringBuilder();

        var current = head;

        while (current != null)
        {
            stringBuilder.Append(current.val);

            current = current.next;
        }

        return Convert.ToInt32(stringBuilder.ToString(), 2);
    }
}