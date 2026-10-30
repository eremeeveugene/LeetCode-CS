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

using LeetCode.Algorithms.DesignAnOrderedStream;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignAnOrderedStream;

public abstract class DesignAnOrderedStreamTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignAnOrderedStream_WithMixedOperations_ProcessesOperationsAccordingToSpecification(OrderedStreamScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Size);

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

    protected abstract IDesignAnOrderedStream GetSolution(int size);

    private static IEnumerable<OrderedStreamScenario[]> GetScenarios()
    {
        yield return
        [
            new OrderedStreamScenario(
                5,
                [
                    new InsertOperation(3, "ccccc"),
                    new InsertOperation(1, "aaaaa"),
                    new InsertOperation(2, "bbbbb"),
                    new InsertOperation(5, "eeeee"),
                    new InsertOperation(4, "ddddd")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["aaaaa"]),
                    new InsertOperation.Result(["bbbbb", "ccccc"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["ddddd", "eeeee"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                3,
                [new InsertOperation(1, "aaaaa"), new InsertOperation(2, "bbbbb"), new InsertOperation(3, "ccccc")],
                [
                    new InsertOperation.Result(["aaaaa"]),
                    new InsertOperation.Result(["bbbbb"]),
                    new InsertOperation.Result(["ccccc"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                3,
                [new InsertOperation(3, "ccccc"), new InsertOperation(2, "bbbbb"), new InsertOperation(1, "aaaaa")],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["aaaaa", "bbbbb", "ccccc"])
                ])
        ];

        yield return [new OrderedStreamScenario(1, [new InsertOperation(1, "aaaaa")], [new InsertOperation.Result(["aaaaa"])])];

        yield return
        [
            new OrderedStreamScenario(
                2,
                [new InsertOperation(2, "bbbbb"), new InsertOperation(1, "aaaaa")],
                [new InsertOperation.Result([]), new InsertOperation.Result(["aaaaa", "bbbbb"])])
        ];

        yield return
        [
            new OrderedStreamScenario(
                4,
                [
                    new InsertOperation(2, "bbbbb"),
                    new InsertOperation(1, "aaaaa"),
                    new InsertOperation(4, "ddddd"),
                    new InsertOperation(3, "ccccc")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["aaaaa", "bbbbb"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["ccccc", "ddddd"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                2,
                [
                    new InsertOperation(1, "dfcig"),
                    new InsertOperation(2, "efhig")
                ],
                [
                    new InsertOperation.Result(["dfcig"]),
                    new InsertOperation.Result(["efhig"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                6,
                [
                    new InsertOperation(1, "fhgea"),
                    new InsertOperation(2, "bchah"),
                    new InsertOperation(3, "bijid"),
                    new InsertOperation(4, "jjfij"),
                    new InsertOperation(5, "bccff"),
                    new InsertOperation(6, "fjedb")
                ],
                [
                    new InsertOperation.Result(["fhgea"]),
                    new InsertOperation.Result(["bchah"]),
                    new InsertOperation.Result(["bijid"]),
                    new InsertOperation.Result(["jjfij"]),
                    new InsertOperation.Result(["bccff"]),
                    new InsertOperation.Result(["fjedb"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                6,
                [
                    new InsertOperation(6, "aeaee"),
                    new InsertOperation(5, "ibhgh"),
                    new InsertOperation(4, "igddc"),
                    new InsertOperation(3, "cjafh"),
                    new InsertOperation(2, "caidg"),
                    new InsertOperation(1, "cbcgf")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["cbcgf", "caidg", "cjafh", "igddc", "ibhgh", "aeaee"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                7,
                [
                    new InsertOperation(4, "adfcf"),
                    new InsertOperation(1, "agdcg"),
                    new InsertOperation(7, "cagca"),
                    new InsertOperation(2, "bfcch"),
                    new InsertOperation(6, "ecije"),
                    new InsertOperation(3, "aecih"),
                    new InsertOperation(5, "jghjh")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["agdcg"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["bfcch"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["aecih", "adfcf"]),
                    new InsertOperation.Result(["jghjh", "ecije", "cagca"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                8,
                [
                    new InsertOperation(2, "gegcc"),
                    new InsertOperation(4, "ahcbb"),
                    new InsertOperation(6, "ghdjc"),
                    new InsertOperation(8, "ajiaa"),
                    new InsertOperation(1, "ejfdj"),
                    new InsertOperation(3, "cbgbc"),
                    new InsertOperation(5, "eceif"),
                    new InsertOperation(7, "ccgdi")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["ejfdj", "gegcc"]),
                    new InsertOperation.Result(["cbgbc", "ahcbb"]),
                    new InsertOperation.Result(["eceif", "ghdjc"]),
                    new InsertOperation.Result(["ccgdi", "ajiaa"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                8,
                [
                    new InsertOperation(8, "jfdfb"),
                    new InsertOperation(1, "ghbgj"),
                    new InsertOperation(7, "jiidb"),
                    new InsertOperation(2, "cdejf"),
                    new InsertOperation(6, "jfiee"),
                    new InsertOperation(3, "adgce"),
                    new InsertOperation(5, "bijai"),
                    new InsertOperation(4, "eiihj")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["ghbgj"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["cdejf"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["adgce"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["eiihj", "bijai", "jfiee", "jiidb", "jfdfb"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                10,
                [
                    new InsertOperation(10, "dhhge"),
                    new InsertOperation(9, "dhjje"),
                    new InsertOperation(8, "hchfj"),
                    new InsertOperation(7, "fhdba"),
                    new InsertOperation(6, "ghdgg"),
                    new InsertOperation(5, "adejg"),
                    new InsertOperation(4, "bdaag"),
                    new InsertOperation(3, "hiigg"),
                    new InsertOperation(2, "hijah"),
                    new InsertOperation(1, "fgbbb")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["fgbbb", "hijah", "hiigg", "bdaag", "adejg", "ghdgg", "fhdba", "hchfj", "dhjje", "dhhge"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                10,
                [
                    new InsertOperation(1, "jgiac"),
                    new InsertOperation(3, "bicbi"),
                    new InsertOperation(5, "cgdff"),
                    new InsertOperation(7, "fieci"),
                    new InsertOperation(9, "cghgg"),
                    new InsertOperation(2, "fdegc"),
                    new InsertOperation(4, "ejghb"),
                    new InsertOperation(6, "jdeba"),
                    new InsertOperation(8, "ddjeg"),
                    new InsertOperation(10, "hjecg")
                ],
                [
                    new InsertOperation.Result(["jgiac"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["fdegc", "bicbi"]),
                    new InsertOperation.Result(["ejghb", "cgdff"]),
                    new InsertOperation.Result(["jdeba", "fieci"]),
                    new InsertOperation.Result(["ddjeg", "cghgg"]),
                    new InsertOperation.Result(["hjecg"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                3,
                [
                    new InsertOperation(3, "ijagj"),
                    new InsertOperation(2, "affab"),
                    new InsertOperation(1, "jebdd")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["jebdd", "affab", "ijagj"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                4,
                [
                    new InsertOperation(1, "hhdai"),
                    new InsertOperation(2, "cbedh"),
                    new InsertOperation(3, "fafcc"),
                    new InsertOperation(4, "jgiae")
                ],
                [
                    new InsertOperation.Result(["hhdai"]),
                    new InsertOperation.Result(["cbedh"]),
                    new InsertOperation.Result(["fafcc"]),
                    new InsertOperation.Result(["jgiae"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                5,
                [
                    new InsertOperation(3, "jbbgd"),
                    new InsertOperation(1, "dggid"),
                    new InsertOperation(5, "ijhhf"),
                    new InsertOperation(2, "djjha"),
                    new InsertOperation(4, "cahij")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["dggid"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["djjha", "jbbgd"]),
                    new InsertOperation.Result(["cahij", "ijhhf"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                9,
                [
                    new InsertOperation(5, "hegca"),
                    new InsertOperation(2, "eabbc"),
                    new InsertOperation(8, "bfddi"),
                    new InsertOperation(3, "ibdfe"),
                    new InsertOperation(6, "bdfie"),
                    new InsertOperation(1, "cecfe"),
                    new InsertOperation(7, "gddig"),
                    new InsertOperation(4, "facaj"),
                    new InsertOperation(9, "afjic")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["cecfe", "eabbc", "ibdfe"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["facaj", "hegca", "bdfie", "gddig", "bfddi"]),
                    new InsertOperation.Result(["afjic"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                12,
                [
                    new InsertOperation(11, "gjadb"),
                    new InsertOperation(12, "diifi"),
                    new InsertOperation(8, "iehfb"),
                    new InsertOperation(5, "fcjej"),
                    new InsertOperation(7, "igddi"),
                    new InsertOperation(6, "agcci"),
                    new InsertOperation(9, "dgjcf"),
                    new InsertOperation(1, "afhhc"),
                    new InsertOperation(10, "ifjca"),
                    new InsertOperation(4, "gdhfa"),
                    new InsertOperation(3, "jijbe"),
                    new InsertOperation(2, "haead")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["afhhc"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["haead", "jijbe", "gdhfa", "fcjej", "agcci", "igddi", "iehfb", "dgjcf", "ifjca", "gjadb", "diifi"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                15,
                [
                    new InsertOperation(14, "fbedc"),
                    new InsertOperation(4, "hheai"),
                    new InsertOperation(13, "ehbdj"),
                    new InsertOperation(5, "hdafj"),
                    new InsertOperation(7, "gcgaa"),
                    new InsertOperation(15, "cebje"),
                    new InsertOperation(10, "afchf"),
                    new InsertOperation(3, "ecggd"),
                    new InsertOperation(1, "ebcdg"),
                    new InsertOperation(6, "hecdc"),
                    new InsertOperation(11, "hfgjh"),
                    new InsertOperation(2, "jhhdd"),
                    new InsertOperation(12, "jbebf"),
                    new InsertOperation(8, "jejhd"),
                    new InsertOperation(9, "hdiha")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["ebcdg"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["jhhdd", "ecggd", "hheai", "hdafj", "hecdc", "gcgaa"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["jejhd"]),
                    new InsertOperation.Result(["hdiha", "afchf", "hfgjh", "jbebf", "ehbdj", "fbedc", "cebje"])
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(
                20,
                [
                    new InsertOperation(18, "jjbdd"),
                    new InsertOperation(11, "fhcca"),
                    new InsertOperation(13, "ahcdc"),
                    new InsertOperation(16, "gbbdd"),
                    new InsertOperation(5, "jiadj"),
                    new InsertOperation(3, "fadce"),
                    new InsertOperation(19, "gjiag"),
                    new InsertOperation(1, "didch"),
                    new InsertOperation(8, "fghhi"),
                    new InsertOperation(4, "aegab"),
                    new InsertOperation(2, "hdafi"),
                    new InsertOperation(14, "ajccd"),
                    new InsertOperation(9, "jdhda"),
                    new InsertOperation(6, "hhiii"),
                    new InsertOperation(7, "fgafc"),
                    new InsertOperation(17, "iabdd"),
                    new InsertOperation(20, "effga"),
                    new InsertOperation(12, "effed"),
                    new InsertOperation(10, "hdjjb"),
                    new InsertOperation(15, "ibcib")
                ],
                [
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["didch"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["hdafi", "fadce", "aegab", "jiadj"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["hhiii"]),
                    new InsertOperation.Result(["fgafc", "fghhi", "jdhda"]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result([]),
                    new InsertOperation.Result(["hdjjb", "fhcca", "effed", "ahcdc", "ajccd"]),
                    new InsertOperation.Result(["ibcib", "gbbdd", "iabdd", "jjbdd", "gjiag", "effga"])
                ])
        ];
    }

    public sealed class OrderedStreamScenario : IScenario<IDesignAnOrderedStream>
    {
        public OrderedStreamScenario(int size, IOperation<IDesignAnOrderedStream>[] operations, IOperationResult[] operationResults)
        {
            Size = size;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int Size { get; }

        public IOperation<IDesignAnOrderedStream>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class InsertOperation : IOperation<IDesignAnOrderedStream>
    {
        private readonly int _idKey;
        private readonly string _value;

        public InsertOperation(int idKey, string value)
        {
            _idKey = idKey;
            _value = value;
        }

        public IOperationResult Execute(IDesignAnOrderedStream designAnOrderedStream)
        {
            var chunk = designAnOrderedStream.Insert(_idKey, _value);

            return new Result(chunk);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly IList<string?> _chunk;

            public Result(IList<string?> chunk)
            {
                _chunk = chunk;
            }

            public bool Equals(Result? other)
            {
                if (other is null || _chunk.Count != other._chunk.Count)
                {
                    return false;
                }

                for (var i = 0; i < _chunk.Count; i++)
                {
                    if (_chunk[i] != other._chunk[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                for (var i = 0; i < _chunk.Count; i++)
                {
                    var value = _chunk[i];

                    hashCode.Add(value);
                }

                return hashCode.ToHashCode();
            }
        }
    }
}