using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos.QueryParams.Book
{
    public class PostQueryParams : PageableParams
    {
        public int[] Tags { get; set; }
        public string SearchTerm { get; set; }
        public SortableParams SortableParams { get; set; }
    } 
}
