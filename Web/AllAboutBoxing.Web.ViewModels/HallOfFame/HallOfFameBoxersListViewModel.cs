﻿namespace AllAboutBoxing.Web.ViewModels.HallOfFame
{
    using System;
    using System.Collections.Generic;

    public class HallOfFameBoxersListViewModel
    {
        public IEnumerable<HallOfFameBoxerInListViewModel> HallOfFameBoxers { get; set; }

        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.BoxersCount / this.ItemsPerPage);

        public int BoxersCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
