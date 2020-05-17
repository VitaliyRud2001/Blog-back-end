using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos.QueryParams
{
    public class SortableParams
    {
        public string OrderByField { get; set; }

        public bool OrderByDesceding { get; set; } = true;
    }
}
