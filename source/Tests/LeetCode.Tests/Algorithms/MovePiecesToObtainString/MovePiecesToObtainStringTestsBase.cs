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

using LeetCode.Algorithms.MovePiecesToObtainString;

namespace LeetCode.Tests.Algorithms.MovePiecesToObtainString;

public abstract class MovePiecesToObtainStringTestsBase<T> where T : IMovePiecesToObtainString, new()
{
    [TestMethod]
    [DataRow("_L__R__R_", "L______RR", true)]
    [DataRow("R_L_", "__LR", false)]
    [DataRow("_R", "R_", false)]
    public void CanChange_WithStartAndTargetStrings_ReturnsIfTransformationIsPossible(string start, string target,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanChange(start, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}