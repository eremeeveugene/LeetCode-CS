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

using LeetCode.Algorithms.NumberOfSeniorCitizens;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfSeniorCitizens;

public abstract class NumberOfSeniorCitizensTestsBase<T> where T : INumberOfSeniorCitizens, new()
{
    [TestMethod]
    [DataRow("[\"1313579440F2036\",\"2921522980M5644\"]", 0)]
    [DataRow("[\"7868190130M7522\",\"5303914400F9211\",\"9273338290F4010\"]", 2)]
    [DataRow("[\"4444444444F6030\",\"5555555555M7041\",\"6666666666O4055\",\"7777777777F6021\"]", 1)]
    [DataRow("[\"5612624052M0130\",\"5378802576M6424\",\"5447619845F0171\",\"2941701174O9078\"]", 2)]
    [DataRow("[\"9876543210M7012\",\"8765432109F8015\",\"7654321098O6013\",\"6543210987M5500\"]", 2)]
    [DataRow("[\"0000000000M9900\",\"1111111111F8801\",\"2222222222O6705\",\"3333333333M7604\"]", 4)]
    [DataRow(
        "[\"9751302862F0693\",\"3888560693F7262\",\"5485983835F0649\",\"2580974299F6042\",\"9976672161M6561\",\"0234451011F8013\",\"4294552179O6482\"]",
        4)]
    [DataRow(
        "[\"1137774788O7691\",\"7472708234O0072\",\"9885137889M8868\",\"1321925389M8161\",\"5574709492O7158\",\"2205791488F8896\",\"1537217483M5762\"]",
        5)]
    public void CountSeniors_WithDetailsArray_ReturnsCorrectSeniorCount(string detailsJsonArray, int expectedResult)
    {
        // Arrange
        var details = JsonHelper<string>.DeserializeToArray(detailsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountSeniors(details);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}