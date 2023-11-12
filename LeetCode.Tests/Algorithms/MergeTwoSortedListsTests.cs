using LeetCode.Algorithms.MergeTwoSortedListsTask;
using LeetCode.Core.Extensions;

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
        var list1 = array1.ToListNode();
        var list2 = array2.ToListNode();
        var expectedResult = expectedResultArray.ToListNode();

        // Act
        var actualResult = MergeTwoSortedLists.GetResult(list1, list2);

        // Assert
        AssertExtensions.AssertListNode(expectedResult, actualResult);
    }
}