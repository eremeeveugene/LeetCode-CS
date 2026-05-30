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

using LeetCode.Algorithms.WalkingRobotSimulation2;
using LeetCode.Tests.Base.Scenarios;
using System.Collections;

namespace LeetCode.Tests.Algorithms.WalkingRobotSimulation2;

public abstract class WalkingRobotSimulation2TestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void WalkingRobotSimulation2_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        WalkingRobotSimulation2Scenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = CreateSolution(scenario.Width, scenario.Height);

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult, OperationResultComparer.Instance);
    }

    protected abstract IWalkingRobotSimulation2 CreateSolution(int width, int height);

    private static IEnumerable<WalkingRobotSimulation2Scenario[]> GetScenarios()
    {
        yield return
        [
            new WalkingRobotSimulation2Scenario(
                6,
                3,
                [
                    new GetPosOperation(),
                    new GetDirOperation(),
                    new StepOperation(2),
                    new GetPosOperation(),
                    new GetDirOperation(),
                    new StepOperation(2),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    new GetPosOperation.Result(0, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.EastDirection),
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(2, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.EastDirection),
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(4, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.EastDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                6,
                3,
                [
                    new StepOperation(8),
                    new GetPosOperation(),
                    new GetDirOperation(),
                    new StepOperation(1),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(4, 2),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.WestDirection),
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(3, 2),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.WestDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                3,
                3,
                [
                    new StepOperation(4),
                    new GetPosOperation(),
                    new GetDirOperation(),
                    new StepOperation(2),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(2, 2),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.NorthDirection),
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 2),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.WestDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                3,
                2,
                [
                    new StepOperation(5),
                    new GetPosOperation(),
                    new GetDirOperation(),
                    new StepOperation(1),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 1),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.WestDirection),
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.SouthDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                2,
                [
                    new StepOperation(6),
                    new GetPosOperation(),
                    new GetDirOperation(),
                    new StepOperation(6),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(1, 1),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.WestDirection),
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(3, 1),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.NorthDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(10),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.SouthDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(20),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.SouthDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(0),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.EastDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(3),
                    new StepOperation(0),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(3, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.EastDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(7),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(1, 2),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.WestDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(3),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(3, 0),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.EastDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(4),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(3, 1),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.NorthDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(8),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 2),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.WestDirection)
                ])
        ];

        yield return
        [
            new WalkingRobotSimulation2Scenario(
                4,
                3,
                [
                    new StepOperation(9),
                    new GetPosOperation(),
                    new GetDirOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    new GetPosOperation.Result(0, 1),
                    new GetDirOperation.Result(WalkingRobotSimulation2Simulation.SouthDirection)
                ])
        ];
    }

    public sealed class WalkingRobotSimulation2Scenario : IScenario<IWalkingRobotSimulation2>
    {
        public WalkingRobotSimulation2Scenario(
            int width,
            int height,
            IOperation<IWalkingRobotSimulation2>[] operations,
            IOperationResult[] operationResults)
        {
            Width = width;
            Height = height;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int Width { get; }
        public int Height { get; }

        public IOperation<IWalkingRobotSimulation2>[] Operations { get; }
        public IOperationResult[] OperationResults { get; }
    }

    private sealed class OperationResultComparer : IComparer
    {
        public static readonly OperationResultComparer Instance = new();

        public int Compare(object? x, object? y)
        {
            return Equals(x, y) ? 0 : -1;
        }
    }

    private sealed class StepOperation : IOperation<IWalkingRobotSimulation2>
    {
        private readonly int _num;

        public StepOperation(int num)
        {
            _num = num;
        }

        public IOperationResult Execute(IWalkingRobotSimulation2 walkingRobotSimulation2)
        {
            walkingRobotSimulation2.Step(_num);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetPosOperation : IOperation<IWalkingRobotSimulation2>
    {
        public IOperationResult Execute(IWalkingRobotSimulation2 walkingRobotSimulation2)
        {
            var pos = walkingRobotSimulation2.GetPos();

            return new Result(pos[0], pos[1]);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly int _x;
            private readonly int _y;

            public Result(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public bool Equals(Result? other)
            {
                return other is not null &&
                       _x == other._x &&
                       _y == other._y;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_x, _y);
            }

            public override string ToString()
            {
                return $"{nameof(GetPosOperation)}({_x}, {_y})";
            }
        }
    }

    private sealed class GetDirOperation : IOperation<IWalkingRobotSimulation2>
    {
        public IOperationResult Execute(IWalkingRobotSimulation2 walkingRobotSimulation2)
        {
            var dir = walkingRobotSimulation2.GetDir();

            return new Result(dir);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly string _direction;

            public Result(string direction)
            {
                _direction = direction;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _direction == other._direction;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_direction);
            }

            public override string ToString()
            {
                return $"{nameof(GetDirOperation)}({_direction})";
            }
        }
    }
}