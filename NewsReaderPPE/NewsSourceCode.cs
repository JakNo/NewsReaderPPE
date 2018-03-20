using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReaderPPE
{
    class NewsSourceCode
    {
        public static NewsData CreateListOfHeadersAndLinks(string webSourceCode)
        {
            List<string> articles = new List<string>();
            List<string> links = new List<string>();
            while (webSourceCode.Contains("likeh1"))
            {
                string currentNewsHeader = TextBetween.getBetween(webSourceCode, "likeh1 di\">", "</a>");
                string currentNewsLink = "www.ppe.pl" + TextBetween.getBetween(currentNewsHeader, "<a href=\"", "\">");

                if (!links.Contains(currentNewsLink) && !articles.Contains(currentNewsHeader))
                {
                        links.Add(currentNewsLink);
                        currentNewsHeader = currentNewsHeader.Substring(currentNewsHeader.IndexOf("\">") + 2);
                        articles.Add(currentNewsHeader);
                }
                webSourceCode = webSourceCode.Substring(webSourceCode.IndexOf("likeh1") + 10);
            }
            return NewsData.Create(articles, links);
        }
    }
}
