using System.Collections.Generic;

namespace NestWeb.ViewModels
{
    public class PaginateVM<T>
    {
        public List<T> Items{ get; set; }
        public int PageCount { get; set; }
        public int ActivePage { get; set; }
    }
}
