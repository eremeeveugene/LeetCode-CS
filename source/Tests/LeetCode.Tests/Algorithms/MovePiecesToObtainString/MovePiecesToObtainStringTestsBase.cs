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

using LeetCode.Algorithms.MovePiecesToObtainString;

namespace LeetCode.Tests.Algorithms.MovePiecesToObtainString;

public abstract class MovePiecesToObtainStringTestsBase<T> where T : IMovePiecesToObtainString, new()
{
    [TestMethod]
    [DataRow("_L__R__R_", "L______RR", true)]
    [DataRow("R_L_", "__LR", false)]
    [DataRow("_R", "R_", false)]
    [DataRow("_", "_", true)]
    [DataRow("L", "L", true)]
    [DataRow("R", "R", true)]
    [DataRow("LR", "LR", true)]
    [DataRow("RL", "RL", true)]
    [DataRow("L_", "_L", false)]
    [DataRow("_L", "L_", true)]
    [DataRow("R_", "_R", true)]
    [DataRow("_R", "_R", true)]
    [DataRow("LL", "LL", true)]
    [DataRow("RR", "RR", true)]
    [DataRow("_LL", "LL_", true)]
    [DataRow("LL_", "_LL", false)]
    [DataRow("_RR", "RR_", false)]
    [DataRow("RR_", "_RR", true)]
    [DataRow("L_R", "L_R", true)]
    [DataRow("LR__", "_LR_", false)]
    public void CanChange_WithStartAndTargetStrings_ReturnsIfTransformationIsPossible(string start, string target, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanChange(start, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}