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

using LeetCode.Algorithms.MaximizeHappinessOfSelectedChildren;

namespace LeetCode.Tests.Algorithms.MaximizeHappinessOfSelectedChildren;

public abstract class MaximizeHappinessOfSelectedChildrenTestsBase<T>
    where T : IMaximizeHappinessOfSelectedChildren, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 2, 4)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 1)]
    [DataRow(new[] { 2, 3, 4, 5 }, 1, 5)]
    [DataRow(new[] { 12, 1, 42 }, 3, 53)]
    [DataRow(
        new[]
        {
            2135218, 73431904, 92495076, 77528042, 82824634, 3036629, 28375907, 65220365, 40948869, 58914871,
            57169530, 89783499, 19582915, 19676695, 11932465, 21770144, 49740276, 22303751, 80746555, 97391584,
            95775653, 43396943, 47271136, 43935930, 59643137, 64183008, 8892641, 39587569, 85086654, 5663585,
            82925096, 24868817, 95900395, 48155864, 74447380, 7618448, 63299623, 91141186, 33347112, 81951555,
            52867615, 92184410, 7024265, 85525916, 29846922, 59532692, 47267934, 6514603, 1137830, 97807470
        }, 41, 2517853814)]
    public void MaximumHappinessSum_WithVariousInputs_ReturnsMaximumHappinessSum(int[] happiness, int k,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumHappinessSum(happiness, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}