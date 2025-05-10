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

using LeetCode.Algorithms.CheckIfGridCanBeCutIntoSections;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfGridCanBeCutIntoSections;

public abstract class CheckIfGridCanBeCutIntoSectionsTestsBase<T> where T : ICheckIfGridCanBeCutIntoSections, new()
{
    [TestMethod]
    [DataRow(5, "[[1,0,5,2],[0,2,2,4],[3,2,5,3],[0,4,4,5]]", true)]
    [DataRow(4, "[[0,0,1,1],[2,0,3,4],[0,2,2,3],[3,0,4,3]]", true)]
    [DataRow(4, "[[0,2,2,4],[1,0,3,2],[2,2,3,4],[3,0,4,2],[3,2,4,4]]", false)]
    public void CheckValidCuts_WithGridSizeAndRectangles_ReturnsWhetherGridCanBeCutIntoSections(int n,
        string rectanglesJson, bool expectedResult)
    {
        // Arrange
        var rectangles = JsonHelper<int>.DeserializeToJaggedArray(rectanglesJson);

        var solution = new T();

        // Act
        var actualResult = solution.CheckValidCuts(n, rectangles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}