using LeetCode.Algorithms.MergeTwoSortedListsTask;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class MergeTwoSortedListsTests
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [DataRow(new int[] { }, new int[] { }, new int[] { })]
    [DataRow(new int[] { }, new int[] {0 }, new int[] {0 })]
    [DataRow(new[] {-9, 3}, new[] { 5,7 }, new[] { -9,3,5,7})]
    public void TwoSum_GetResult_ReturnsExpectedIndicesForGivenTarget(int[] array1, int[] array2,
        int[] expectedResultArray)
    {
        // Arrange

        ListNode? list1 = array1.Reverse().Aggregate<int, ListNode?>(null, (current, t) => new ListNode(t, current));
        ListNode? list2 = array2.Reverse().Aggregate<int, ListNode?>(null, (current, t) => new ListNode(t, current));
        ListNode? expectedResultList = expectedResultArray.Reverse().Aggregate<int, ListNode?>(null, (current, t) => new ListNode(t, current));

        //var list1Node3 = new ListNode(4);
        //var list1Node2 = new ListNode(2, list1Node3);
        //var list1Node1 = new ListNode(1, list1Node2);

        //var list2Node3 = new ListNode(4);
        //var list2Node2 = new ListNode(3, list2Node3);
        //var list2Node1 = new ListNode(1, list2Node2);

        //var expectedResultNode6 = new ListNode(4);
        //var expectedResultNode5 = new ListNode(4, expectedResultNode6);
        //var expectedResultNode4 = new ListNode(3, expectedResultNode5);
        //var expectedResultNode3 = new ListNode(2, expectedResultNode4);
        //var expectedResultNode2 = new ListNode(1, expectedResultNode3);
        //var expectedResultNode1 = new ListNode(1, expectedResultNode2);

        // Act
        var actualResultList = MergeTwoSortedLists.GetResult(list1, list2);

        // Assert
        AssertMergedListEquals(expectedResultList, actualResultList);
    }

    private void AssertMergedListEquals(ListNode expected, ListNode actual)
    {
        while (expected != null && actual != null)
        {
            Assert.AreEqual(expected.Value, actual.Value, "Values should be equal at each node.");
            expected = expected.NextNode;
            actual = actual.NextNode;
        }

        Assert.IsNull(expected, "Expected result should not have more nodes.");
        Assert.IsNull(actual, "Actual result should not have more nodes.");
    }
}