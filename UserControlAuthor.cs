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
    public partial class UserControlAuthor : UserControl
    {
        public UserControlAuthor()
        {
            InitializeComponent();
        }
        private string _author = "admin";
        private ListNews _news = new ListNews();
        private News _editingNews;
        
        public void SetAuthor(string author)
        {
            _author = author;
        }
        private void buttonToPublish_Click(object sender, EventArgs e)
        {
            News news = new News(
                textBoxHeading.Text,
                 DateTime.Now,
                 _author,
                 textBoxBody.Text,
                 0
                 );
            ListNews.SaveNewNews(news);
            _news.Add(news);
            MessageBox.Show("Новость успешно опубликованна!!!");
        }

        private void Reload()
        {
            listBoxNews.Items.Clear();
            _news.Load();
            _news = _news.FindByAuthor(_author);
            listBoxNews.Items.AddRange(_news.HeadStrings().ToArray());
        }

        private void buttonLoadMyNews_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void buttonEditing_Click(object sender, EventArgs e)
        {
            _editingNews = _news.FindByIndex(listBoxNews.SelectedIndex);
            textBoxHeading.Text = _editingNews.Heading;
            textBoxBody.Text = _editingNews.Body;
            buttonToPublish.Visible = false;
            buttonSaveChanges.Visible = true;
            buttonCancelChanges.Visible = true;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            News newNews = new News(
                textBoxHeading.Text,
                _editingNews.Date,
                _author,
                textBoxBody.Text,
                _editingNews.Votes
                );
            ListNews.SaveChanges(_editingNews, newNews);
            _editingNews = null;
            Reload();
            buttonCancelChanges.Visible = false;
            buttonSaveChanges.Visible = false;
            buttonToPublish.Visible = true;
            textBoxBody.Text = string.Empty;
            textBoxHeading.Text = string.Empty;
        }

        private void buttonCancelChanges_Click(object sender, EventArgs e)
        {
            textBoxBody.Text = string.Empty;
            textBoxHeading.Text = string.Empty;
            buttonCancelChanges.Visible = false;
            buttonSaveChanges.Visible = false;
            buttonToPublish.Visible = true;
        }
    }
}
