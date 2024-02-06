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

using LeetCode.Algorithms.DefangingAnIPAddress;

namespace LeetCode.Tests.Algorithms.DefangingAnIPAddress;

public abstract class DefangingAnIPAddressTestsBase<T> where T : IDefangingAnIPAddress, new()
{
    [TestMethod]
    [DataRow("1.1.1.1", "1[.]1[.]1[.]1")]
    [DataRow("255.100.50.0", "255[.]100[.]50[.]0")]
    public void DefangIPaddr_WithValidIpAddress_ReturnsDefangedVersion(string address, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DefangIPaddr(address);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}