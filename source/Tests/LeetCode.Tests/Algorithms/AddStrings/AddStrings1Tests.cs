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
using LeetCode.Algorithms.MissingNumber;

namespace LeetCode.Tests.Algorithms.AddStrings;

[TestClass]
public class AddStrings1Tests
{
    [TestMethod]
    [DataRow("0", "0", "0")]
    [DataRow("11", "123", "134")]
    [DataRow("456", "77", "533")]
    [DataRow("3876620623801494171", "6529364523802684779", "10405985147604178950")]
    public void Test(string num1, string num2, string expectedResult)
    {
        // Act
        var actualResult = AddStrings1.GetResult(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}