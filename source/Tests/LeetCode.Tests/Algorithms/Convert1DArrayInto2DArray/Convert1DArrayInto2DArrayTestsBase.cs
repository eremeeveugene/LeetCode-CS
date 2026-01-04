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

using LeetCode.Algorithms.Convert1DArrayInto2DArray;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.Convert1DArrayInto2DArray;

public abstract class Convert1DArrayInto2DArrayTestsBase<T> where T : IConvert1DArrayInto2DArray, new()
{
    [TestMethod]
    [DataRow("[3]", 1, 2, "[]")]
    [DataRow("[1,2]", 1, 1, "[]")]
    [DataRow("[1,2,3]", 1, 3, "[[1,2,3]]")]
    [DataRow("[1,2,3,4]", 2, 2, "[[1,2],[3,4]]")]
    public void Construct2DArray_WithOriginalArrayAndDimensions_ReturnsReshapedMatrixOrEmptyArray(string originalJson,
        int m, int n, string expectedResultJson)
    {
        // Arrange
        var original = JsonHelper<int[]>.Parse(originalJson);
        var expectedResult = JsonHelper<int[][]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.Construct2DArray(original, m, n);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }
}