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

namespace LeetCode.Tests.Base.Extensions;

public static class ListNodeAssert
{
    public static void AreEqual(IList<ListNode?> expectedLists, IList<ListNode?> actualLists)
    {
        Assert.AreEqual(expectedLists.Count, actualLists.Count,
            "Both lists should have the same number of ListNode elements.");

        for (var i = 0; i < expectedLists.Count; i++)
        {
            var expectedList = expectedLists[i];
            var actualList = actualLists[i];

            while (expectedList != null && actualList != null)
            {
                Assert.AreEqual(expectedList.val, actualList.val, $"Values should be equal at each node in list {i}.");
                expectedList = expectedList.next;
                actualList = actualList.next;
            }

            Assert.IsNull(expectedList, $"Expected result should not have more nodes in list {i}.");
            Assert.IsNull(actualList, $"Actual result should not have more nodes in list {i}.");
        }
    }

    public static void AreEqual(ListNode? expectedList, ListNode? actualList)
    {
        while (expectedList != null && actualList != null)
        {
            Assert.AreEqual(expectedList.val, actualList.val, "Values should be equal at each node.");
            expectedList = expectedList.next;
            actualList = actualList.next;
        }

        Assert.IsNull(expectedList, "Expected result should not have more nodes.");
        Assert.IsNull(actualList, "Actual result should not have more nodes.");
    }
}