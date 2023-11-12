using LeetCode.Algorithms.RemoveElementTask;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class RemoveElementTests
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2, 3, 3 }, 2)]
    [DataRow(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 3, 0, 4, 2, 2, 2 }, 5)]
    public void RemoveElement_GetResult_ShouldRemoveSpecifiedValueAndUpdateArrayLength(int[] actualNums, int val,
        int[] expectedNums, int expectedResult)
    {
        // Act
        var actualResult = RemoveElement.GetResult(actualNums, val);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        CollectionAssert.AreEqual(expectedNums, actualNums);
    }
}