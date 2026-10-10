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
    [DataRow(0, new[] { 273.15d, 32.0d })]
    [DataRow(1.5, new[] { 274.65d, 34.70d })]
    [DataRow(100, new[] { 373.15d, 212.0d })]
    [DataRow(25, new[] { 298.15d, 77.0d })]
    [DataRow(50.5, new[] { 323.65d, 122.90d })]
    [DataRow(200.25, new[] { 473.40d, 392.450d })]
    [DataRow(360.99, new[] { 634.14d, 681.782d })]
    [DataRow(10, new[] { 283.15d, 50.0d })]
    [DataRow(99.99, new[] { 373.14d, 211.982d })]
    [DataRow(5.55, new[] { 278.70d, 41.990d })]
    [DataRow(300, new[] { 573.15d, 572.0d })]
    [DataRow(150.75, new[] { 423.90d, 303.350d })]
    [DataRow(88.8, new[] { 361.95d, 191.84d })]
    [DataRow(250, new[] { 523.15d, 482.0d })]
    [DataRow(20, new[] { 293.15d, 68.0d })]
    [DataRow(15, new[] { 288.15d, 59.0d })]
    [DataRow(40, new[] { 313.15d, 104.0d })]
    [DataRow(30, new[] { 303.15d, 86.0d })]
    [DataRow(45, new[] { 318.15d, 113.0d })]
    [DataRow(60, new[] { 333.15d, 140.0d })]
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