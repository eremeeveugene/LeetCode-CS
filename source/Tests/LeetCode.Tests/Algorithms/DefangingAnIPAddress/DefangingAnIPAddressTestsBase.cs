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

using LeetCode.Algorithms.DefangingAnIPAddress;

namespace LeetCode.Tests.Algorithms.DefangingAnIPAddress;

public abstract class DefangingAnIPAddressTestsBase<T> where T : IDefangingAnIPAddress, new()
{
    [TestMethod]
    [DataRow("1.1.1.1", "1[.]1[.]1[.]1")]
    [DataRow("255.100.50.0", "255[.]100[.]50[.]0")]
    [DataRow("0.0.0.0", "0[.]0[.]0[.]0")]
    [DataRow("255.255.255.255", "255[.]255[.]255[.]255")]
    [DataRow("1.2.3.4", "1[.]2[.]3[.]4")]
    [DataRow("192.168.0.1", "192[.]168[.]0[.]1")]
    [DataRow("10.0.0.255", "10[.]0[.]0[.]255")]
    [DataRow("127.0.0.1", "127[.]0[.]0[.]1")]
    [DataRow("8.8.8.8", "8[.]8[.]8[.]8")]
    [DataRow("172.16.254.1", "172[.]16[.]254[.]1")]
    [DataRow("100.200.30.4", "100[.]200[.]30[.]4")]
    [DataRow("1.10.100.255", "1[.]10[.]100[.]255")]
    [DataRow("123.45.67.89", "123[.]45[.]67[.]89")]
    [DataRow("0.1.0.1", "0[.]1[.]0[.]1")]
    [DataRow("9.99.9.99", "9[.]99[.]9[.]99")]
    [DataRow("224.0.0.251", "224[.]0[.]0[.]251")]
    [DataRow("203.0.113.7", "203[.]0[.]113[.]7")]
    [DataRow("66.249.64.12", "66[.]249[.]64[.]12")]
    [DataRow("11.22.33.44", "11[.]22[.]33[.]44")]
    [DataRow("5.6.7.8", "5[.]6[.]7[.]8")]
    [DataRow("250.250.250.250", "250[.]250[.]250[.]250")]
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