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

using LeetCode.Algorithms.ConvertTheTemperature;

namespace LeetCode.Tests.Algorithms.ConvertTheTemperature;

public abstract class ConvertTheTemperatureTestsBase<T> where T : IConvertTheTemperature, new()
{
    [TestMethod]
    [DataRow(36.50, new[] { 309.65000, 97.70000 })]
    [DataRow(122.11, new[] { 395.26000, 251.79800 })]
    public void ConvertTemperature_GivenCelsius_ReturnsExpectedTemperatureArray(double celsius, double[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConvertTemperature(celsius);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}