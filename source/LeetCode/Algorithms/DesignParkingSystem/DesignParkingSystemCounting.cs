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

/// <inheritdoc />
public sealed class DesignParkingSystemCounting : IDesignParkingSystem
{
    private readonly int _bigCapacity;
    private readonly int _mediumCapacity;
    private readonly int _smallCapacity;
    private int _bigCount;
    private int _mediumCount;
    private int _smallCount;

    /// <summary>
    ///     Initializes a new instance of the <see cref="DesignParkingSystemCounting" /> class.
    /// </summary>
    /// <param name="bigCapacity">The number of big parking slots.</param>
    /// <param name="mediumCapacity">The number of medium parking slots.</param>
    /// <param name="smallCapacity">The number of small parking slots.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public DesignParkingSystemCounting(int bigCapacity, int mediumCapacity, int smallCapacity)
    {
        _bigCapacity = bigCapacity;
        _mediumCapacity = mediumCapacity;
        _smallCapacity = smallCapacity;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool AddCar(int carType)
    {
        switch (carType)
        {
            case 1 when _bigCount == _bigCapacity:

                return false;
            case 1:
                _bigCount++;

                return true;
            case 2 when _mediumCount == _mediumCapacity:

                return false;
            case 2:
                _mediumCount++;

                return true;
            case 3 when _smallCount == _smallCapacity:

                return false;
            case 3:
                _smallCount++;

                return true;
            default:
                return false;
        }
    }
}