// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MaximumXORForEachQuery;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumXORForEachQuery;

public abstract class MaximumXORForEachQueryTestsBase<T> where T : IMaximumXORForEachQuery, new()
{
    [TestMethod]
    [DataRow("[0,1,1,3]", 2, "[0,3,2,3]")]
    [DataRow("[2,3,4,7]", 3, "[5,2,6,5]")]
    [DataRow("[0,1,2,2,5,7]", 3, "[4,3,6,4,6,7]")]
    public void GetMaximumXor_WithNumsArrayAndMaximumBit_ComputesXorValues(string numsJsonArray, int maximumBit,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetMaximumXor(nums, maximumBit);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}