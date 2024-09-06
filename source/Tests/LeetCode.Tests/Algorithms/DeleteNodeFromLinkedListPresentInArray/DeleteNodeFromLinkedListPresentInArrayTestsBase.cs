using LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodeFromLinkedListPresentInArray;

public abstract class DeleteNodeFromLinkedListPresentInArrayTestsBase<T>
    where T : IDeleteNodeFromLinkedListPresentInArray, new()
{
    [TestMethod]
    [DataRow(new int[] { }, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5 })]
    [DataRow(new[] { 1 }, new[] { 1, 2, 1, 2, 1, 2 }, new[] { 2, 2, 2 })]
    [DataRow(new[] { 5 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 312, 514, 872, 995, 1204, 1567, 2093, 3057, 4500, 4999, 5781, 6352, 7234, 8345, 9999 },
        new[]
        {
            234, 312, 405, 514, 672, 872, 995, 1040, 1204, 1500, 1567, 2093, 2500, 3057, 4000, 4500, 4999, 5781,
            6000, 6352, 7000, 7234, 8000, 8345, 9000, 9999
        }, new[] { 234, 405, 672, 1040, 1500, 2500, 4000, 6000, 7000, 8000, 9000 })]
    public void ModifiedList_WithNumsAndHeadArray_ReturnsModifiedList(int[] nums, int[] headArray,
        int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ModifiedList(nums, head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}