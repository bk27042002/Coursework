using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class UserControlGuest : UserControl
    {
        public UserControlGuest()
        {
            InitializeComponent();
        }

        ListNews _news = new ListNews();
        ListNews _tmpNews = new ListNews();
        public void Start()
        {
            _news.Load();
            _tmpNews = _news;
            FillList(_news);
        }

        private void FillList(ListNews news)
        {
            listBoxNews.Items.Clear();
            listBoxNews.Items.AddRange(news.InfoStrings().ToArray());
        }

        private void buttonFindByDate_Click(object sender, EventArgs e)
        {
            _tmpNews = _news.FindByDate(DateTime.Parse(textBoxSort.Text));
            FillList(_tmpNews);
        }

        private void buttonFindByHead_Click(object sender, EventArgs e)
        {
            _tmpNews = _news.FindByHeading(textBoxSort.Text);
            FillList(_tmpNews);
        }

        private void buttonFindByWord_Click(object sender, EventArgs e)
        {
            _tmpNews = _news.FindByWord(textBoxSort.Text);
            FillList(_tmpNews);
        }

        private void buttonFindByAuthor_Click(object sender, EventArgs e)
        {
            _tmpNews = _news.FindByAuthor(textBoxSort.Text);
            FillList(_tmpNews);
        }

        private void buttonSortByVotes_Click(object sender, EventArgs e)
        {
            _tmpNews = _news;
            FillList(_tmpNews.SortByVotes());
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            _tmpNews = _news;
            FillList(_news);
        }

        private void listBoxNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            News current = _tmpNews.FindByIndex(listBoxNews.SelectedIndex);
            textBoxHead.Text = current.Heading;
            textBoxBody.Text = current.Body;
        }

        private void buttonVote_Click(object sender, EventArgs e)
        {
            News oldNews = _tmpNews.FindByIndex(listBoxNews.SelectedIndex);
            News newNews = new News(
                oldNews.Heading,
                oldNews.Date,
                oldNews.Author,
                oldNews.Body,
                oldNews.Votes+1
                );
            ListNews.SaveChanges(oldNews, newNews);
            Start();
        }
    }
}
