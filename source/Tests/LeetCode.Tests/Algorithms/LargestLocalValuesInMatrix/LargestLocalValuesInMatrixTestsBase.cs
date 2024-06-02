// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.LargestLocalValuesInMatrix;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.LargestLocalValuesInMatrix;

public abstract class LargestLocalValuesInMatrixTestsBase<T> where T : ILargestLocalValuesInMatrix, new()
{
    [TestMethod]
    [DataRow("[[9,9,8,1],[5,6,2,6],[8,2,6,4],[6,2,2,2]]", "[[9,9],[8,6]]")]
    [DataRow("[[1,1,1,1,1],[1,1,1,1,1],[1,1,2,1,1],[1,1,1,1,1],[1,1,1,1,1]]", "[[2,2,2],[2,2,2],[2,2,2]]")]
    public void LargestLocal_WithGridJsonArray_ReturnsExpectedMaxLocalGrid(string gridJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var grid = JsonHelper<int>.JsonArrayToJaggedArray(gridJsonArray);
        var expectedResult = JsonHelper<int>.JsonArrayToJaggedArray(expectedResultJsonArray);

        // Act
        var actualResult = solution.LargestLocal(grid);

        // Assert
        JaggedArrayAssert.ArrayEqual(expectedResult, actualResult);
    }
}