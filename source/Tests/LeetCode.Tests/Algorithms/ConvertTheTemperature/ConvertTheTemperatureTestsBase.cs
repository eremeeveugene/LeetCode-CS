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

using LeetCode.Algorithms.ConvertTheTemperature;

namespace LeetCode.Tests.Algorithms.ConvertTheTemperature;

public abstract class ConvertTheTemperatureTestsBase<T> where T : IConvertTheTemperature, new()
{
    [TestMethod]
    [DataRow(36.50, new[] { 309.65000d, 97.70000d })]
    [DataRow(122.11, new[] { 395.26000d, 251.79800d })]
    public void ConvertTemperature_WithCelsiusInput_ReturnsKelvinAndFahrenheitValues(double celsius, double[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConvertTemperature(celsius);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}