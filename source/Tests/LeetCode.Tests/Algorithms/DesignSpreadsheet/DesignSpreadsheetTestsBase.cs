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

        yield return
        [
            new SpreadsheetScenario(
                1,
                [
                    new GetValueOperation("=0+0"),
                    new GetValueOperation("=100000+100000")
                ],
                [
                    new GetValueOperation.Result(0),
                    new GetValueOperation.Result(200000)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                1000,
                [
                    new SetCellOperation("Z1000", 100000),
                    new GetValueOperation("=Z1000+Z1000"),
                    new ResetCellOperation("Z1000"),
                    new GetValueOperation("=Z1000+1")
                ],
                [
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(200000),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(1)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                5,
                [
                    new GetValueOperation("=A1+B1"),
                    new SetCellOperation("A1", 1),
                    new GetValueOperation("=A1+B1"),
                    new SetCellOperation("B1", 2),
                    new GetValueOperation("=A1+B1")
                ],
                [
                    new GetValueOperation.Result(0),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(3)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                2,
                [
                    new SetCellOperation("C2", 7),
                    new SetCellOperation("C2", 9),
                    new GetValueOperation("=C2+C2"),
                    new ResetCellOperation("C2"),
                    new ResetCellOperation("C2"),
                    new GetValueOperation("=C2+C2")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(18),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(0)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                26,
                [
                    new SetCellOperation("A26", 1),
                    new SetCellOperation("Z26", 2),
                    new GetValueOperation("=A26+Z26"),
                    new GetValueOperation("=26+Z26")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(3),
                    new GetValueOperation.Result(28)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                3,
                [
                    new ResetCellOperation("A1"),
                    new GetValueOperation("=A1+A1"),
                    new GetValueOperation("=0+A1")
                ],
                [
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(0),
                    new GetValueOperation.Result(0)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                4,
                [
                    new SetCellOperation("B3", 50),
                    new GetValueOperation("=B3+B3"),
                    new SetCellOperation("B3", 0),
                    new GetValueOperation("=B3+99999")
                ],
                [
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(100),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(99999)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                100,
                [
                    new SetCellOperation("E89", 14838),
                    new GetValueOperation("=E89+D95"),
                    new GetValueOperation("=E89+E89"),
                    new ResetCellOperation("E89"),
                    new SetCellOperation("E89", 80992),
                    new GetValueOperation("=E89+D95")
                ],
                [
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(14838),
                    new GetValueOperation.Result(29676),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(80992)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                2,
                [
                    new SetCellOperation("Y1", 39162),
                    new SetCellOperation("E1", 54382),
                    new SetCellOperation("C2", 34578),
                    new SetCellOperation("E1", 39499),
                    new GetValueOperation("=78116+44288"),
                    new SetCellOperation("E1", 46576)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(122404),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                3,
                [
                    new SetCellOperation("X2", 52991),
                    new SetCellOperation("C1", 47996),
                    new ResetCellOperation("X3"),
                    new ResetCellOperation("X3"),
                    new SetCellOperation("E1", 15600),
                    new SetCellOperation("C1", 45138),
                    new GetValueOperation("=X2+14162")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(67153)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                100,
                [
                    new GetValueOperation("=44559+E38"),
                    new GetValueOperation("=40130+E38"),
                    new SetCellOperation("B27", 63411),
                    new SetCellOperation("E38", 10611),
                    new GetValueOperation("=53200+B27"),
                    new GetValueOperation("=E66+E38"),
                    new ResetCellOperation("B27"),
                    new SetCellOperation("A56", 95900),
                    new GetValueOperation("=82627+54240")
                ],
                [
                    new GetValueOperation.Result(44559),
                    new GetValueOperation.Result(40130),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(116611),
                    new GetValueOperation.Result(10611),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(136867)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                1,
                [
                    new GetValueOperation("=68445+D1"),
                    new GetValueOperation("=A1+E1"),
                    new SetCellOperation("D1", 69697),
                    new SetCellOperation("D1", 44365),
                    new SetCellOperation("C1", 64469),
                    new GetValueOperation("=71840+47359"),
                    new SetCellOperation("A1", 91042),
                    new GetValueOperation("=99567+A1")
                ],
                [
                    new GetValueOperation.Result(68445),
                    new GetValueOperation.Result(0),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(119199),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(190609)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                10,
                [
                    new GetValueOperation("=A8+A8"),
                    new ResetCellOperation("A8"),
                    new SetCellOperation("Y5", 47746),
                    new GetValueOperation("=69381+26037"),
                    new GetValueOperation("=62552+D5"),
                    new ResetCellOperation("E3"),
                    new GetValueOperation("=76132+55154")
                ],
                [
                    new GetValueOperation.Result(0),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(95418),
                    new GetValueOperation.Result(62552),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(131286)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                3,
                [
                    new GetValueOperation("=28709+23662"),
                    new SetCellOperation("C3", 29654),
                    new SetCellOperation("Y3", 17501),
                    new SetCellOperation("A1", 23795),
                    new ResetCellOperation("D3"),
                    new GetValueOperation("=C3+Y3"),
                    new GetValueOperation("=A1+C3"),
                    new GetValueOperation("=15083+71728")
                ],
                [
                    new GetValueOperation.Result(52371),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(47155),
                    new GetValueOperation.Result(53449),
                    new GetValueOperation.Result(86811)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                3,
                [
                    new GetValueOperation("=16929+D3"),
                    new ResetCellOperation("D1"),
                    new SetCellOperation("Y2", 73906),
                    new ResetCellOperation("D1"),
                    new SetCellOperation("A3", 46021),
                    new SetCellOperation("Y2", 14145),
                    new GetValueOperation("=80631+42656"),
                    new GetValueOperation("=Y2+64672"),
                    new GetValueOperation("=Y2+D1")
                ],
                [
                    new GetValueOperation.Result(16929),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(123287),
                    new GetValueOperation.Result(78817),
                    new GetValueOperation.Result(14145)
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                100,
                [
                    new ResetCellOperation("D54"),
                    new SetCellOperation("A41", 3116),
                    new SetCellOperation("A41", 32178),
                    new GetValueOperation("=D64+1730"),
                    new ResetCellOperation("D54"),
                    new SetCellOperation("A41", 4818),
                    new SetCellOperation("A41", 35086)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(1730),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new SpreadsheetScenario(
                2,
                [
                    new GetValueOperation("=44056+95849"),
                    new GetValueOperation("=Y1+X2"),
                    new SetCellOperation("D2", 33085),
                    new GetValueOperation("=D2+71511"),
                    new SetCellOperation("D2", 56317),
                    new ResetCellOperation("A1"),
                    new ResetCellOperation("A1")
                ],
                [
                    new GetValueOperation.Result(139905),
                    new GetValueOperation.Result(0),
                    VoidOperationResult.Instance,
                    new GetValueOperation.Result(104596),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
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