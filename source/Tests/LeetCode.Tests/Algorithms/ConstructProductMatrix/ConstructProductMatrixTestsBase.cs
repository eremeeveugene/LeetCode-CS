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

using LeetCode.Algorithms.ConstructProductMatrix;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ConstructProductMatrix;

public abstract class ConstructProductMatrixTestsBase<T> where T : IConstructProductMatrix, new()
{
    [TestMethod]
    [DataRow("[[1,2],[3,4]]", "[[24,12],[8,6]]")]
    [DataRow("[[12345],[2],[1]]", "[[2],[0],[0]]")]
    public void ConstructProductMatrix_WithValidGrid_ReturnsProductOfAllOtherElementsModulo(string gridJson,
        string expectedResultJson)
    {
        // Arrange
        var grid = JsonHelper<int[][]>.Parse(gridJson);
        var expectedResult = JsonHelper<int[][]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ConstructProductMatrix(grid);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}