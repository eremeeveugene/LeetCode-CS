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

using LeetCode.Algorithms.MinimumTimeDifference;

namespace LeetCode.Tests.Algorithms.MinimumTimeDifference;

public abstract class MinimumTimeDifferenceTestsBase<T> where T : IMinimumTimeDifference, new()
{
    [TestMethod]
    [DataRow(new[] { "00:00", "23:59", "00:00" }, 0)]
    [DataRow(new[] { "23:59", "00:00" }, 1)]
    [DataRow(new[] { "00:00", "12:00" }, 720)]
    [DataRow(new[] { "23:30", "00:10" }, 40)]
    [DataRow(new[] { "00:00", "12:00", "23:59" }, 1)]
    [DataRow(new[] { "02:45", "11:15", "18:30", "23:55" }, 170)]
    [DataRow(new[] { "00:00", "12:34", "23:59", "03:21", "16:45", "07:30", "20:15", "22:22" }, 1)]
    [DataRow(new[] { "01:01", "01:01" }, 0)]
    [DataRow(new[] { "12:00", "12:01" }, 1)]
    [DataRow(new[] { "05:31", "22:08" }, 443)]
    [DataRow(new[] { "00:00", "06:00", "12:00", "18:00" }, 360)]
    [DataRow(new[] { "10:00", "10:30", "11:00" }, 30)]
    [DataRow(new[] { "23:00", "01:00" }, 120)]
    [DataRow(new[] { "00:01", "23:58" }, 3)]
    [DataRow(new[] { "04:20", "16:20" }, 720)]
    [DataRow(new[] { "13:07", "05:49", "20:23" }, 436)]
    [DataRow(new[] { "09:15", "09:45", "10:15", "10:44" }, 29)]
    [DataRow(new[] { "22:50", "23:40", "00:25" }, 45)]
    [DataRow(new[] { "06:06", "06:07", "06:09" }, 1)]
    [DataRow(new[] { "03:33", "15:33", "21:33" }, 360)]
    [DataRow(new[] { "00:30", "23:30" }, 60)]
    [DynamicData(nameof(GetTestData))]
    public void FindMinDifference_GivenTimePoints_ReturnsMinimumDifference(string[] timePoints, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMinDifference(timePoints);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        var timePoints = new string[(60 * 24) + 1];

        for (var i = 0; i < timePoints.Length; i++)
        {
            timePoints[i] = $"{i / 60 % 24:D2}:{i % 60:D2}";
        }

        yield return [timePoints, 0];
    }
}