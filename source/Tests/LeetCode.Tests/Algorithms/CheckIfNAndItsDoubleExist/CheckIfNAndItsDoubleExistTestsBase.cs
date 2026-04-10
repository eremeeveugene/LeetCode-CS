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

using LeetCode.Algorithms.CheckIfNAndItsDoubleExist;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfNAndItsDoubleExist;

public abstract class CheckIfNAndItsDoubleExistTestsBase<T> where T : ICheckIfNAndItsDoubleExist, new()
{
    [TestMethod]
    [DataRow("[0,0]", true)]
    [DataRow("[10,2,5,3]", true)]
    [DataRow("[3,1,7,11]", false)]
    [DataRow("[-2,0,10,-19,4,6,-8]", false)]
    [DataRow("[-10,12,-20,-8,15]", true)]
    public void CheckIfExist_WithArrayInput_ReturnsTrueIfAnyValueDoublesExist(string arrJson, bool expectedResult)
    {
        // Arrange
        var arr = JsonHelper.Parse<int[]>(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.CheckIfExist(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}