﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Scaffolder.Core.Meta
{
    public class Filter
    {
        public Filter()
        {
            PageSize = 10;
            SortOrder = SortOrder.Ascending;
            SortColumn = String.Empty;
            CurrentPage = 1;
            Parameters = new Dictionary<string, object>();
            TableName = "";
            DetailMode = false;
        }

        public string TableName { get; set; }

        public bool DetailMode { get; set; }

        public SortOrder SortOrder { get; set; }

        public String SortColumn { get; set; }

        public Dictionary<String, Object> Parameters { get; set; }

        public int CurrentPage { get; set; }

        public int? PageSize { get; set; }
    }
}
