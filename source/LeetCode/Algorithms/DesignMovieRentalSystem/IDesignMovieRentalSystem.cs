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

namespace LeetCode.Algorithms.DesignMovieRentalSystem;

/// <summary>
///     https://leetcode.com/problems/design-movie-rental-system/description/
/// </summary>
public interface IDesignMovieRentalSystem
{
    /// <summary>
    ///     Finds up to 5 cheapest shops that currently have <paramref name="movie" /> available for rent.
    /// </summary>
    /// <param name="movie">The identifier of the movie to search for.</param>
    /// <returns>
    ///     Up to 5 shop identifiers that have <paramref name="movie" /> available, sorted by ascending price and then
    ///     ascending shop identifier.
    /// </returns>
    IList<int> Search(int movie);

    /// <summary>
    ///     Rents out <paramref name="movie" /> from <paramref name="shop" />, marking it as unavailable.
    /// </summary>
    /// <param name="shop">The identifier of the shop renting out the movie.</param>
    /// <param name="movie">The identifier of the movie being rented.</param>
    void Rent(int shop, int movie);

    /// <summary>
    ///     Returns <paramref name="movie" /> to <paramref name="shop" />, marking it as available again.
    /// </summary>
    /// <param name="shop">The identifier of the shop the movie is returned to.</param>
    /// <param name="movie">The identifier of the movie being returned.</param>
    void Drop(int shop, int movie);

    /// <summary>
    ///     Finds up to 5 cheapest currently rented movies across all shops.
    /// </summary>
    /// <returns>
    ///     Up to 5 [shop, movie] pairs for currently rented movies, sorted by ascending price and then ascending shop
    ///     identifier and then ascending movie identifier.
    /// </returns>
    IList<IList<int>> Report();
}