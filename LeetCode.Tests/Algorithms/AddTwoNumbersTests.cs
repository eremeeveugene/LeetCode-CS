using LeetCode.Algorithms.AddTwoNumbersTask;
using LeetCode.Core.Extensions;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class AddTwoNumbersTests
{
    [TestMethod]
    [DataRow(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    [DataRow(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [DataRow(new[] { 9 }, new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    public void Test(int[] array1, int[] array2, int[] expectedResultArray)
    {
        // Arrange
        var list1 = array1.ToListNode();
        var list2 = array2.ToListNode();
        var expectedResultList = expectedResultArray.ToListNode();

        // Act
        var actualResultList = AddTwoNumbers.GetResult(list1, list2);

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
}