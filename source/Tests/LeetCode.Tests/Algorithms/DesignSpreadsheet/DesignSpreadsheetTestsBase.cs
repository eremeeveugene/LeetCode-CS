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

using LeetCode.Algorithms.DesignSpreadsheet;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignSpreadsheet;

public abstract class DesignSpreadsheetTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignSpreadsheet_WithMixedOperations_ProcessesOperationsAccordingToSpecification(SpreadsheetScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Rows);

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
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    protected abstract IDesignSpreadsheet GetSolution(int rows);

    private static IEnumerable<SpreadsheetScenario[]> GetScenarios()
    {
        yield return
        [
            new SpreadsheetScenario(
                3,
                [
                    new GetValueOperation("=5+7"),
                    new SetCellOperation("A1", 10),
                    new GetValueOperation("=A1+6"),
                    new SetCellOperation("B2", 15),
                    new GetValueOperation("=A1+B2"),
                    new ResetCellOperation("A1"),
                    new GetValueOperation("=A1+B2")
                ],
                [
                    new GetValueOperation.Result(12),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(16),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(25),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(15)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                1,
                [new GetValueOperation("=1+2"), new GetValueOperation("=10+20")],
                [new GetValueOperation.Result(3), new GetValueOperation.Result(30)])
        ];

        yield return
        [
            new SpreadsheetScenario(
                2,
                [new SetCellOperation("A1", 42), new GetValueOperation("=A1+0"), new ResetCellOperation("A1"), new GetValueOperation("=A1+0")],
                [VoidOperationResult.Instance, new GetValueOperation.Result(42), VoidOperationResult.Instance, new GetValueOperation.Result(0)])
        ];

        yield return
        [
            new SpreadsheetScenario(
                3,
                [new SetCellOperation("A1", 5), new SetCellOperation("B1", 10), new GetValueOperation("=A1+B1")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetValueOperation.Result(15)])
        ];

        yield return
        [
            new SpreadsheetScenario(
                2,
                [new SetCellOperation("A1", 3), new GetValueOperation("=A1+7"), new SetCellOperation("A1", 10), new GetValueOperation("=A1+7")],
                [VoidOperationResult.Instance, new GetValueOperation.Result(10), VoidOperationResult.Instance, new GetValueOperation.Result(17)])
        ];
    }

    public sealed class SpreadsheetScenario : IScenario<IDesignSpreadsheet>
    {
        public SpreadsheetScenario(int rows, IOperation<IDesignSpreadsheet>[] operations, IOperationResult[] operationResults)
        {
            Rows = rows;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int Rows { get; }

        public IOperation<IDesignSpreadsheet>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class SetCellOperation : IOperation<IDesignSpreadsheet>
    {
        private readonly string _cell;
        private readonly int _value;

        public SetCellOperation(string cell, int value)
        {
            _cell = cell;
            _value = value;
        }

        public IOperationResult Execute(IDesignSpreadsheet designSpreadsheet)
        {
            designSpreadsheet.SetCell(_cell, _value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class ResetCellOperation : IOperation<IDesignSpreadsheet>
    {
        private readonly string _cell;

        public ResetCellOperation(string cell)
        {
            _cell = cell;
        }

        public IOperationResult Execute(IDesignSpreadsheet designSpreadsheet)
        {
            designSpreadsheet.ResetCell(_cell);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetValueOperation : IOperation<IDesignSpreadsheet>
    {
        private readonly string _formula;

        public GetValueOperation(string formula)
        {
            _formula = formula;
        }

        public IOperationResult Execute(IDesignSpreadsheet designSpreadsheet)
        {
            var value = designSpreadsheet.GetValue(_formula);

            return new Result(value);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }
}