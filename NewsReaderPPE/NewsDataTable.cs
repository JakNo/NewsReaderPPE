using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReaderPPE
{
    class NewsDataTable
    {
        public static DataTable CreateDataTable(NewsData articles)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("News title", typeof(string));
            dt.Columns.Add("Link", typeof(string));
            for (int i=0; i<articles.ArticleHeaders.Count; i++)
                dt.Rows.Add(articles.ArticleHeaders[i], articles.ArticleLinks[i]);
            return dt;
        }
    }
}
