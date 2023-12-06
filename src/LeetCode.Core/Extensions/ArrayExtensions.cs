// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Core.Extensions;

public static class ArrayExtensions
{
    public static ListNode? ToListNode(this int[] array)
    {
        return array.Reverse().Aggregate<int, ListNode?>(null, (next, val) => new ListNode(val, next));
    }
}