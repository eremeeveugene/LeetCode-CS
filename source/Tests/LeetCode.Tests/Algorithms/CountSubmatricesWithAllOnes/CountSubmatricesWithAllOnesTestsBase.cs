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

using LeetCode.Algorithms.CountSubmatricesWithAllOnes;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountSubmatricesWithAllOnes;

public abstract class CountSubmatricesWithAllOnesTestsBase<T> where T : ICountSubmatricesWithAllOnes, new()
{
    [TestMethod]
    [DataRow("[[1,0,1],[1,1,0],[1,1,0]]", 13)]
    [DataRow("[[0,1,1,0],[0,1,1,1],[1,1,1,0]]", 24)]
    public void NumSubmat_WithBinaryMatrix_ReturnsCountOfAllOneSubmatrices(string matJson, int expectedResult)
    {
        // Arrange
        var mat = JsonHelper<int[][]>.Parse(matJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumSubmat(mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}