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

using LeetCode.Algorithms.StudentAttendanceRecord1;

namespace LeetCode.Tests.Algorithms.StudentAttendanceRecord1;

public abstract class StudentAttendanceRecord1TestsBase<T> where T : IStudentAttendanceRecord1, new()
{
    [TestMethod]
    [DataRow("PPALLP", true)]
    [DataRow("PPALLL", false)]
    [DataRow("P", true)]
    [DataRow("A", true)]
    [DataRow("L", true)]
    [DataRow("AA", false)]
    [DataRow("LLL", false)]
    [DataRow("PPPP", true)]
    [DataRow("PPAP", true)]
    [DataRow("PPAPP", true)]
    [DataRow("APAPL", false)]
    [DataRow("PLPLPL", true)]
    [DataRow("LLLPP", false)]
    [DataRow("PLLP", true)]
    [DataRow("PLLL", false)]
    [DataRow("APLLL", false)]
    [DataRow("PPPPLL", true)]
    [DataRow("PPLPLL", true)]
    [DataRow("PPPLLP", true)]
    [DataRow("PLLPLL", true)]
    public void CheckRecord_WithAttendanceString_ReturnsTrueIfEligible(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckRecord(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}