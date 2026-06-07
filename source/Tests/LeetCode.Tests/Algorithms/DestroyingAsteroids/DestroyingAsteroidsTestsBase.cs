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

using LeetCode.Algorithms.DestroyingAsteroids;

namespace LeetCode.Tests.Algorithms.DestroyingAsteroids;

public abstract class DestroyingAsteroidsTestsBase<T> where T : IDestroyingAsteroids, new()
{
    [TestMethod]
    [DataRow(10, new[] { 3, 9, 19, 5, 21 }, true)]
    [DataRow(5, new[] { 4, 9, 23, 4 }, false)]
    [DataRow(1, new[] { 1 }, true)]
    [DataRow(1, new[] { 2 }, false)]
    [DataRow(5, new[] { 5 }, true)]
    [DataRow(1, new[] { 1, 1, 1, 1, 1 }, true)]
    [DataRow(1, new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(1, new[] { 2, 3 }, false)]
    [DataRow(3, new[] { 4, 5, 6 }, false)]
    [DataRow(100, new[] { 100, 100, 100 }, true)]
    [DataRow(1, new[] { 1, 2, 4, 8, 16, 32 }, true)]
    [DataRow(2, new[] { 3, 4, 5 }, false)]
    [DataRow(3, new[] { 3, 6, 12 }, true)]
    [DataRow(99999, new[] { 100000 }, false)]
    [DataRow(100000, new[] { 100000, 100000, 100000 }, true)]
    [DataRow(1, new[] { 100000 }, false)]
    [DataRow(1, new[] { 1, 1, 100000 }, false)]
    [DataRow(10, new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(100, new[] { 50, 50, 50, 50, 50 }, true)]
    [DataRow(50, new[] { 50, 50, 50, 50, 50 }, true)]
    [DataRow(49, new[] { 50, 50, 50 }, false)]
    [DataRow(3, new[] { 1, 2, 4, 8, 16 }, true)]
    [DataRow(5, new[] { 10, 1, 2, 3, 4 }, true)]
    public void AsteroidsDestroyed_WithMassAndAsteroids_ReturnsWhetherAllCanBeDestroyed(int mass, int[] asteroids, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AsteroidsDestroyed(mass, asteroids);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}