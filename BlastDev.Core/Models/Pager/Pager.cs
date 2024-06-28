using BlastDev.Core.Abstractions;

namespace BlastDev.Core.Models.Pager
{
    public class Pager<T> where T : IBase
    {
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int StartPage { get; private set; }
        public int EndPage { get; private set; }
        public int StartIndex { get; private set; }
        public int EndIndex { get; private set; }
        public IEnumerable<int> Pages { get;private set; }
        public List<T> Data { get; private set; }

        public Pager(int totalItems,List<T> data, int currentPage =1, int pageSize=10, int maxPages=10)
        {
            var totalPages = (int)Math.Ceiling((decimal)totalItems/(decimal)pageSize);

            if (currentPage < 1)
                currentPage = 1;
            else if (currentPage > totalPages)
                currentPage = totalPages;

            int startPage, endPage;
            if(totalPages <= maxPages)
            {
                startPage = 1;
                endPage = totalPages;
            }
            else
            {
                var maxPagesBeforeCurrentPage = (int)Math.Floor((decimal)maxPages/(decimal)2);
                var maxPagesAfterCurrentPage = (int)Math.Ceiling((decimal)maxPages / (decimal)2) - 1;
                if(currentPage <= maxPagesBeforeCurrentPage)
                {
                    startPage = 1;
                    endPage = maxPages;
                }
                else if(currentPage + maxPagesAfterCurrentPage >= totalPages)
                {
                    startPage = totalPages - maxPages + 1;
                    endPage = totalPages;
                }
                else
                {
                    startPage = currentPage - maxPagesBeforeCurrentPage;
                    endPage = currentPage + maxPagesAfterCurrentPage;
                }
            }
            var startIndex = (currentPage - 1) * pageSize;
            var endIndex = Math.Min(startIndex + pageSize - 1, totalItems - 1);
            var pages = Enumerable.Range(startPage, (endPage + 1) - startPage);

            this.TotalItems = totalItems;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize; 
            this.TotalPages = totalPages;
            this.StartPage = startPage;
            this.EndPage = endPage;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Pages = pages;
            this.Data = data;
        }
    }
}
