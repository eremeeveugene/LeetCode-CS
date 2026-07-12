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

/// <inheritdoc />
public sealed class DesignMovieRentalSystemDictionary : IDesignMovieRentalSystem
{
    private const int ResultsCount = 5;
    private readonly Dictionary<int, SortedSet<MovieOffer>> _movieToMovieOffersDictionary;
    private readonly SortedSet<RentalRecord> _rentalRecordsSortedSet = [];
    private readonly Dictionary<(int Shop, int Movie), int> _shopMovieToPriceDictionary;

    /// <summary>
    ///     Time complexity - O(m log m), where m is the length of entries
    ///     Space complexity - O(m)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="entries"></param>
    public DesignMovieRentalSystemDictionary(int n, int[][] entries)
    {
        var entriesLength = entries.Length;

        _movieToMovieOffersDictionary = new Dictionary<int, SortedSet<MovieOffer>>(entriesLength);
        _shopMovieToPriceDictionary = new Dictionary<(int Shop, int Movie), int>(entriesLength);

        for (var i = 0; i < entriesLength; i++)
        {
            var entry = entries[i];
            var shop = entry[0];
            var movie = entry[1];
            var price = entry[2];

            _shopMovieToPriceDictionary.Add((shop, movie), price);

            if (!_movieToMovieOffersDictionary.TryGetValue(movie, out var movieOffers))
            {
                movieOffers = [];

                _movieToMovieOffersDictionary[movie] = movieOffers;
            }

            movieOffers.Add(new MovieOffer(price, shop));
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> Search(int movie)
    {
        if (!_movieToMovieOffersDictionary.TryGetValue(movie, out var movieOffers))
        {
            return [];
        }

        var movieOffersCount = movieOffers.Count;

        if (movieOffersCount == 0)
        {
            return [];
        }

        var searchResultsCount = Math.Min(movieOffersCount, ResultsCount);

        var searchResults = new int[searchResultsCount];

        var searchResultsIndex = 0;

        foreach (var movieOffer in movieOffers)
        {
            searchResults[searchResultsIndex] = movieOffer.Shop;

            searchResultsIndex++;

            if (searchResultsIndex == searchResultsCount)
            {
                break;
            }
        }

        return searchResults;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<IList<int>> Report()
    {
        var rentalItemsCount = _rentalRecordsSortedSet.Count;

        if (rentalItemsCount == 0)
        {
            return [];
        }

        var reportResultsCount = Math.Min(rentalItemsCount, ResultsCount);

        var reportResults = new IList<int>[reportResultsCount];

        var reportResultsIndex = 0;

        foreach (var rentalItem in _rentalRecordsSortedSet)
        {
            reportResults[reportResultsIndex] = rentalItem.GetReport();

            reportResultsIndex++;

            if (reportResultsIndex == reportResultsCount)
            {
                break;
            }
        }

        return reportResults;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log m), where m is the number of offers for the movie
    ///     Space complexity - O(1)
    /// </remarks>
    public void Rent(int shop, int movie)
    {
        var price = _shopMovieToPriceDictionary[(shop, movie)];

        _rentalRecordsSortedSet.Add(new RentalRecord(shop, movie, price));

        var movieOffers = _movieToMovieOffersDictionary[movie];

        movieOffers.Remove(new MovieOffer(price, shop));
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log m), where m is the number of offers for the movie
    ///     Space complexity - O(1)
    /// </remarks>
    public void Drop(int shop, int movie)
    {
        var price = _shopMovieToPriceDictionary[(shop, movie)];

        _rentalRecordsSortedSet.Remove(new RentalRecord(shop, movie, price));

        var movieOffers = _movieToMovieOffersDictionary[movie];

        movieOffers.Add(new MovieOffer(price, shop));
    }

    public readonly record struct MovieOffer(int Price, int Shop) : IComparable<MovieOffer>
    {
        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="movieOffer"></param>
        /// <returns></returns>
        public int CompareTo(MovieOffer movieOffer)
        {
            var priceComparison = CompareToPrice(movieOffer.Price);

            return priceComparison != 0 ? priceComparison : CompareToShop(movieOffer.Shop);
        }

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        private int CompareToPrice(int price)
        {
            return Price.CompareTo(price);
        }

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        private int CompareToShop(int shop)
        {
            return Shop.CompareTo(shop);
        }
    }

    private readonly record struct RentalRecord(int Shop, int Movie, int Price) : IComparable<RentalRecord>
    {
        private readonly int[] _report = new int[2];

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="rentalRecord"></param>
        /// <returns></returns>
        public int CompareTo(RentalRecord rentalRecord)
        {
            var priceComparison = CompareToPrice(rentalRecord.Price);

            if (priceComparison != 0)
            {
                return priceComparison;
            }

            var shopComparison = CompareToShop(rentalRecord.Shop);

            return shopComparison != 0 ? shopComparison : CompareToMovie(rentalRecord.Movie);
        }

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <returns></returns>
        public int[] GetReport()
        {
            _report[0] = Shop;
            _report[1] = Movie;

            return _report;
        }

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        private int CompareToPrice(int price)
        {
            return Price.CompareTo(price);
        }

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        private int CompareToShop(int shop)
        {
            return Shop.CompareTo(shop);
        }

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        private int CompareToMovie(int movie)
        {
            return Movie.CompareTo(movie);
        }
    }
}