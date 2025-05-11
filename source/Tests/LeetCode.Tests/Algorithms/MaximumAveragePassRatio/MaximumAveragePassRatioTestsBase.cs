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

using LeetCode.Algorithms.MaximumAveragePassRatio;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumAveragePassRatio;

public abstract class MaximumAveragePassRatioTestsBase<T> where T : IMaximumAveragePassRatio, new()
{
    [TestMethod]
    [DataRow("[[1,2],[3,5],[2,2]]", 2, 0.78333)]
    [DataRow("[[2,4],[3,9],[4,5],[2,10]]", 4, 0.53485)]
    public void MaxAverageRatio_WithClassDataAndExtraStudents_ReturnsMaximumAverageRatio(string classesJson,
        int extraStudents, double expectedResult)
    {
        // Arrange
        var classes = JsonHelper<int[][]>.Parse(classesJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxAverageRatio(classes, extraStudents);

        // Assert
        Assert.AreEqual(expectedResult, Math.Round(actualResult, 5));
    }
}