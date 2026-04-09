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

namespace LeetCode.Tests.Base.Scenarios;

/// <summary>
///     Represents an operation result for operations that do not return a value.
///     Implements the Singleton pattern to avoid unnecessary allocations.
/// </summary>
public sealed class VoidOperationResult : IOperationResult
{
    /// <summary>
    ///     Gets the single shared instance of <see cref="VoidOperationResult" />.
    /// </summary>
    public static readonly VoidOperationResult Instance = new();

    private VoidOperationResult()
    {
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Two <see cref="VoidOperationResult" /> instances are always considered equal
    ///     because the type carries no state.
    /// </remarks>
    public override bool Equals(object? obj)
    {
        return obj is VoidOperationResult;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Returns a constant hash code of <c>0</c> since all instances are equivalent.
    /// </remarks>
    public override int GetHashCode()
    {
        return 0;
    }
}