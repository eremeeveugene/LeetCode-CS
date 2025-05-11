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

using LeetCode.Algorithms.TransformedArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TransformedArray;

public abstract class TransformedArrayTestsBase<T> where T : ITransformedArray, new()
{
    [TestMethod]
    [DataRow("[3,-2,1,1]", "[1,1,1,3]")]
    [DataRow("[-1,4,-1]", "[-1,-1,4]")]
    [DataRow("[-10]", "[-10]")]
    public void ConstructTransformedArray_WithInputArray_ReturnsTransformedArray(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ConstructTransformedArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}