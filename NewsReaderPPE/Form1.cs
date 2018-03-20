using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsReaderPPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string websiteSourceCode = WebsiteSourceCode.GetSourceCode("ppe.pl");
            var dataForNews = NewsSourceCode.CreateListOfHeadersAndLinks(websiteSourceCode);
            var articles = dataForNews.ArticleHeaders;
            var links = dataForNews.ArticleLinks;
            int count = 0;
            foreach (string news in articles)
            {
                var hypertext = NewsLinkLabel.CreateLinkLabel(news, links, count);
                hypertext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hypertext_LinkClicked);
                flowLayoutPanel1.Controls.Add(hypertext);
                flowLayoutPanel1.SetFlowBreak(hypertext, true);
                Label line = new Label();
                line.Height = 20;
                line.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(line);
                count++;
            }
            dataGridView1.DataSource = NewsDataTable.CreateDataTable(dataForNews);
        }

        private void hypertext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
