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

using LeetCode.Algorithms.AddStrings;

namespace LeetCode.Tests.Algorithms.AddStrings;

public abstract class AddStringsTestsBase<T> where T : IAddStrings, new()
{
    [TestMethod]
    [DataRow("0", "0", "0")]
    [DataRow("11", "123", "134")]
    [DataRow("456", "77", "533")]
    [DataRow("3876620623801494171", "6529364523802684779", "10405985147604178950")]
    public void AddStrings_WithNumericStrings_ReturnsSumAsString(string num1, string num2, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddStrings(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}