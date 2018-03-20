using System.Collections.Generic;
using System.Windows.Forms;

namespace NewsReaderPPE
{
    class NewsLinkLabel
    {
        public static LinkLabel CreateLinkLabel(string news, List<string> links, int count)
        {
            var hypertext = new LinkLabel();
            hypertext.Text = news;
            hypertext.AutoSize = true;

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = links[count];
            hypertext.Links.Add(link);
            return hypertext;
        }
    }
}
