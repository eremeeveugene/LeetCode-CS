using LeetCode.Core;

namespace LeetCode.Tests;

public static class AssertExtensions
{
    public static void AssertListNode(ListNode? expectedList, ListNode? actualList)
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