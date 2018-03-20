using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReaderPPE
{
    public class NewsData
    {
        public List<string> ArticleHeaders { get; set; }
        public List<string> ArticleLinks { get; set; }
        public static NewsData Create(List<string> articles, List<string> links)
        {
            return new NewsData { ArticleHeaders = articles, ArticleLinks = links };
        }
    }
}
