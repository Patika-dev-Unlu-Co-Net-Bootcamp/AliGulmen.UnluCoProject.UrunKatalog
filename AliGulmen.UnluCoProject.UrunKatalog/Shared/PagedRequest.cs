using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.UnluCoProject.UrunKatalog.Shared
{
    public abstract class PagedRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public string[] Orderby { get; set; }
    }

}