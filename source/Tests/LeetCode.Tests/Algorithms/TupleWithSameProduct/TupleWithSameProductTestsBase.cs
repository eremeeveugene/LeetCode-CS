// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.TupleWithSameProduct;

namespace LeetCode.Tests.Algorithms.TupleWithSameProduct;

public abstract class TupleWithSameProductTestsBase<T> where T : ITupleWithSameProduct, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 4, 6 }, 8)]
    [DataRow(new[] { 1, 2, 4, 5, 10 }, 16)]
    [DataRow(new[] { 2, 3, 4, 6, 8, 12 }, 40)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0)]
    [DataRow(new[] { 2, 3, 5, 7 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 6, 12 }, 40)]
    [DataRow(new[] { 2, 4, 8, 16 }, 8)]
    [DataRow(new[] { 1, 2, 4, 8, 16, 32 }, 56)]
    [DataRow(new[] { 3, 6, 9, 18 }, 8)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 32)]
    [DataRow(new[] { 2, 3, 6, 9, 12, 18 }, 32)]
    [DataRow(new[] { 5, 10, 20, 40, 80 }, 24)]
    [DataRow(new[] { 1, 3, 9, 27, 81, 243 }, 56)]
    [DataRow(new[] { 2, 3, 4, 6, 9, 12, 18, 27 }, 112)]
    [DataRow(new[] { 1, 10, 100, 1000, 10000 }, 24)]
    [DataRow(new[] { 12, 3, 4, 9, 36 }, 16)]
    [DynamicData(nameof(GetLargeTestData))]
    public void TupleSameProduct_GivenArrayOfNumbers_ReturnsTupleCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TupleSameProduct(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildSequence(500), 1266128];

        yield return [BuildSequence(1000), 5894072];
    }

    private static int[] BuildSequence(int length)
    {
        var nums = new int[length];

        for (var i = 0; i < length; i++)
        {
            nums[i] = i + 1;
        }

        return nums;
    }
}