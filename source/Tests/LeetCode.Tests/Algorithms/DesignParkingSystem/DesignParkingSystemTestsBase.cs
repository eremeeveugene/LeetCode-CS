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

using LeetCode.Algorithms.DesignParkingSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignParkingSystem;

public abstract class DesignParkingSystemTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignParkingSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        ParkingSystemScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.BigCapacity, scenario.MediumCapacity, scenario.SmallCapacity);

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
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignParkingSystem GetSolution(int bigCapacity, int mediumCapacity, int smallCapacity);

    private static IEnumerable<ParkingSystemScenario[]> GetScenarios()
    {
        yield return
        [
            new ParkingSystemScenario(0, 0, 0,
                [new AddCarOperation(1)],
                [new AddCarOperation.Result(false)])
        ];

        yield return
        [
            new ParkingSystemScenario(1, 0, 0,
                [new AddCarOperation(1), new AddCarOperation(1)],
                [new AddCarOperation.Result(true), new AddCarOperation.Result(false)])
        ];

        yield return
        [
            new ParkingSystemScenario(0, 1, 0,
                [new AddCarOperation(2), new AddCarOperation(2)],
                [new AddCarOperation.Result(true), new AddCarOperation.Result(false)])
        ];

        yield return
        [
            new ParkingSystemScenario(0, 0, 1,
                [new AddCarOperation(3), new AddCarOperation(3)],
                [new AddCarOperation.Result(true), new AddCarOperation.Result(false)])
        ];

        yield return
        [
            new ParkingSystemScenario(2, 2, 2,
                [
                    new AddCarOperation(1),
                    new AddCarOperation(1),
                    new AddCarOperation(2),
                    new AddCarOperation(2),
                    new AddCarOperation(3),
                    new AddCarOperation(3),
                    new AddCarOperation(1)
                ],
                [
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(false)
                ])
        ];

        yield return
        [
            new ParkingSystemScenario(1, 1, 1,
                [new AddCarOperation(3), new AddCarOperation(2), new AddCarOperation(1)],
                [
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true)
                ])
        ];

        yield return
        [
            new ParkingSystemScenario(1, 1, 1,
                [
                    new AddCarOperation(3),
                    new AddCarOperation(2),
                    new AddCarOperation(1),
                    new AddCarOperation(2)
                ],
                [
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(false)
                ])
        ];

        yield return
        [
            new ParkingSystemScenario(3, 0, 0,
                [
                    new AddCarOperation(1),
                    new AddCarOperation(1),
                    new AddCarOperation(1),
                    new AddCarOperation(1)
                ],
                [
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(false)
                ])
        ];

        yield return
        [
            new ParkingSystemScenario(0, 3, 0,
                [
                    new AddCarOperation(2),
                    new AddCarOperation(2),
                    new AddCarOperation(2),
                    new AddCarOperation(2)
                ],
                [
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(false)
                ])
        ];

        yield return
        [
            new ParkingSystemScenario(0, 0, 3,
                [
                    new AddCarOperation(3),
                    new AddCarOperation(3),
                    new AddCarOperation(3),
                    new AddCarOperation(3)
                ],
                [
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(false)
                ])
        ];

        yield return
        [
            new ParkingSystemScenario(1, 1, 1,
                [
                    new AddCarOperation(1),
                    new AddCarOperation(4),
                    new AddCarOperation(2),
                    new AddCarOperation(3)
                ],
                [
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(false),
                    new AddCarOperation.Result(true),
                    new AddCarOperation.Result(true)
                ])
        ];
    }

    public sealed class ParkingSystemScenario : Scenario<IDesignParkingSystem>
    {
        public ParkingSystemScenario(int bigCapacity, int mediumCapacity, int smallCapacity,
            IOperation<IDesignParkingSystem>[] operations, IOperationResult[] operationResults)
            : base(operations, operationResults)
        {
            BigCapacity = bigCapacity;
            MediumCapacity = mediumCapacity;
            SmallCapacity = smallCapacity;
        }

        public int BigCapacity { get; }
        public int MediumCapacity { get; }
        public int SmallCapacity { get; }
    }

    private sealed class AddCarOperation : IOperation<IDesignParkingSystem>
    {
        private readonly int _carType;

        public AddCarOperation(int carType)
        {
            _carType = carType;
        }

        public IOperationResult Execute(IDesignParkingSystem designParkingSystem)
        {
            var result = designParkingSystem.AddCar(_carType);

            return new Result(result);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }
}