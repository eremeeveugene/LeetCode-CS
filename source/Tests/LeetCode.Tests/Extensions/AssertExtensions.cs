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

using LeetCode.Core.Models;

namespace LeetCode.Tests.Extensions;

public static class AssertExtensions
{
    public static void AreListNodesEqual(ListNode? expectedList, ListNode? actualList)
    {
        while (expectedList != null && actualList != null)
        {
            Assert.AreEqual(expectedList.val, actualList.val, "Values should be equal at each node.");
            expectedList = expectedList.next;
            actualList = actualList.next;
        }

        Assert.IsNull(actualList, "Actual result should not have more nodes.");
    }
}