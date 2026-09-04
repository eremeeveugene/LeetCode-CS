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

using LeetCode.Algorithms.AvoidFloodInTheCity;

namespace LeetCode.Tests.Algorithms.AvoidFloodInTheCity;

public abstract class AvoidFloodInTheCityTestsBase<T> where T : IAvoidFloodInTheCity, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, true)]
    [DataRow(new[] { 1, 2, 0, 0, 2, 1 }, true)]
    [DataRow(new[] { 1, 2, 0, 1, 2 }, false)]
    [DataRow(new[] { 0 }, true)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 1, 1 }, false)]
    [DataRow(new[] { 1, 0, 1 }, true)]
    [DataRow(new[] { 0, 1, 1 }, false)]
    [DataRow(new[] { 1, 1, 0 }, false)]
    [DataRow(new[] { 0, 0, 0 }, true)]
    [DataRow(new[] { 0, 1, 2, 0 }, true)]
    [DataRow(new[] { 1, 2, 0, 2, 1 }, false)]
    [DataRow(new[] { 1, 2, 0, 2, 0, 1 }, true)]
    [DataRow(new[] { 1, 2, 0, 1, 0, 2 }, true)]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, true)]
    [DataRow(new[] { 1, 0, 1, 1 }, false)]
    [DataRow(new[] { 1, 2, 3, 0, 0, 3, 2, 1 }, false)]
    [DataRow(new[] { 1, 2, 3, 0, 0, 0, 3, 2, 1 }, true)]
    [DataRow(new[] { 1, 2, 3, 0, 1, 0, 2, 0, 3 }, true)]
    [DataRow(new[] { 1, 2, 3, 0, 2, 0, 1, 0, 3 }, true)]
    [DataRow(new[] { 1, 2, 0, 3, 0, 2, 1 }, true)]
    [DataRow(new[] { 1, 2, 0, 3, 1, 2 }, false)]
    [DataRow(new[] { 10, 20, 0, 20, 0, 10 }, true)]
    [DataRow(new[] { 1000000000, 0, 1000000000 }, true)]
    [DataRow(new[] { 1000000000, 1000000000 }, false)]
    [DataRow(new[] { 1, 2, 0, 0, 2, 1, 0, 1, 2 }, false)]
    [DataRow(new[] { 1, 2, 0, 0, 2, 1, 0, 1, 0, 2 }, true)]
    [DataRow(new[] { 0, 0, 1, 2, 1, 2 }, false)]
    [DataRow(new[] { 7, 0, 0, 0, 7 }, true)]
    [DataRow(new[] { 2, 0, 1, 2 }, true)]
    public void AvoidFlood_WithGivenRainfall_ReturnsValidDryingScheduleOrEmptyArray(int[] rains, bool canAvoidFlood)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AvoidFlood(rains);

        // Assert
        if (!canAvoidFlood)
        {
            Assert.HasCount(0, actualResult);

            return;
        }

        Assert.HasCount(rains.Length, actualResult);

        var fullLakes = new HashSet<int>();

        for (var day = 0; day < rains.Length; day++)
        {
            var lake = rains[day];

            if (lake > 0)
            {
                Assert.AreEqual(-1, actualResult[day]);
                Assert.IsTrue(fullLakes.Add(lake), $"Lake {lake} floods on day {day}.");
            }
            else
            {
                Assert.IsTrue(actualResult[day] >= 1 && actualResult[day] <= 1_000_000_000);

                fullLakes.Remove(actualResult[day]);
            }
        }
    }
}
