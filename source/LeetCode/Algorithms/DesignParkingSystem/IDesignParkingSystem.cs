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

namespace LeetCode.Algorithms.DesignParkingSystem;

/// <summary>
///     https://leetcode.com/problems/design-parking-system/description/
/// </summary>
public interface IDesignParkingSystem
{
    /// <summary>
    ///     Attempts to park a car of the given type into a parking space of the matching size.
    /// </summary>
    /// <param name="carType">The type of the car: 1 for big, 2 for medium, or 3 for small.</param>
    /// <returns><c>true</c> if there is an available parking space of the matching type; otherwise, <c>false</c>.</returns>
    bool AddCar(int carType);
}