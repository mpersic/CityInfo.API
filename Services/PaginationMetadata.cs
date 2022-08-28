﻿namespace CityInfo.API.Services
{
    public class PaginationMetadata
    {
        #region Constructors

        public PaginationMetadata(int totalItemCount, int pageSize, int currentPage)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            TotalPageCount = (int)Math.Ceiling((totalItemCount) / (double)pageSize);
            CurrentPage = currentPage;
        }

        #endregion Constructors

        #region Properties

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }

        #endregion Properties
    }
}