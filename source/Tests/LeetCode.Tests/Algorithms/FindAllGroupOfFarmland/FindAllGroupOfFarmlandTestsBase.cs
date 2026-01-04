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

using LeetCode.Algorithms.FindAllGroupOfFarmland;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.FindAllGroupOfFarmland;

public abstract class FindAllGroupOfFarmlandTestsBase<T> where T : IFindAllGroupOfFarmland, new()
{
    [TestMethod]
    [DataRow("[[0]]", "[]")]
    [DataRow("[[1,1],[0,0]]", "[[0,0,0,1]]")]
    [DataRow("[[1,1],[1,1]]", "[[0,0,1,1]]")]
    [DataRow("[[0,1],[0,1]]", "[[0,1,1,1]]")]
    [DataRow("[[1,0,0],[0,1,1],[0,1,1]]", "[[0,0,0,0],[1,1,2,2]]")]
    [DataRow("[[0,0,0,0,0],[0,1,1,1,0],[0,1,1,1,0],[0,1,1,1,0],[0,0,0,0,0]]", "[[1,1,3,3]]")]
    public void FindFarmland_WithLandGridInput_ReturnsTopLeftAndBottomRightCoordinatesOfFarmlandGroups(string landJson,
        string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonHelper<int[][]>.Parse(expectedResultJson);

        var solution = new T();

        var land = JsonHelper<int[][]>.Parse(landJson);

        // Act
        var actualResult = solution.FindFarmland(land);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }
}