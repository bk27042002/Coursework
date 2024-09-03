using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class ListNews
    {
        List<News> _news = new List<News>();

        public ListNews() { }
        public ListNews(List<News> news)
        {
            _news = news;
        }
        public void Add (News news)
        {
            _news.Add(news);
        }

        public void Save()
        {
            using(StreamWriter streamWriter = new StreamWriter("../../News.txt"))
            {
                foreach (News news in _news)
                    streamWriter.WriteLine(news.SaveString);
            }
        }

        public static void SaveNewNews(News news)
        {
            using(StreamWriter streamWriter = new StreamWriter("../../News.txt", true))
            {
                streamWriter.WriteLine(news.SaveString);
            }
        }

        public void Load()
        {
            _news.Clear();
            string info;
            using (StreamReader streamReader = new StreamReader("../../News.txt"))
                info = streamReader.ReadToEnd().Replace("\r", "");
            List<string> parts = new List<string>(info.Split('\n'));
            parts.RemoveAt(parts.Count - 1);
            foreach (string part in parts)
                _news.Add(new News(part));
        }
        public List<string> InfoStrings()
        {
            List<string> result = new List<string>();
            foreach (News news in _news)
                result.Add(news.OutString);
            return result;
        }

        public ListNews SortByVotes()
        {
            ListNews result = new ListNews(this._news);
            result._news.Sort();
            return result;
        }

        public ListNews FindByDate(DateTime dateTime)
        {
            ListNews result = new ListNews();
            foreach(News news in _news)
            {
                if (news.Date == dateTime.Date)
                    result.Add(news);
            }
            return result;
        }

        public ListNews FindByHeading(string heading)
        {
            ListNews result = new ListNews();
            foreach (News news in _news)
            {
                if (news.Heading == heading)
                    result.Add(news);
            }
            return result;
        }

        public ListNews FindByWord(string word)
        {
            ListNews result = new ListNews();
            foreach (News news in _news)
            {
                if (news.Body.Contains(word))
                    result.Add(news);
            }
            return result;
        }

        public ListNews FindByAuthor(string author)
        {
            ListNews result = new ListNews();
            foreach (News news in _news)
            {
                if (news.Author == author)
                    result.Add(news);
            }
            return result;
        }

        public News FindByIndex(int id)
        {
            return _news[id];
        }

        public List<string> HeadStrings()
        {
            List<string> result = new List<string>();
            foreach (News news in _news)
                result.Add(news.HeadString);
            return result;
        }

        public static void SaveChanges(News oldNews, News newNews)
        {
            ListNews newsList = new ListNews();
            newsList.Load();
            int id = -1;
            foreach(News news in newsList._news)
            {
                if (oldNews.Compare(news))
                {
                    id = newsList._news.IndexOf(news);
                    break;
                } 
            }
            if(id != -1)
            {
                newsList._news[id] = newNews;
                newsList.Save();
            }

        }
    }
}
