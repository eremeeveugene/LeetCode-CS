using LeetCode.Algorithms.MergeTwoSortedListsTask;
using LeetCode.Core;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class MergeTwoSortedListsTests
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [DataRow(new int[] { }, new int[] { }, new int[] { })]
    [DataRow(new int[] { }, new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { -9, 3 }, new[] { 5, 7 }, new[] { -9, 3, 5, 7 })]
    public void MergeTwoSortedLists_GetResult_ShouldMergeAndMatchExpectedResult(int[] array1, int[] array2,
        int[] expectedResultArray)
    {
        // Arrange
        var list1 = array1.Reverse().Aggregate<int, ListNode?>(null, AggregateListNode);
        var list2 = array2.Reverse().Aggregate<int, ListNode?>(null, AggregateListNode);
        var expectedResultList = expectedResultArray.Reverse().Aggregate<int, ListNode?>(null, AggregateListNode);

        // Act
        var actualResultList = MergeTwoSortedLists.GetResult(list1, list2);

        // Assert
        while (expectedResultList != null && actualResultList != null)
        {
            Assert.AreEqual(expectedResultList.val, actualResultList.val, "Values should be equal at each node.");
            expectedResultList = expectedResultList.next;
            actualResultList = actualResultList.next;
        }

        Assert.IsNull(expectedResultList, "Expected result should not have more nodes.");
        Assert.IsNull(actualResultList, "Actual result should not have more nodes.");
    }

    private static ListNode AggregateListNode(ListNode? next, int val)
    {
        return new ListNode(val, next);
    }
}