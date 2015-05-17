using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNETI.FIT.Models.ViewModels
{
    public class FilterModel
    {
        public int? page { get; set; }
        public int PageIndex { get { return this.page ?? 1; } }
        public int PageSize { get; set; }//Total items per page
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        public string sort { get; set; }
        public string SortOrder { get { return this.sort ?? ""; } }

        public string kw { get; set; }
        public string SearchString { get { return this.kw ?? ""; } }

        public string cate { get; set; }
        public string CategoryName { get { return this.cate ?? ""; } }

        public string state { get; set; }
        public string StateName { get { return this.state ?? ""; } }

        public string CurrentFileter { get; set; }

        public FilterModel()
        {
            PageSize = 10;
        }
    }
}