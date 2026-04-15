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

namespace LeetCode.Algorithms.WalkingRobotSimulation2;

/// <inheritdoc />
public sealed class WalkingRobotSimulation2Simulation : IWalkingRobotSimulation2
{
    public const string EastDirection = "East";
    public const string NorthDirection = "North";
    public const string WestDirection = "West";
    public const string SouthDirection = "South";

    private readonly int _height;
    private readonly int _perimeter;
    private readonly int _width;
    private bool _hasMoved;
    private int _position;

    /// <summary>
    ///     Initializes a new instance of the <see cref="WalkingRobotSimulation2Simulation" /> class.
    /// </summary>
    /// <param name="width">The width of the grid.</param>
    /// <param name="height">The height of the grid.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public WalkingRobotSimulation2Simulation(int width, int height)
    {
        _width = width;
        _height = height;
        _perimeter = CalculatePerimeter(width, height);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Step(int num)
    {
        if (num == 0)
        {
            return;
        }

        _hasMoved = true;
        _position = (_position + (num % _perimeter)) % _perimeter;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] GetPos()
    {
        if (_position < _width)
        {
            return [_position, 0];
        }

        if (_position < _width + _height - 1)
        {
            return [_width - 1, _position - (_width - 1)];
        }

        if (_position < (2 * _width) + _height - 2)
        {
            return
            [
                _width - 1 - (_position - (_width + _height - 2)),
                _height - 1
            ];
        }

        return
        [
            0,
            _height - 1 - (_position - ((2 * _width) + _height - 3))
        ];
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public string GetDir()
    {
        var direction = GetDirection();

        return direction switch
        {
            Direction.East => EastDirection,
            Direction.North => NorthDirection,
            Direction.West => WestDirection,
            Direction.South => SouthDirection,
            _ => EastDirection
        };
    }

    /// <summary>
    ///     Calculates the perimeter of the grid, excluding corners counted twice.
    /// </summary>
    /// <param name="width">The width of the grid.</param>
    /// <param name="height">The height of the grid.</param>
    /// <returns>The number of distinct perimeter positions.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int CalculatePerimeter(int width, int height)
    {
        return ((width + height) * 2) - 4;
    }

    /// <summary>
    ///     Determines the current facing direction based on the robot's position on the perimeter.
    /// </summary>
    /// <returns>The current <see cref="Direction" /> the robot is facing.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private Direction GetDirection()
    {
        if (!_hasMoved)
        {
            return Direction.East;
        }

        if (_position == 0)
        {
            return Direction.South;
        }

        if (_position < _width)
        {
            return Direction.East;
        }

        if (_position < _width + _height - 1)
        {
            return Direction.North;
        }

        if (_position < (2 * _width) + _height - 2)
        {
            return Direction.West;
        }

        return Direction.South;
    }

    private enum Direction
    {
        East,
        North,
        West,
        South
    }
}